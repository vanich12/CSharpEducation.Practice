using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PointC.ParseToRegisterFirstSymb("привет"));
            Console.ReadKey();
        }
        // a
        static string ParseToRegisterUpperCase(string str)
        {
            return str.ToUpper();
        }    
    }
}
