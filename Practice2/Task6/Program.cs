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
            //c
            if (args.Length != 2)
            {
                Console.WriteLine("Принимается два аргмуента");
                return;
            }

            string comStr = args[0];
            char comSymb = args[1][0];

            Console.WriteLine(PointC.PercentageOfSymbolThitd(comStr,comSymb));

            //b
            string str = Console.ReadLine();
            char symb = char.Parse(Console.ReadLine());

            Console.WriteLine(PointB.PercentageOfSymbolSecond(str,symb));
            Console.ReadKey();
        }
        //a
        static double PercentageOfSymbolFirst()
        {

            string str = "jfksdjfksdjfksd";
            char symb = 'j';
            int symbCounter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == symb)
                {
                    symbCounter++;
                }
            }

            double symbPercent = Math.Round((double)symbCounter / str.Length * 100, 1);

            return symbPercent;
        }
    }
}
