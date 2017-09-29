using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGameEU.Objects
{
    public class StaticObjects
    {
        public StaticObjects()
        {
            this.DrawRoad();
        }

        public void DrawRoad()
        {
            var roadYPos = Console.WindowHeight - 5;
            var road = "";

            //char[][] buffer = new char[roadYPos][];

            for(int i = 0; i < Console.WindowWidth; i = i + 6)
            {
                road = road + "******";
            }

            Console.SetCursorPosition(0, roadYPos);
            Console.Write(road);
        }
    }
}
