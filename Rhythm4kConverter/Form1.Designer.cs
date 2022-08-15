namespace Rhythm4kConverter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDragToStart = new System.Windows.Forms.Label();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.txtMainBPM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSampleLength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSampleStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSongOffset = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSongFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSongArtist = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSongTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listCharts = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtChartName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtChartCreator = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numDifficulty = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblChartInfo = new System.Windows.Forms.Label();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDifficulty)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDragToStart
            // 
            this.lblDragToStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDragToStart.Location = new System.Drawing.Point(12, 160);
            this.lblDragToStart.Name = "lblDragToStart";
            this.lblDragToStart.Size = new System.Drawing.Size(360, 58);
            this.lblDragToStart.TabIndex = 0;
            this.lblDragToStart.Text = "Drag a chart file here";
            this.lblDragToStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.groupBox1);
            this.pnlSettings.Controls.Add(this.btnSave);
            this.pnlSettings.Controls.Add(this.txtMainBPM);
            this.pnlSettings.Controls.Add(this.label7);
            this.pnlSettings.Controls.Add(this.txtSampleLength);
            this.pnlSettings.Controls.Add(this.label6);
            this.pnlSettings.Controls.Add(this.txtSampleStart);
            this.pnlSettings.Controls.Add(this.label5);
            this.pnlSettings.Controls.Add(this.txtSongOffset);
            this.pnlSettings.Controls.Add(this.label4);
            this.pnlSettings.Controls.Add(this.txtSongFile);
            this.pnlSettings.Controls.Add(this.label3);
            this.pnlSettings.Controls.Add(this.txtSongArtist);
            this.pnlSettings.Controls.Add(this.label2);
            this.pnlSettings.Controls.Add(this.txtSongTitle);
            this.pnlSettings.Controls.Add(this.label1);
            this.pnlSettings.Location = new System.Drawing.Point(12, 12);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(360, 364);
            this.pnlSettings.TabIndex = 1;
            this.pnlSettings.Visible = false;
            // 
            // txtMainBPM
            // 
            this.txtMainBPM.Location = new System.Drawing.Point(128, 159);
            this.txtMainBPM.Name = "txtMainBPM";
            this.txtMainBPM.Size = new System.Drawing.Size(192, 20);
            this.txtMainBPM.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(31, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "Main BPM:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.label7, "The BPM to show on the menu for the song\'s listing");
            // 
            // txtSampleLength
            // 
            this.txtSampleLength.Location = new System.Drawing.Point(128, 133);
            this.txtSampleLength.Name = "txtSampleLength";
            this.txtSampleLength.Size = new System.Drawing.Size(192, 20);
            this.txtSampleLength.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(31, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sample Length:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.label6, "The length of the song\'s menu sample in seconds");
            // 
            // txtSampleStart
            // 
            this.txtSampleStart.Location = new System.Drawing.Point(128, 107);
            this.txtSampleStart.Name = "txtSampleStart";
            this.txtSampleStart.Size = new System.Drawing.Size(192, 20);
            this.txtSampleStart.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(31, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sample Start:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.label5, "The start of the song\'s in-game sample in seconds");
            // 
            // txtSongOffset
            // 
            this.txtSongOffset.Location = new System.Drawing.Point(128, 81);
            this.txtSongOffset.Name = "txtSongOffset";
            this.txtSongOffset.Size = new System.Drawing.Size(192, 20);
            this.txtSongOffset.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(31, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Offset:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.label4, "The amount of offset in seconds until the song starts");
            // 
            // txtSongFile
            // 
            this.txtSongFile.Location = new System.Drawing.Point(128, 55);
            this.txtSongFile.Name = "txtSongFile";
            this.txtSongFile.Size = new System.Drawing.Size(192, 20);
            this.txtSongFile.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(31, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sound File:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.label3, "The path of the song\'s vsnd file");
            // 
            // txtSongArtist
            // 
            this.txtSongArtist.Location = new System.Drawing.Point(128, 29);
            this.txtSongArtist.Name = "txtSongArtist";
            this.txtSongArtist.Size = new System.Drawing.Size(192, 20);
            this.txtSongArtist.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(31, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Artist Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.label2, "The name of the artist as it should appear in-game");
            // 
            // txtSongTitle
            // 
            this.txtSongTitle.Location = new System.Drawing.Point(128, 3);
            this.txtSongTitle.Name = "txtSongTitle";
            this.txtSongTitle.Size = new System.Drawing.Size(192, 20);
            this.txtSongTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Song Title:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.label1, "The title of the song as it should appear in-game");
            // 
            // listCharts
            // 
            this.listCharts.FormattingEnabled = true;
            this.listCharts.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.listCharts.Location = new System.Drawing.Point(6, 19);
            this.listCharts.Name = "listCharts";
            this.listCharts.Size = new System.Drawing.Size(105, 95);
            this.listCharts.TabIndex = 2;
            this.listCharts.SelectedIndexChanged += new System.EventHandler(this.listCharts_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(141, 338);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Export .r4k";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Name:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtChartName
            // 
            this.txtChartName.Location = new System.Drawing.Point(124, 34);
            this.txtChartName.Name = "txtChartName";
            this.txtChartName.Size = new System.Drawing.Size(100, 20);
            this.txtChartName.TabIndex = 6;
            this.txtChartName.TextChanged += new System.EventHandler(this.txtChartName_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(124, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Chart Creator:";
            // 
            // txtChartCreator
            // 
            this.txtChartCreator.Location = new System.Drawing.Point(124, 78);
            this.txtChartCreator.Name = "txtChartCreator";
            this.txtChartCreator.Size = new System.Drawing.Size(225, 20);
            this.txtChartCreator.TabIndex = 6;
            this.txtChartCreator.TextChanged += new System.EventHandler(this.txtChartCreator_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(235, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Difficulty:";
            this.label11.Click += new System.EventHandler(this.label9_Click);
            // 
            // numDifficulty
            // 
            this.numDifficulty.Location = new System.Drawing.Point(234, 35);
            this.numDifficulty.Name = "numDifficulty";
            this.numDifficulty.Size = new System.Drawing.Size(115, 20);
            this.numDifficulty.TabIndex = 7;
            this.numDifficulty.ValueChanged += new System.EventHandler(this.numDifficulty_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblChartInfo);
            this.groupBox1.Controls.Add(this.listCharts);
            this.groupBox1.Controls.Add(this.numDifficulty);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtChartCreator);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtChartName);
            this.groupBox1.Location = new System.Drawing.Point(0, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 129);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loaded Charts/Difficulties";
            // 
            // lblChartInfo
            // 
            this.lblChartInfo.Location = new System.Drawing.Point(124, 105);
            this.lblChartInfo.Name = "lblChartInfo";
            this.lblChartInfo.Size = new System.Drawing.Size(225, 18);
            this.lblChartInfo.TabIndex = 8;
            this.lblChartInfo.Text = "123 Notes | 0 BPM Changes";
            this.lblChartInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 381);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.lblDragToStart);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 420);
            this.MinimumSize = new System.Drawing.Size(400, 420);
            this.Name = "Form1";
            this.Text = "Rhythm4K Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDifficulty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDragToStart;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.TextBox txtSongTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMainBPM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtSampleLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSampleStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSongOffset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSongFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSongArtist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listCharts;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtChartCreator;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtChartName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numDifficulty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblChartInfo;
    }
}

