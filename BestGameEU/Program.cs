using BestGameEU.Physics;
using BestGameEU.Objects;
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

            var staticObjects = new StaticObjects();

            var moving = new Moving();
            
            while(true)
            {
                var pressedKey = Console.ReadKey(false).Key;

                moving.MoveTo(pressedKey);
            }
        }
    }
}
