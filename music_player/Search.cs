using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music_player
{
    public class Search
    {
        public void search(string item)
        {
            var result = Music.musiclist.Where(x =>
                x.Name.ToLower().Contains(item.ToLower(), StringComparison.OrdinalIgnoreCase)
                || x.Artist.ToLower().Contains(item.ToLower(), StringComparison.OrdinalIgnoreCase)).ToList();
            Console.WriteLine("Search Result : ");
            Console.WriteLine($"{"ID",-10} {"Music",-10} {"Artist",-10} {"Duration",-10},{"Date",-10}");
            Console.WriteLine(new string('-', 40));
            if (result.Count == 0)
            {
                Console.WriteLine("Nothong Found");
                return;
            }

            foreach (Music music in result)
            {
                Console.WriteLine(
                    $"{music.Id} {music.Name,-10} {music.Artist,-10} {music.Duration,-10} {music.Publishdate,-10}");
                Console.WriteLine(new string('-', 40));
            }

            Console.WriteLine(new string('-', 40));
        }

        public void Artistsearch(string item)
        {
            var result = Music.musiclist
                .Where(x => x.Artist.ToLower().Contains(item.ToLower(), StringComparison.OrdinalIgnoreCase)).ToList();
            Console.WriteLine("Search Result : ");
            Console.WriteLine($"{"ID",-10} {"Music",-10} {"Artist",-10} {"Duration",-10},{"Date",-10}");
            Console.WriteLine(new string('-', 40));
            if (result.Count == 0)
            {
                Console.WriteLine("Nothong Found");
                return;
            }

            foreach (Music music in result)
            {
                Console.WriteLine(
                    $"{music.Id} {music.Name,-10} {music.Artist,-10} {music.Duration,-10} {music.Publishdate,-10}");
                Console.WriteLine(new string('-', 40));
            }

            Console.WriteLine(new string('-', 40));
        }

        public void Namesearch(string item)
        {
            var result = Music.musiclist
                .Where(x => x.Name.ToLower().Contains(item.ToLower(), StringComparison.OrdinalIgnoreCase)).ToList();
            Console.WriteLine("Search Result : ");
            Console.WriteLine($"{"ID",-10} {"Music",-10} {"Artist",-10} {"Duration",-10},{"Date",-10}");
            Console.WriteLine(new string('-', 40));
            if (result.Count == 0)
            {
                Console.WriteLine("Nothong Found");
                return;
            }

            foreach (Music music in result)
            {
                Console.WriteLine(
                    $"{music.Id} {music.Name,-10} {music.Artist,-10} {music.Duration,-10} {music.Publishdate,-10}");
                Console.WriteLine(new string('-', 40));
            }

            Console.WriteLine(new string('-', 40));
        }

        public List<Music> IdsearchE(string item)
        {
            var result = Music.musiclist
                .Where(x => x.Id.ToLower().Equals(item.ToLower(), StringComparison.OrdinalIgnoreCase)).ToList();
            Console.WriteLine("Search Result : ");
            Console.WriteLine($"{"ID",-10} {"Music",-10} {"Artist",-10} {"Duration",-10},{"Date",-10}");
            foreach (Music music in result)
            {
                Console.WriteLine(
                    $"{music.Id} {music.Name,-10} {music.Artist,-10} {music.Duration,-10} {music.Publishdate,-10}");
                Console.WriteLine(new string('-', 40));
            }
            if (result.Count == 0)
            {
                Console.WriteLine("Nothong Found");
                return null;
            }

            return result;
        }
    }
}
