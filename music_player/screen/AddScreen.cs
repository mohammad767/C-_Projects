using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music_player.screen
{
    internal class AddScreen : BaseScreen
    {
        protected override void initUI()
        {
            var music = new Music();
            var addtrack = new Addtrak();
            addtrack.NameCheck(music);
            addtrack.ArtistCheck(music);
            addtrack.DurationCheck(music);
            addtrack.DateCheck(music);
            music.AddTrak();
            //Console.Clear();
            Console.WriteLine("Add Done(:");
            Navigeator.Back();
        }
        
    }
}
