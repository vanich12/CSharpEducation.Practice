using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер года для проверки");
            int currentYear = int.Parse(Console.ReadLine());
            if (CheckLeapYear(currentYear))
            {
                Console.WriteLine("Год високосный");
            }
            else
            {
                Console.WriteLine("Год не вискоксоный");
            }

            Console.ReadKey();
        }

        static bool CheckLeapYear(int year)
        {
            if (year % 400 ==0)
            {
                return true;
            }
            else if(year % 100 ==0)
            {
                return false;
            }
            else if (year % 4 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
