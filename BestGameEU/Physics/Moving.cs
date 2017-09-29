using BestGameEU.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGameEU.Physics
{
    public class Moving
    {
        int x = Console.CursorLeft, y = Console.WindowHeight - 11;
        ObjectHelper objectHelper;
        const string char1 = "  *  ";
        const string char2 = "*****";
        const string char3 = "  *  ";
        const string char4 = "  *  ";
        const string char5 = " * * ";
        const string char6 = " * * ";

        public Moving()
        {
            objectHelper = new ObjectHelper();
        }

        public void MoveTo(ConsoleKey key)
        {
            objectHelper.ClearPlayground();

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
                x = 0;
            else if (y < 0)
                y = 0;

            Console.SetCursorPosition(x, y);
            Console.WriteLine(char1);
            y++;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(char2);
            y++;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(char3);
            y++;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(char4);
            y++;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(char5);
            y++;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(char6);
            y = y - 5;
        }
    }
}
