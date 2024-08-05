using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public class Program
    {
        static void Main(string[] args)
        {
           var newArray = CreateArray(4);

           PrintArray(newArray);
           Console.ReadKey();
        }

        static int[] CreateArray(int countElem)
        {
            int[] intArray = new int[countElem];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i;
            }
            return intArray;
        }

        static void PrintArray(Array arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
