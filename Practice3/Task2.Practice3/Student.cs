using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Practice3
{
    internal class Student
    {
        private string Name { get; set; }
        private int Age { get; set; }

        private double GPA
        {
            get => GPA;
            set
            {
                if (GPA >=0 && GPA <=5)
                {
                    GPA = value;
                }
            }
        }

        public Student(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }
        
        public void GetFullInfo()
        {
            Console.WriteLine($"Имя студента: {Name}");
            Console.WriteLine($"Возраст студента: {Age}");
        }
    }
}