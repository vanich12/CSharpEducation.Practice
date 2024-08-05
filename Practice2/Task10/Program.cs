using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesTest;


namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            args[0] = "1";
            int[] newInt = new int[int.Parse(args[0])];
            Utils.PrintArray(newInt);
            Console.ReadKey();
        }
        
    }
}
