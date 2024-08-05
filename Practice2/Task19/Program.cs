using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesTest;

namespace Task19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = GenerateRandomArray(3);
            int diff = PrintItemDifference(arr);

            Utils.PrintArray(arr);
            Console.WriteLine();
            Console.WriteLine(diff);
            Console.ReadKey();

        }

        static int[] GenerateRandomArray(int length)
        {
            int[] numArr = new int[length];
            Random random = new Random();

           var newArr = numArr.Select(x=> x = random.Next(1,100)).ToArray();
            return newArr;  
        }

        static int PrintItemDifference(int[] arr)
        {
            List<int> newArr = arr.ToList();
            newArr.Sort();
            return newArr[newArr.Count-1] - newArr[0];
        }
    }
}
