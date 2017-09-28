using BestGameEU.Physics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGameEU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            var moving = new Moving();
            
            while(true)
            {
                var pressedKey = Console.ReadKey(false).Key;

                moving.MoveTo(pressedKey);
            }
        }
    }
}
