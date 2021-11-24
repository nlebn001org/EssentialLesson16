using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson16Task3
{
    class House : ICloneable
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public Door houseDoor;

        public House(string color, int year, Door door)
        {
            this. Color = color;
            this.Year = year;
            this.houseDoor = door;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public House DeepClone()
        {
            Door clonedDoor = new Door(houseDoor.Name, houseDoor.Color);
            return new House(Color, Year, clonedDoor);
        }

        public override string ToString()
        {
            return $"House color {Color}, House Year {Year}, Door color {houseDoor.Color}, Door Name {houseDoor.Name}.";
        }
    }
}



