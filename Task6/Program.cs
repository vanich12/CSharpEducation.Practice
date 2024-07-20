using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // случай a
            Console.WriteLine("Введите длину первого катета:");
            double cathetus1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину второго катета:");
            double cathetus2 = double.Parse(Console.ReadLine());

            double hypotenuse = Math.Sqrt(Math.Pow(cathetus1, 2) + Math.Pow(cathetus2, 2));
            Console.WriteLine($"Гипотенуза равна: {hypotenuse}");

            //случай b
            Console.WriteLine("Введите длину известного катета:");
            double cathetus3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ввеидите длину гипотинузы");
            double hypothinuse = double.Parse(Console.ReadLine());

            if (hypothinuse > cathetus3)
            {
                var cathetus4 = Math.Sqrt(Math.Pow(hypothinuse,2) - Math.Pow(cathetus3, 2));
                Console.WriteLine($"Неизвестный катет равен: {cathetus4}");
            }
            else
            {
                Console.WriteLine("Катет должен быть меньше гипотинузы");
            }

        }
    }
}
