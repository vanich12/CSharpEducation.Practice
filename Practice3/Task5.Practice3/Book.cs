using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Practice3
{
    internal class Book
    {
        private string Name { get; set; }

        private int AgeOfPublication { get; set; }
        private string Author { get; set; }

        public Book()
        {
            this.Name = "Книга Иван";
            this.Author = "Автор Иван";
        }

        public Book(string name, string author):this(name, 0, author)
        {
            this.Name = name;
            this.Author = author;
        }

        public Book(string name):this(name,"")
        {
            this.Name = name;
        }

        public Book(string name, int ageOfPublication, string author)
        {
            Name = name;
            AgeOfPublication = ageOfPublication;
            Author = author;
        }
    }
}
