using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9.Practice3
{
    internal class Student
    {
        private string Name { get; set; }
        private int Age { get; set; }

        public void Rename(Student student)
        {
            student.Name = "Аноним";
        }
    }
}
