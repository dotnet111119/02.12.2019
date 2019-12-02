using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0212_opov
{
    public class Point
    {
        public double X { get; protected set; }
        public double Y { get; protected set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Point operator + (Point p1, Point p2)
        {
            Point result = new Point(p1.X + p2.X, p1.Y + p2.Y);
            return result;
        }

        public static Point operator -(Point p1, Point p2)
        {
            Point result = new Point(p1.X - p2.X, p1.Y - p2.Y);
            return result;
        }

        public static double operator *(Point p1, Point p2)
        {
            double result = p1.X *  p2.X + p1.Y * p2.Y;
            return result;
        }

        public override string ToString()
        {
            return $"Point: ({X}, {Y})";
        }
    }
}
