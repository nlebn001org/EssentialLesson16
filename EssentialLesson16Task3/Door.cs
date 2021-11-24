using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson16Task3
{
    class Door
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Door(string name, string color)
        {
            Name = name;
            Color = color;
        }
    }
}
