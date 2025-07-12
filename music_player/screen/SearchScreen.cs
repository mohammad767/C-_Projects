using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music_player.screen
{
    internal class SearchScreen : BaseScreen
    {
        protected override void initUI()
        {
            var text = new GetInput();
            var search = new Search();
            var choice = text.Getinput("Do you want have a filterd search(Y/N) : ");
            switch (choice.ToLower())
            {
                case "y":
                    Console.WriteLine("1 --> Name");
                    Console.WriteLine("2 --> artist");
                    var choice2 = text.Getinput("Enter your choice : ");
                    switch (choice2)
                    {
                        case "1":
                            var artist = text.Getinput("Enter artist name : ");
                            search.Artistsearch(artist);
                            Thread.Sleep(10000);
                            break;
                        case "2":
                            var name = text.Getinput("Enter the music name : ");
                            search.Namesearch(name);
                            Thread.Sleep(10000);
                            break;
                    }

                    break;
                case "n":
                    var item = text.Getinput("Enter your search : ");
                    search.search(item);
                    Thread.Sleep(10000);
                    break;
            }
            Navigeator.Back();

        }
        
        
       

        
    }
}
