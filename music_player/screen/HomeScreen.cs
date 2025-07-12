using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music_player.screen
{
    internal class HomeScreen : BaseScreen
    {
        protected override void initUI()
        {
            Console.WriteLine("1 --> Add music");
            Console.WriteLine("2 --> Search music");
            Console.WriteLine("3 --> Edit music");
            Console.WriteLine("4 --> Delete music");
            Console.WriteLine($"{"ID",-5} {"Music",-15} {"Artist",-15} {"Duration",-10} {"Date",-12}");
            Music.Show_music();
            var text = new GetInput();
            var input = text.Getinput("Enter your choice : ");

            switch (input)
            {
                case "1":
                    var screen = new AddScreen();
                    screen.show();
                    break;
                case "2":
                    var search = new SearchScreen();
                    search.show();
                    break;
                case "3":
                    var edit = new EditScreen();
                    edit.show();
                    break;
                case "4":
                    var remove = new RemoveScreen();
                    remove.show();
                    break;
                default:
                    Console.WriteLine("Wrong");
                    Thread.Sleep(30000);
                    Console.Clear();
                    break;
            }
        }
    }
}
