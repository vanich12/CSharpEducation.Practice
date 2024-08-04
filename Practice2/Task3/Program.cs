using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static double ExpressionCalculate()
        {
            double a =double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());
            while (a == 0)
            {
                Console.WriteLine($"значение {a} не должно равняться нулю");
                a = double.Parse(Console.ReadLine());   
            }

            return (a + b - f / a) + f * a * a - (a + b);
    
        }
    }
}
