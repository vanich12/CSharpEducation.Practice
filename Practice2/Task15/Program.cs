using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesTest;

namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1,2,3,4};
            var newArray = ReversArray(arr);
            Utils.PrintArray(newArray);
            Console.ReadKey();
        }

        static T[] ReversArray<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length/2 ; i++)
            {
                T temp = arr[i];
                arr[i] = arr[arr.Length - i -1];
                arr[arr.Length - i - 1] = temp;
            }
            return arr;
        }
    }
}
