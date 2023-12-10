using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class MusicsList
    {
        public static Stream getAudioByTitle(string title) {


            if (title.Equals("Silent Night"))
            {

                byte[] bytes = Properties.Resources.silent_night_audio;
                return new MemoryStream(bytes);

            }
            else if (title.Equals("We wish you a merry christmas"))
            {
                byte[] bytes = Properties.Resources.We_Wish_You_a_Merry_Christmas__Instrumental___TubeRipper_com_;
                return new MemoryStream(bytes);

            }
            else if (title.Equals("Wśród nocnej ciszy"))
            {
                byte[] bytes = Properties.Resources.Wśród_Nocnej_Ciszy___karaoke__TubeRipper_com_;
                return new MemoryStream(bytes);

            }

            return new FileStream(title, FileMode.Open, FileAccess.Read);

        }

        public static Lyrics getLyricsByTitle(string title) {
            if (title.Equals("Silent Night"))
            {

                string lyrics = System.Text.Encoding.UTF8.GetString(Properties.Resources._English__Silent_Night_with_Lyrics_Christmas_Carol__DownSub_com_); ;

                return Lyrics.readFromSrt(lyrics);

            }
            else if (title.Equals("We wish you a merry christmas"))
            {
                string lyrics = System.Text.Encoding.UTF8.GetString(Properties.Resources._English__We_Wish_You_a_Merry_Christmas_with_Lyrics_Christmas_Carol___Song__DownSub_com_); ;

                return Lyrics.readFromSrt(lyrics);
            }
            else if (title.Equals("Wśród nocnej ciszy"))
            {
                string lyrics = System.Text.Encoding.UTF8.GetString(Properties.Resources.nocenj_ciszy); ;

                return Lyrics.readFromSrt(lyrics);
            }

            using (FileStream fileStream = new FileStream(title, FileMode.Open, FileAccess.Read))
            {         
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    string srtLyrics = reader.ReadToEnd();
                    return Lyrics.readFromSrt(srtLyrics);
                }
            }

        }
    }
}
