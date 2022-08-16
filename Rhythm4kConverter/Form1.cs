using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Windows.Forms;
using System.IO;

public struct Song
{
    public string Name { get; set; }
    public string Artist { get; set; }
    public string Sound { get; set; }
    public float Offset { get; set; }
    public float SampleStart { get; set; }
    public float SampleLength { get; set; }
    public float BPM { get; set; }
    public List<Chart> Charts { get; set; }
}

public struct Chart
{
    public string Name { get; set; }
    public string CharterName { get; set; }
    public int Difficulty { get; set; }
    public List<BpmChange> BpmChanges { get; set; }
    public List<Note> Notes { get; set; }
}

public struct Note
{
    public float Offset { get; set; }
    public float Length { get; set; }
    public int Type { get; set; }
    public int Lane { get; set; }

    public Note(float offset, int lane, int type, float length = 0f)
    {
        Offset = offset;
        Lane = lane;
        Type = type;
        Length = length;
    }
}

public struct BpmChange
{
    public float Offset { get; set; }
    public float BPM { get; set; }

    public BpmChange(float offset, float bpm)
    {
        Offset = offset;
        BPM = bpm;
    }
}

namespace Rhythm4kConverter
{
    public partial class Form1 : Form
    {
        public Song LoadedSong;
        public int SelectedChart = 0;
        public Form1()
        {
            InitializeComponent();

            AllowDrop = true;
            DragEnter += new DragEventHandler(Form1_DragDrop);
            DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                LoadSong(files[0]);
            }
        }

        private void listCharts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listCharts.SelectedIndex >= 0) SelectChart(listCharts.SelectedIndex);
        }

        private void SelectChart(int i = 0)
        {
            SelectedChart = i;
            Chart chart = LoadedSong.Charts[i];

            txtChartName.Text = chart.Name;
            txtChartCreator.Text = chart.CharterName;
            numDifficulty.Value = chart.Difficulty;
            lblChartInfo.Text = $"{chart.Notes.Count} Notes | {chart.BpmChanges.Count - 1} BPM Changes";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadSong(string file)
        {
            bool success = true;
            LoadedSong = new Song();
            SelectedChart = 0;

            switch (Path.GetExtension(file))
            {
                case ".sm":
                    LoadedSong = SMtoChart(file);
                    break;
                default:
                    success = false;
                    break;
            }

            if (success)
            {
                lblDragToStart.Visible = false;
                pnlSettings.Visible = true;

                toolSaveR4K.Enabled = true;

                txtSongTitle.Text = LoadedSong.Name;
                txtSongArtist.Text = LoadedSong.Artist;
                txtSongFile.Text = LoadedSong.Sound;
                txtSongOffset.Text = LoadedSong.Offset.ToString();
                txtSampleStart.Text = LoadedSong.SampleStart.ToString();
                txtSampleLength.Text = LoadedSong.SampleLength.ToString();
                txtMainBPM.Text = LoadedSong.BPM.ToString();

                listCharts.Items.Clear();
                foreach (var chart in LoadedSong.Charts)
                {
                    listCharts.Items.Add($"{chart.Name} ({chart.Difficulty})");
                }

                SelectChart();
            }
        }

        private Song SMtoChart(string file)
        {
            string text = File.ReadAllText(file);
            string[] properties = text.Split('#');
            Song song = new Song();
            List<BpmChange> bpmChanges = new List<BpmChange>();
            song.Charts = new List<Chart>();
            string charterName = "";

            string value;
            foreach(string prop in properties)
            {
                value = SMGetValue(prop, "TITLE");
                if(value != "")
                {
                    song.Name = value;
                    continue;
                }
                value = SMGetValue(prop, "ARTIST");
                if(value != "")
                {
                    song.Artist = value;
                    continue;
                }
                value = SMGetValue(prop, "CREDIT");
                if(value != "")
                {
                    charterName = value;
                    continue;
                }
                value = SMGetValue(prop, "MUSIC");
                if(value != "")
                {
                    song.Sound = value.Replace(Path.GetExtension(value), ".vsnd");
                    continue;
                }
                value = SMGetValue(prop, "BPMS");
                if(value != "")
                {
                    string[] changes = value.Trim().Split(',');
                    foreach(string change in changes)
                    {
                        var vals = change.Split('=');
                        bpmChanges.Add(new BpmChange(float.Parse(vals[0]), float.Parse(vals[1])));
                    }
                    song.BPM = bpmChanges[0].BPM;
                    continue;
                }
                value = SMGetValue(prop, "OFFSET");
                if(value != "")
                {
                    song.Offset = float.Parse(value);
                    continue;
                }
                value = SMGetValue(prop, "SAMPLESTART");
                if(value != "")
                {
                    song.SampleStart = float.Parse(value);
                    continue;
                }
                value = SMGetValue(prop, "SAMPLELENGTH");
                if (value != "")
                {
                    song.SampleLength = float.Parse(value);
                    continue;
                }
                value = SMGetValue(prop, "NOTES");
                if(value != "")
                {
                    string[] noteSplit = value.Split('\n');
                    
                    // If the chart is a valid single player chart
                    if(noteSplit[1].Contains("-single:"))
                    {
                        float[] holding = { -1, -1, -1, -1 };
                        Chart chart = new Chart();
                        chart.Notes = new List<Note>();
                        chart.BpmChanges = bpmChanges;
                        chart.Name = noteSplit[3].Trim().Replace(":", "");
                        chart.Difficulty = int.Parse(noteSplit[4].Trim().Replace(":", ""));
                        chart.CharterName = charterName;

                        // Remove header and useless characters from the string
                        for (int i = 0; i < 6; i++) value = value.Substring(value.IndexOf("\n") + 1);
                        value = Regex.Replace(value, "//.*", "");
                        value = Regex.Replace(value, "\\;", "");

                        // Re-split into arrays that contain each measure
                        noteSplit = Regex.Split(value, "\\,");
                        int measure = 0;
                        foreach(string note in noteSplit)
                        {
                            var lines = note.Trim().Split('\n');
                            var division = 1f / (lines.Length == 96 ? 192 : lines.Length);
                            int beat = 0;

                            // Loop through each line in the measure
                            foreach(var line in lines)
                            {
                                float time = (measure * 1000f) + (beat * division * 1000f);
                                for (int i=0; i < 4; i++)
                                {
                                    switch(line[i])
                                    {
                                        case '1':
                                            chart.Notes.Add(new Note(time, i, 0));
                                            break;
                                        case '2':
                                            holding[i] = time;
                                            break;
                                        case '3':
                                            if(holding[i] != -1)
                                            {
                                                chart.Notes.Add(new Note(holding[i], i, 0, time - holding[i]));
                                                holding[i] = -1;
                                            }
                                            break;
                                    }
                                }
                                beat++;
                            }
                            measure++;
                        }
                        
                        song.Charts.Add(chart);
                    }
                    continue;
                }
            }

            return song;
        }

        private string SMGetValue(string text, string tag)
        {
            var split = text.Split(':');
            if(split.Length >= 2)
            {
                var tagToCheck = split[0].Replace("#", "").Replace(";", "");
                if(tagToCheck.ToLower() == tag.ToLower())
                {
                    if (split.Length > 2)
                    {
                        return text.Remove(0, 6);
                    }
                    return split[1].Replace(";", "").Trim();
                }
            }
            return "";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtChartName_TextChanged(object sender, EventArgs e)
        {
            Chart chart = LoadedSong.Charts[SelectedChart];
            chart.Name = txtChartName.Text;
            LoadedSong.Charts[SelectedChart] = chart;

            UpdateChartList(SelectedChart, chart);
        }

        private void numDifficulty_ValueChanged(object sender, EventArgs e)
        {
            Chart chart = LoadedSong.Charts[SelectedChart];
            chart.Difficulty = (int)numDifficulty.Value;
            LoadedSong.Charts[SelectedChart] = chart;

            UpdateChartList(SelectedChart, chart);
        }

        private void txtChartCreator_TextChanged(object sender, EventArgs e)
        {
            Chart chart = LoadedSong.Charts[SelectedChart];
            chart.CharterName = txtChartCreator.Text;
            LoadedSong.Charts[SelectedChart] = chart;
        }

        private void UpdateChartList(int i, Chart chart)
        {
            listCharts.Items.RemoveAt(i);
            listCharts.Items.Insert(i, $"{chart.Name} ({chart.Difficulty})");
        }

        private void toolNew_Click(object sender, EventArgs e)
        {
            lblDragToStart.Visible = true;
            pnlSettings.Visible = false;

            toolSaveR4K.Enabled = false;
        }

        private void toolOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Stepmania charts (*.sm)|*.sm|All files (*.*)|*.*";
                ofd.RestoreDirectory = true;

                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    LoadSong(ofd.FileName);
                    return;
                }
            }
        }

        // Export .r4k file
        private void btnSave_Click(object sender, EventArgs e)
        {
            string jsonString = JsonSerializer.Serialize(LoadedSong);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rhythm4K Chart|*.r4k";
            saveFileDialog.Title = "Save chart file";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.ShowDialog();

            if(saveFileDialog.FileName != "")
            {
                File.WriteAllText(saveFileDialog.FileName, jsonString);
            }
        }
    }
}
