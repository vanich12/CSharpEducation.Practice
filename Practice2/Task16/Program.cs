using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            IntChangeSign(ref number);
            Console.WriteLine(number);
            Console.ReadKey();
        }

        static void IntChangeSign(ref int number)
        {
            number = 4;
        }
    }
}
