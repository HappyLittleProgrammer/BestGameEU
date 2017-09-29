using BestGameEU.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGameEU.Helpers
{
    public class ObjectHelper
    {
        public void ClearPlayground()
        {
            var staticObjects = new StaticObjects();

            Console.Clear();

            staticObjects.DrawRoad();
        }
    }
}
