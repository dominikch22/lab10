using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        private int timeMilliseconds = 0;
        private Lyrics CurrentLyrics;
        private Stream CurrentAudio;
        public Form1()
        {
            InitializeComponent();
            audioList.Items.Add("Silent Night");
            audioList.Items.Add("We wish you a merry christmas");
            audioList.Items.Add("Wśród nocnej ciszy");

        }


        private void playSound_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Run(() => PlaySoundAsync(CurrentAudio));

                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 100;
                timeMilliseconds = 0;


                timer.Tick += TimerTick;

                timer.Start();
            }
            catch { 
            }
       

           
        }

        private void TimerTick(object sender, EventArgs e) {
            timeMilliseconds += 110;
            lyricsLabel.Text = CurrentLyrics.getCurrentLine(timeMilliseconds);

        }

        static async Task PlaySoundAsync(Stream stream)
        {

            try
            {
                // Create an MP3 file reader
                using (var mp3FileReader = new Mp3FileReader(stream))
                {
                    // Create a WaveOutEvent for playback
                    using (var waveOut = new WaveOutEvent())
                    {
                        // Set the MP3 file reader as the source
                        waveOut.Init(mp3FileReader);

                        // Start playback asynchronously
                        waveOut.Play();

                        // Wait for the audio to finish playing (optional)
                        while (waveOut.PlaybackState == PlaybackState.Playing)
                        {
                            await Task.Delay(100); // Adjust the delay as needed
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally {
                //stream.Dispose();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (audioList.SelectedItem.ToString().Equals("Silent Night"))
            {
                byte[] bytes = Properties.Resources.silent_night_audio;
                MemoryStream memoryStream = new MemoryStream(bytes);
                CurrentAudio = memoryStream;

                string lyrics = System.Text.Encoding.UTF8.GetString(Properties.Resources._English__Silent_Night_with_Lyrics_Christmas_Carol__DownSub_com_); ;

                CurrentLyrics = Lyrics.readFromSrt(lyrics);
            }
            else if (audioList.SelectedItem.ToString().Equals("We wish you a merry christmas"))
            {
                byte[] bytes = Properties.Resources.We_Wish_You_a_Merry_Christmas__Instrumental___TubeRipper_com_;
                MemoryStream memoryStream = new MemoryStream(bytes);
                CurrentAudio = memoryStream;

                string lyrics = System.Text.Encoding.UTF8.GetString(Properties.Resources._English__We_Wish_You_a_Merry_Christmas_with_Lyrics_Christmas_Carol___Song__DownSub_com_); ;

                CurrentLyrics = Lyrics.readFromSrt(lyrics);
            }
            else if (audioList.SelectedItem.ToString().Equals("Wśród nocnej ciszy"))
            {
                byte[] bytes = Properties.Resources.Wśród_Nocnej_Ciszy___karaoke__TubeRipper_com_;
                MemoryStream memoryStream = new MemoryStream(bytes);
                CurrentAudio = memoryStream;

                string lyrics = System.Text.Encoding.UTF8.GetString(Properties.Resources.nocenj_ciszy); ;

                CurrentLyrics = Lyrics.readFromSrt(lyrics);
            }
        }
    }
}
