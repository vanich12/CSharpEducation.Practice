using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesTest;

namespace Task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = new[] { 1, 2, 3, - 10, -1 };
            int countDeleteNum = 0;

            int[] newArr = DeleteNegativeNum(numArr, out countDeleteNum);
            Utils.PrintArray(newArr);
            Console.WriteLine();
            Console.WriteLine(countDeleteNum);
            Console.ReadKey();
        }

        static int[] DeleteNegativeNum(int[] numArr, out int countDelete)
        {
            var newArr = numArr.Where(x => x >= 0).ToArray();
            countDelete = numArr.Length - newArr.Length;
            return newArr;
        }
    }
}
