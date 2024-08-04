using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task22
{
    internal class Program
    {
        private static int currentNum;
        static void Main(string[] args)
        {
            int generateValue = GenerateNum();
            bool isValid = false;
            int counter = 0;
            while (!isValid || !(currentNum == generateValue))
            {
                counter++;
                currentNum = int.Parse(Console.ReadLine());
                isValid = CheckValidNum(currentNum);
                if (!isValid)
                {
                    Console.WriteLine("Введите число от 1 до 100");
                }

                Console.WriteLine(currentNum > generateValue ? "Загаданное число меньше вашего" : "Загаданное число больше вашего");


                if (counter > 10)
                {
                    Console.WriteLine("Вы проиграли");
                    Thread.Sleep(2000);
                    return;
                }
                if (currentNum == generateValue)
                {
                    Console.WriteLine($"Вы молодец, вы угадали c {counter} попытки");
                    Thread.Sleep(2000);
                    return;
                }
                else
                {
                    Console.WriteLine("Вы молодец, вы не угадали");
                }
            }

            Console.ReadKey();
        }

        static bool CheckValidNum(int value)
        {
            return value <= 100 && value >= 1;

        }

        static int GenerateNum()
        {
            Random random = new Random();
            return random.Next(1,100);
        }
    }
}
