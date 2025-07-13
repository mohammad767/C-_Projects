using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music_player.screen
{
    abstract public class BaseScreen
    {
        public void show()
        {
            Console.Clear();
            Navigeator.Add(this);

            initUI();
        }
        abstract protected void initUI();
    }
}
