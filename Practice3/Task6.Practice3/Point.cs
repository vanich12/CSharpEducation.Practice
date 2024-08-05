using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Practice3
{
    internal struct Point
    {
        private double X { get; set; }
        private double Y { get; set; }

        public double GetDistance(Point point1, Point point2)
        {
            return Math.Sqrt((Math.Pow(point1.X,2) - Math.Pow(point2.X,2))+(Math.Pow(point1.Y,2) - Math.Pow(point2.Y,2)));
        }
    }
}
