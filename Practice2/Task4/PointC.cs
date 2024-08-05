using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal static class PointC
    {
        public static void PrintAnotherTriangle(int height, char symb)
        {

            for (int i = 1; i <= height; i++)
            {
                Console.WriteLine(new string(' ', height - i) + new string(symb, i));
            }
        }
    }
}
