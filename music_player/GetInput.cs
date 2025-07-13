using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music_player
{
    class GetInput
    {
        public string Getinput(string meesseg)
        {
            Console.Write(meesseg);
            return Console.ReadLine()!;
        }

        public int GetIntInput(string meesseg)
        {
            return Convert.ToInt32(Getinput(meesseg));
        }
    }
}