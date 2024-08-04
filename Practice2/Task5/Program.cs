using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var a = int.Parse(Console.ReadLine());
           var b = int.Parse(Console.ReadLine());

           int result = Comparison(a, b);
           if (result == 1)
           {
              Console.WriteLine($"Число {a} больше чем {b}"); 
           }
           else if(result == 0)
           {
               Console.WriteLine("Числа равны");
           }
           else
           {
               Console.WriteLine($"Число {a} меньше чем {b}");
           }
        }

        static int Comparison(int a, int b)
        {
            return (a.CompareTo(b));
        }
    }
}
