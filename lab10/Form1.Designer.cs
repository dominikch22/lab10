
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
            this.lyricsLabel = new System.Windows.Forms.Label();
            this.playSound = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lyricsLabel
            // 
            this.lyricsLabel.AutoSize = true;
            this.lyricsLabel.Location = new System.Drawing.Point(314, 208);
            this.lyricsLabel.Name = "lyricsLabel";
            this.lyricsLabel.Size = new System.Drawing.Size(18, 13);
            this.lyricsLabel.TabIndex = 0;
            this.lyricsLabel.Text = "ds";
            // 
            // playSound
            // 
            this.playSound.Location = new System.Drawing.Point(457, 236);
            this.playSound.Name = "playSound";
            this.playSound.Size = new System.Drawing.Size(75, 23);
            this.playSound.TabIndex = 1;
            this.playSound.Text = "play";
            this.playSound.UseVisualStyleBackColor = true;
            this.playSound.Click += new System.EventHandler(this.playSound_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playSound);
            this.Controls.Add(this.lyricsLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lyricsLabel;
        private System.Windows.Forms.Button playSound;
    }
}

