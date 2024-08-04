using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal static class PointC
    {
        public static string ParseToRegisterFirstSymb(string str)
        {
            string firstSymb = str[0].ToString().ToUpper();
            string otherWord = new string(str.Skip(1).ToArray());
            return firstSymb + otherWord;
        }
    }
}
