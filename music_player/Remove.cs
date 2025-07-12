using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music_player
{
    public class Remove
    {
        public void remove(string id)
        {
            var musiclist = Music.musiclist;
            var result = Music.musiclist
                .Where(x => x.Id.ToLower().Equals(id.ToLower(), StringComparison.OrdinalIgnoreCase)).ToList();
            Console.WriteLine("Selected music : ");
            Console.WriteLine($"{"ID",-10} {"Music",-10} {"Artist",-10} {"Duration",-10},{"Date",-10}");
            foreach (Music music in result)
            {
                Console.WriteLine(
                    $"{music.Id} {music.Name,-10} {music.Artist,-10} {music.Duration,-10} {music.Publishdate,-10}");
                Console.WriteLine(new string('-', 40));
            }
            Console.WriteLine(new string('-', 40));
            Console.Write("Do you confirm it(Y/N) : ");
            var choice = Console.ReadLine()!.ToLower();
            if (choice == "y")
            {
                if (result.Count == 0)
                {
                    Console.WriteLine("Nothong Found");
                    return;
                }

                var music = result[0];

                var ind = musiclist.IndexOf(music);

                Console.WriteLine("Item removed");
                musiclist.Remove(music);

                for (int i = ind; i < musiclist.Count; i++)
                {
                    musiclist[i].Id = (i + 1).ToString();
                }
                return;
            }
            else if (choice == "n")
            {
                Console.WriteLine("Remove canceld");
                return;
            }
        }
    }
}
