
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
            this.lyricsLabel = new System.Windows.Forms.TextBox();
            this.selectAudio = new System.Windows.Forms.Button();
            this.selectLyrics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playSound
            // 
            this.playSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playSound.Location = new System.Drawing.Point(575, 543);
            this.playSound.Name = "playSound";
            this.playSound.Size = new System.Drawing.Size(194, 32);
            this.playSound.TabIndex = 1;
            this.playSound.Text = "play";
            this.playSound.UseVisualStyleBackColor = true;
            this.playSound.Click += new System.EventHandler(this.playSound_Click);
            // 
            // audioList
            // 
            this.audioList.FormattingEnabled = true;
            this.audioList.Location = new System.Drawing.Point(2, 0);
            this.audioList.Name = "audioList";
            this.audioList.Size = new System.Drawing.Size(181, 537);
            this.audioList.TabIndex = 2;
            this.audioList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lyricsLabel
            // 
            this.lyricsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lyricsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lyricsLabel.Location = new System.Drawing.Point(189, 0);
            this.lyricsLabel.Multiline = true;
            this.lyricsLabel.Name = "lyricsLabel";
            this.lyricsLabel.Size = new System.Drawing.Size(580, 538);
            this.lyricsLabel.TabIndex = 3;
            // 
            // selectAudio
            // 
            this.selectAudio.Location = new System.Drawing.Point(2, 543);
            this.selectAudio.Name = "selectAudio";
            this.selectAudio.Size = new System.Drawing.Size(87, 23);
            this.selectAudio.TabIndex = 4;
            this.selectAudio.Text = "select audio";
            this.selectAudio.UseVisualStyleBackColor = true;
            // 
            // selectLyrics
            // 
            this.selectLyrics.Location = new System.Drawing.Point(95, 543);
            this.selectLyrics.Name = "selectLyrics";
            this.selectLyrics.Size = new System.Drawing.Size(88, 23);
            this.selectLyrics.TabIndex = 5;
            this.selectLyrics.Text = "select lyrics";
            this.selectLyrics.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 584);
            this.Controls.Add(this.selectLyrics);
            this.Controls.Add(this.selectAudio);
            this.Controls.Add(this.lyricsLabel);
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
        private System.Windows.Forms.TextBox lyricsLabel;
        private System.Windows.Forms.Button selectAudio;
        private System.Windows.Forms.Button selectLyrics;
    }
}

