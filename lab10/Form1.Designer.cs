
namespace lab10
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
            this.playSound = new System.Windows.Forms.Button();
            this.audioList = new System.Windows.Forms.ListBox();
            this.selectAudio = new System.Windows.Forms.Button();
            this.selectLyrics = new System.Windows.Forms.Button();
            this.audioPath = new System.Windows.Forms.Label();
            this.lyricsPath = new System.Windows.Forms.Label();
            this.fullText = new System.Windows.Forms.CheckBox();
            this.browserLyrics = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // playSound
            // 
            this.playSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.playSound.Location = new System.Drawing.Point(879, 547);
            this.playSound.Name = "playSound";
            this.playSound.Size = new System.Drawing.Size(194, 32);
            this.playSound.TabIndex = 1;
            this.playSound.Text = "play";
            this.playSound.UseVisualStyleBackColor = true;
            this.playSound.Click += new System.EventHandler(this.playSound_Click);
            // 
            // audioList
            // 
            this.audioList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.audioList.FormattingEnabled = true;
            this.audioList.Location = new System.Drawing.Point(2, 0);
            this.audioList.Name = "audioList";
            this.audioList.Size = new System.Drawing.Size(181, 550);
            this.audioList.TabIndex = 2;
            this.audioList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // selectAudio
            // 
            this.selectAudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectAudio.Location = new System.Drawing.Point(2, 562);
            this.selectAudio.Name = "selectAudio";
            this.selectAudio.Size = new System.Drawing.Size(87, 23);
            this.selectAudio.TabIndex = 4;
            this.selectAudio.Text = "select audio";
            this.selectAudio.UseVisualStyleBackColor = true;
            this.selectAudio.Click += new System.EventHandler(this.selectAudio_Click);
            // 
            // selectLyrics
            // 
            this.selectLyrics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectLyrics.Location = new System.Drawing.Point(95, 562);
            this.selectLyrics.Name = "selectLyrics";
            this.selectLyrics.Size = new System.Drawing.Size(88, 23);
            this.selectLyrics.TabIndex = 5;
            this.selectLyrics.Text = "select lyrics";
            this.selectLyrics.UseVisualStyleBackColor = true;
            this.selectLyrics.Click += new System.EventHandler(this.selectLyrics_Click);
            // 
            // audioPath
            // 
            this.audioPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.audioPath.AutoSize = true;
            this.audioPath.Location = new System.Drawing.Point(190, 543);
            this.audioPath.Name = "audioPath";
            this.audioPath.Size = new System.Drawing.Size(0, 13);
            this.audioPath.TabIndex = 6;
            // 
            // lyricsPath
            // 
            this.lyricsPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lyricsPath.AutoSize = true;
            this.lyricsPath.Location = new System.Drawing.Point(189, 562);
            this.lyricsPath.Name = "lyricsPath";
            this.lyricsPath.Size = new System.Drawing.Size(0, 13);
            this.lyricsPath.TabIndex = 7;
            // 
            // fullText
            // 
            this.fullText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fullText.AutoSize = true;
            this.fullText.Location = new System.Drawing.Point(787, 556);
            this.fullText.Name = "fullText";
            this.fullText.Size = new System.Drawing.Size(73, 17);
            this.fullText.TabIndex = 8;
            this.fullText.Text = "cały tekst";
            this.fullText.UseVisualStyleBackColor = true;
            this.fullText.CheckedChanged += new System.EventHandler(this.fullText_CheckedChanged);
            // 
            // browserLyrics
            // 
            this.browserLyrics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browserLyrics.Location = new System.Drawing.Point(189, 0);
            this.browserLyrics.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserLyrics.Name = "browserLyrics";
            this.browserLyrics.Size = new System.Drawing.Size(884, 528);
            this.browserLyrics.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 594);
            this.Controls.Add(this.browserLyrics);
            this.Controls.Add(this.fullText);
            this.Controls.Add(this.lyricsPath);
            this.Controls.Add(this.audioPath);
            this.Controls.Add(this.selectLyrics);
            this.Controls.Add(this.selectAudio);
            this.Controls.Add(this.audioList);
            this.Controls.Add(this.playSound);
            this.Name = "Form1";
            this.Text = "The Ultimate Interactive Karaoke Experience Platform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button playSound;
        private System.Windows.Forms.ListBox audioList;
        private System.Windows.Forms.Button selectAudio;
        private System.Windows.Forms.Button selectLyrics;
        private System.Windows.Forms.Label audioPath;
        private System.Windows.Forms.Label lyricsPath;
        private System.Windows.Forms.CheckBox fullText;
        private System.Windows.Forms.WebBrowser browserLyrics;
    }
}

