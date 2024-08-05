using System;
using System.Collections.Generic;
using UtilitiesTest;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strList = new List<string>();
            Console.WriteLine("Напишите stop когда захотите закончить ввод");
            string str = Console.ReadLine();
            while (str != "stop")
            {
                strList.Add(str);
                str = Console.ReadLine();
            }

            CompletionArray(strList.ToArray());
            Console.ReadKey();
        }

        static void CompletionArray(params string[] userStr)
        {
            string[] strArray = new string[userStr.Length];
            for (int i = 0; i < userStr.Length; i++)
            {
                strArray[i] = userStr[i];
            }
            Console.WriteLine("Вывод массива");
            Utils.PrintArray(strArray);
        }
    }
}
