using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGameEU.Physics
{
    public class Moving
    {
        int x, y;
        const string character = "*";
        public void MoveTo(ConsoleKey key)
        {
            x = Console.CursorLeft - 2;
            y = Console.CursorTop - 2;
            //Console.Clear();
            if (x >= 0 || y >= 0)
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (y > 0)
                            y--;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (x > 0)
                            x--;
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                    default:
                        break;
                }
            else if (x < 0)
                Console.CursorLeft = 0;
            else if (y < 0)
                Console.CursorTop = 0;

            Console.SetCursorPosition(x, y);
            Console.Write(character);
        }
    }
}
