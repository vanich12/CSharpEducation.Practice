using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PointC.PrintAnotherTriangle(4,'*');
            Console.ReadKey();

        }
        //a
        static void PrintTriangle(int height, char symb)
        {
            for (int i = 1; i <= height; i++)
            {
                Console.WriteLine(new string(symb, i));
            }
        }
    }
}
