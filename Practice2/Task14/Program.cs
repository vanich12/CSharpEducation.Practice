using System;
using UtilitiesTest;

namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            int[] array = CreateEmptyArray(size);
            FillArray(array);
            Utils.PrintArray(array);
        }

        static int[] CreateEmptyArray(int size)
        {
            return new int[size];
        }

        static void FillArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101);
            }
        }

    }
}