using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    internal class Program
    {
        private static int currentNum;
        static void Main(string[] args)
        {
            int generateValue = GenerateNum();
            bool isValid = false;
            while (!isValid)
            {
                currentNum = int.Parse(Console.ReadLine());
                isValid = CheckValidNum(currentNum);
            }

            if (currentNum == generateValue)
            {
                Console.WriteLine("Вы молодец, вы угадали");
            }
        }

        static bool CheckValidNum(int value)
        {
            return value <= 100 && value >= 1;
        }

        static int GenerateNum()
        {
            Random random = new Random();
            return random.Next();
        }
    }
}
