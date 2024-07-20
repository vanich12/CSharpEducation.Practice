using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            var radius = 3.0;
            var square = pi * Math.Pow(radius,2);
            Console.WriteLine("Площадь круга равна: " + square);
            Console.ReadKey();
        }
    }
}
