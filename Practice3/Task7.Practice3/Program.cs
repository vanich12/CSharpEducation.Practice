using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Practice3
{
    internal class Program
    {
       public enum Months
        {
            January = 1, 
            February, 
            March,
            April,
            May, 
            June,
            July,
            August, 
            September,
            October,
            November,
            December
        }

        static void Main(string[] args)
        {

        }
        
        public int GetMonthfDayCount(Months month, int year)
        {
            switch (month)
            { 
                case Months.January:
                case Months.March:
                case Months.May:
                case Months.July:
                case Months.August:
                case Months.October:
                case Months.December:
                    return 31;
                case Months.April:
                case Months.June:
                case Months.September:
                case Months.November:
                    return 30;
                case Months.February:
                    if (DateTime.IsLeapYear(year))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                default:
                {
                    return 0;
                }

            }
        }
    }
}
