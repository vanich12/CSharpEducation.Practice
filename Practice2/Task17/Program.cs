using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 31;
            int secondNumber = 90;

            Swap(ref firstNumber, ref secondNumber);
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.ReadKey();
        }

        static void Swap(ref int firstNumber, ref int secondNumber)
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }
    }
}
