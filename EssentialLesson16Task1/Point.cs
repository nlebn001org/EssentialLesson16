﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson16Task1
{
    struct Point
    {

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }

        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }


        public static Point operator +( Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y+p2.Y, p1.Z+p2.Z);
        }

        public override string ToString()
        {
            return $"X = {X}, Y = {Y}, Z = {Z}";
        }
    }
}
