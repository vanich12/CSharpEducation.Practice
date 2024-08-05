using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesTest;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Пожалуйста, укажите два аргумента: длину массива и значение для заполнения массива.");
                return;
            }

            if (!int.TryParse(args[0], out int arrayLength) || arrayLength < 0)
            {
                Console.WriteLine("Пожалуйста, укажите корректную положительную длину массива.");
                return;
            }

            if (!int.TryParse(args[1], out int fillValue))
            {
                Console.WriteLine("Пожалуйста, укажите корректное значение для заполнения массива.");
                return;
            }

            int[] newArray = new int[arrayLength];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = fillValue;
            }
            Utils.PrintArray(newArray);
        }
    }
}
