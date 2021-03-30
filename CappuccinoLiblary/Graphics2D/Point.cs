using System;
using System.Collections.Generic;
using System.Text;

namespace Cappuccino.Graphics2D
{
    public struct Point : IComparable
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double Vertical {
            get => Y;
            set => Y = value;
        }

        public double Horizontal {
            get => X;
            set => X = value;
        }

        public Point(double x, double y) {
            X = x;
            Y = y;
        }


        public int CompareTo(object? obj) { throw new NotImplementedException(); }

        public static Point operator +(Point left, Point right) {
            
        }


    }
}
