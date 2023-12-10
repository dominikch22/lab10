using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        private int timeMilliseconds = 0;
        private Lyrics CurrentLyrics;
        public Form1()
        {
            InitializeComponent();
        }

        private void playSound_Click(object sender, EventArgs e)
        {
            Stream stream = Properties.Resources.Silent_Night___Instrumental_with_Lyrics__no_vocals_;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(stream);
            player.Play();
            String lyrics = Properties.Resources._English__Silent_Night_with_Lyrics_Christmas_Carol__DownSub_com_;

            CurrentLyrics = Lyrics.readFromSrt(lyrics);

            Timer timer = new Timer();
            timer.Interval = 100;

            timer.Tick += TimerTick;

            // Start the timer
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e) {
            timeMilliseconds += 100;
            lyricsLabel.Text = CurrentLyrics.getCurrentLine(timeMilliseconds);

        }
    }
}
