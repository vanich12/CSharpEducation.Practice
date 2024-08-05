using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8.Practice3
{
    internal struct Triangle
    {
        private double Width { get; set; }

        private double Height { get; set; }

        public double GetArea()
        {
            return Width * Height;
        }
    }
}
