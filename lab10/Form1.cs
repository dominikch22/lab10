using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        private int timeMilliseconds;
        private Lyrics CurrentLyrics;
        private string CurrentAudio;
        private System.Windows.Forms.Timer timer;
        private CancellationTokenSource cts;
        private Lyrics SelectedLyrics;
        private string htmlLyrics;
        public Form1()
        {
            InitializeComponent();
            audioList.Items.Add("Silent Night");
            audioList.Items.Add("We wish you a merry christmas");
            audioList.Items.Add("Wśród nocnej ciszy");

            cts = new CancellationTokenSource();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += TimerTick;
            timeMilliseconds = 0;
            timer.Start();

            CurrentLyrics = null;
            htmlLyrics = "";
        }


        private void playSound_Click(object sender, EventArgs e)
        {
            try
            {
                cts.Cancel();
                cts = new CancellationTokenSource();

                CurrentLyrics = SelectedLyrics;
                Task myTask = Task.Run(() => PlaySoundAsync(CurrentAudio, cts.Token));
            
                timeMilliseconds = 0;

            }
            catch { 
            }
       

           
        }

        private void TimerTick(object sender, EventArgs e) {
            if (CurrentLyrics != null) {
                timeMilliseconds += 1010;

                htmlLyrics = "";
                if (fullText.Checked)
                {
                    for (int i = 0; i < CurrentLyrics.Lines.Count; i++) {
                        if (CurrentLyrics.Timestamps[i].isBetween(timeMilliseconds))
                        {
                            htmlLyrics += "<b>";
                            htmlLyrics += CurrentLyrics.Lines[i].Replace("\r\n", "</br>");
                            htmlLyrics += "</b>";
                            htmlLyrics += "</br>";
                        }
                        else {
                            htmlLyrics += CurrentLyrics.Lines[i].Replace("\r\n", "</br>");
                            htmlLyrics += "</br>";
                        }
                    }                 
                }
                else {
                    htmlLyrics = CurrentLyrics.getCurrentLine(timeMilliseconds).Replace("\r\n", "</br>");
                }
                browserLyrics.DocumentText = htmlLyrics;
            }       
        }

        static async Task PlaySoundAsync(string path, CancellationToken cancellationToken)
        {
            try
            {
                using (Stream stream = MusicsList.getAudioByTitle(path)) {
                    using (var mp3FileReader = new Mp3FileReader(stream))
                    {
                        using (var waveOut = new WaveOutEvent())
                        {
                            waveOut.Init(mp3FileReader);

                            waveOut.Play();

                            while (waveOut.PlaybackState == PlaybackState.Playing)
                            {
                                cancellationToken.ThrowIfCancellationRequested();
                                await Task.Delay(100);
                            }

                        }
                    }
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentAudio = audioList.SelectedItem.ToString();
            SelectedLyrics = MusicsList.getLyricsByTitle(CurrentAudio);         
        }

        private void selectAudio_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedAudioPath = openFileDialog.FileName;

                audioPath.Text = selectedAudioPath;
            }
        }

        private void selectLyrics_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedLyricsPath = openFileDialog.FileName;
                lyricsPath.Text = selectedLyricsPath;

                SelectedLyrics = MusicsList.getLyricsByTitle(selectedLyricsPath);       
            }
        }

        private void fullText_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
