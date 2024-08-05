using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10.Practice3
{
    internal class Car
    {
        private string Mark { get; set; }

        public void GetMark(Car car)
        {
            Console.WriteLine($"Название марки этого автомобоиля: {car.Mark}");
        }
    }
}
