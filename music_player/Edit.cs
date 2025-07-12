using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using music_player.screen;

namespace music_player
{
    public class Edit
    {

        public void editmusic()
        {
            var text = new GetInput();
            var search = new Search();
            string id = text.Getinput("Enter the music id");
            var music = search.IdsearchE(id);
            var item = music[0];
            Console.WriteLine("1 --> name");
            Console.WriteLine("2 --> artist");
            Console.WriteLine("3 --> Publish date");
            var input = text.Getinput("Enter the field to edit :  ");
            switch (input)
            {
                case "1":
                    NameCheck(item);
                    break;
                case "2":
                    ArtistCheck(item);
                    break;
                case "3":
                    DateCheck(item);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    return;
            }
        }
        private void NameCheck(Music newmusic)
        {
            var input = new GetInput();
            newmusic.Name = input.Getinput("Enter name: ");
            if (newmusic.Name == null)
            {
                Console.WriteLine("invalid name");
                NameCheck(newmusic);
            }
        }

        private void ArtistCheck(Music newmusic)
        {
            var input = new GetInput();
            newmusic.Artist = input.Getinput("Enter artist name : ");
            if (newmusic.Artist == null)
            {
                Console.WriteLine("Invalid input");
                ArtistCheck(newmusic);
            }
        }

        private void DurationCheck(Music newmusic)
        {
            var input = new GetInput();
            newmusic.Duration = input.Getinput("Enter music time : ");
            if (newmusic.Duration == null)
            {
                Console.WriteLine("Invalid input");
                DurationCheck(newmusic);
            }
        }

        private void DateCheck(Music newmusic)
        {
            var input = new GetInput();
            int year = input.GetIntInput("Enter the publish year : ");
            while (year < 1900 || year > Convert.ToInt32(DateTime.Now.Year))
            {
                Console.WriteLine("Out of range!!");
                year = input.GetIntInput("Enter the year again : ");
            }

            newmusic.Publishdate = year;
        }
    }
}
