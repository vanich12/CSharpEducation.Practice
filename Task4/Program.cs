using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую фразу:");
            var firstPhrase = Console.ReadLine();

            Console.WriteLine("Введите вторую фразу:");
            var secondPhrase = Console.ReadLine();

            Console.WriteLine(firstPhrase + " " + secondPhrase);
            Console.ReadLine();
        }
    }
}
