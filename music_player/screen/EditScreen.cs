using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music_player.screen
{
    internal class EditScreen : BaseScreen
    {
        protected override void initUI()
        {
            var edit = new Edit();
            edit.editmusic();
            Navigeator.Back();
        }
    }
}
