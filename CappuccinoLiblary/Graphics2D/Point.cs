using System;
using System.Collections.Generic;
using System.Text;
using RUtil;

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

        public bool WithinRange(Point p, double range) {
            return Utility.Distance(X, Y, p.X, p.Y) <= range;
        }

        public int CompareTo(object obj) {
            if (obj == null) {
                return 1;
            }
            
            if (GetType() != obj.GetType()) {
                throw new ArgumentException();
            } else {
                if (((Point) obj).X == ((Point) obj).Y) {

                } else {

                }
            }
            


        }

        public static Point operator +(Point left, Point right) {
            return new(left.X + right.X, left.Y + left.Y);
        }

        public static Point operator -(Point left, Point right) {
            return new (left.X - right.X, left.Y - left.Y);
        }

        public static Point operator *(Point left, Point right) {
            return new (left.X * right.X, left.Y * left.Y);
        }

        public static Point operator /(Point left, Point right) {
            if (left.X != 0 && right.X != 0) {
                return new Point(left.X + right.X, left.Y + left.Y);
            }
            throw new DivideByZeroException();
        }

        public static bool operator <(Point left, Point right) {
            return left.Y <= right.Y && left.X < right.X;
        }

        public static bool operator >(Point left, Point right) {
            return left.Y >= right.Y && left.X > right.X;
        }

        public static bool operator <=(Point left, Point right) {
            return left.Y <= right.Y && left.X <= right.X;
        }

        public static bool operator >=(Point left, Point right) {
            return left.Y >= right.Y && left.X >= right.X;
        }
        
        
    }
}
