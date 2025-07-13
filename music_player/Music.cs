using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace music_player
{
    public class Music
    {
        private string name;
        private string artist;
        private string duration;
        private int publishdate;
        private string id;

        public static IList<Music> musiclist = new List<Music>()
        {
            new Music { Id = "1", Name = "Safar", Artist = "Moein", Duration = "3:20", Publishdate = 1985 },
            new Music { Id = "2", Name = "Fosh", Artist = "Quf", Duration = "4:14", Publishdate = 2013 }
        };

        public Music()
        {
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length <= 2)
                {
                    name = null;
                }
                else
                {
                    name = value;
                }
            }
        }

        public string Artist
        {
            get { return artist; }
            set
            {
                if (value.Length <= 2)
                {
                    artist = null;
                }
                else
                {
                    artist = value;
                }
            }
        }

        public string Duration
        {
            get { return duration; }
            set
            {
                string pattern = @"^\d{1,2}:\d{2}$";
                if (!Regex.IsMatch(value, pattern))
                {
                    duration = null;
                }
                else
                {
                    duration = value;
                }
            }
        }

        public int Publishdate
        {
            get => publishdate;
            set => publishdate = value;
        }

        public void AddTrak()
        {
            if (musiclist.Contains(this))
            {
                Console.WriteLine("This music already exists!");
                return;
            }

            this.id = (musiclist.Count + 1).ToString();
            musiclist.Add(this);
        }

        public static void Show_music()
        {
            Console.WriteLine(new string('-', 40));

            foreach (Music music in musiclist)
            {
                Console.WriteLine(
                    $"{music.Id,-5} {music.Name,-15} {music.Artist,-15} {music.Duration,-10} {music.Publishdate,-12}");
                Console.WriteLine("\n");
                Console.WriteLine(new string('-', 40));
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}