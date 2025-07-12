using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using music_player.screen;

namespace music_player
{
    static class Navigeator
    {
        private static Stack<BaseScreen> stack = new Stack<BaseScreen>();

        public static void Add(BaseScreen screen)
        {
            stack.Push(screen);
        }
        public static void Back()
        {
            stack.Pop();
            stack.Peek().show();
        }

    }
}
