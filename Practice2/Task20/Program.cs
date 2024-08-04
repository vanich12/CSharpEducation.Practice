using System;

namespace Task19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = GenerateRandom2DArray(3, 4);

            Print2DArray(array);
            PrintRowDifferences(array);

            Console.ReadKey();
        }

        static int[,] GenerateRandom2DArray(int rows, int columns)
        {
            int[,] array = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(1, 101);
                }
            }

            return array;
        }

        static void Print2DArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void PrintRowDifferences(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                int min = array[i, 0];
                int max = array[i, 0];

                for (int j = 1; j < columns; j++)
                {
                    if (array[i, j] < min)
                        min = array[i, j];
                    if (array[i, j] > max)
                        max = array[i, j];
                }

                int difference = max - min;
                Console.WriteLine($"Разница в строке {i + 1}: {difference}");
            }
        }
    }
}
