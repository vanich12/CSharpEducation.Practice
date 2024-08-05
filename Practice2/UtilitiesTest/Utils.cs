using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesTest
{
    public static class Utils
    { 
        //вывод одномерного массива
      public static void PrintArray(Array arr)
      {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
      }
        //вывод двумерного массива
        public static void PrintMeasureArray<T>(T[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
