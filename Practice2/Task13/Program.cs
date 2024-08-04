using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesTest;

namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = CompletionArray(3, 4, 10, 50);
            Utils.PrintMeasureArray(array);
            Console.ReadKey();
        }

        static int[,] CompletionArray(int rows, int column, int minValue, int maxValue) 
        {
            Random random = new Random();
            int[,] array = new int[rows, column];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minValue, maxValue);
                }
            }

            return array;
        }
    }
}
