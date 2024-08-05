using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24
{

    public enum Week
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public class Program
    {
        static void Main(string[] args)
        {
            foreach (var day in Enum.GetValues(typeof(Week)))
            {
                Console.WriteLine(day);
            }

            Console.ReadKey();
        }
    }
}
