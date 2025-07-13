using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music_player
{
    public class Addtrak
    {

        public void NameCheck(Music newmusic)
        {
            var input = new GetInput();
            newmusic.Name = input.Getinput("Enter name: ");
            if (newmusic.Name == null)
            {
                Console.WriteLine("invalid name");
                NameCheck(newmusic);
            }
        }

        public void ArtistCheck(Music newmusic)
        {
            var input = new GetInput();
            newmusic.Artist = input.Getinput("Enter artist name : ");
            if (newmusic.Artist == null)
            {
                Console.WriteLine("Invalid input");
                ArtistCheck(newmusic);
            }
        }

        public void DurationCheck(Music newmusic)
        {
            var input = new GetInput();
            newmusic.Duration = input.Getinput("Enter music time : ");
            if (newmusic.Duration == null)
            {
                Console.WriteLine("Invalid input");
                DurationCheck(newmusic);
            }
        }

        public void DateCheck(Music newmusic)
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
