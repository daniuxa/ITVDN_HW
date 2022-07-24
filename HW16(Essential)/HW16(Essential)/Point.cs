using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW16_Essential_
{
    internal struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point operator +(Point a, Point b)
        {
            return new Point() { X = a.X + b.X, Y = a.Y + b.Y, Z = a.Z + b.Z };
        }

        public override string ToString()
        {
            return X + " " + Y + " " + Z;
        }
    }
}
