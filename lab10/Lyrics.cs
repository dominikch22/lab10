using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab10
{
    class Lyrics
    {
        public List<Timestamp> timestamps;
        public List<String> Lines;

        public static Lyrics readFromSrt(String srtText) {
            Lyrics lyrics = new Lyrics();
            using (StringReader reader = new StringReader(srtText))
            {
                string line;

                try
                {
                    while (true)
                    {
                        line = reader.ReadLine();
                        string pattern = @"(\d+:\d+:\d+,\d+) --> (\d+:\d+:\d+,\d+)";
                        line = reader.ReadLine();
                        Match match = Regex.Match(line, pattern);


                        TimeSpan starttimeSpan = TimeSpan.ParseExact(match.Groups[1].Value, "hh\\:mm\\:ss\\,fff", null);
                        TimeSpan endtimeSpan = TimeSpan.ParseExact(match.Groups[2].Value, "hh\\:mm\\:ss\\,fff", null);

                        long startmilliseconds = (long)starttimeSpan.TotalMilliseconds;
                        long endmilliseconds = (long)endtimeSpan.TotalMilliseconds;
                        Timestamp timestamp = new Timestamp();
                        timestamp.startMillseconds = startmilliseconds;
                        timestamp.endMilliseocnds = endmilliseconds;

                        lyrics.Lines.Add(reader.ReadLine());
                        lyrics.timestamps.Add(timestamp);

                        line = reader.ReadLine();
                    }
                }
                catch { 
                
                }
               

                 
            }

            return lyrics;
        }



        public String getCurrentLine(int milliseconds) {
            for (int i = 0; i < timestamps.Count; i++) {
                if (timestamps[i].isBetween(milliseconds)) {
                    return Lines[i];
                }
            }
            return "";
            
        }
    }
}
