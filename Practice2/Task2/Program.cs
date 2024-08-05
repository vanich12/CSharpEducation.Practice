using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dist = PointB.DistanceMacroParse(2);
            var test = PointC.SpeedParse(4);
            Console.WriteLine(dist);
            Console.ReadKey();
        }
        //a
        static double DistanceParse(double value)
        {
            return value * 1000;
        }
        //d
        static double TemperatureParse(double value)
        {
            return value * 33.8;
        }
    }
}
