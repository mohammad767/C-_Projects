using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace music_player.screen
{
    internal class RemoveScreen : BaseScreen
    {
        protected override void initUI()
        {
            var remove = new Remove();
            var text = new GetInput();
            var id = text.Getinput("Enter the music id : ");
            remove.remove(id);
            Navigeator.Back();
        }
    }
}
