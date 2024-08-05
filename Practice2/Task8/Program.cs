using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            CustomMultiplicationAlg(ref a,ref b,ref c);

            Console.Write($"числа с лева на право:{a},{b},{c}");
            Console.ReadKey();
        }

        static void CustomMultiplicationAlg(ref double a, ref double b, ref double c)
        { 
           double[] parametrs = new double[3] {a,b,c};
           bool hasRepeat = parametrs.GroupBy(x => x).Any(g=>g.Count()>1);

          if (hasRepeat)
          {
             var convertParam  = parametrs.Select(x=>x*5).ToArray();
             a = convertParam[0];
             b = convertParam[1]; 
             c = convertParam[2]; 
          }
          else
          {
              Console.WriteLine("Равных нет");
          }

        }
    }
}
