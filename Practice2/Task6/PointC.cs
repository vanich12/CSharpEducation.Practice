using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal static class PointC
    {
        public static double PercentageOfSymbolThitd(string str, char symb)
        {
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
