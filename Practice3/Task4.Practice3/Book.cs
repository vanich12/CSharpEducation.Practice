using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Practice3
{
    internal class Book
    {
        private string Name { get; set; }

        private string Author { get; set; }

        public Book()
        {
            this.Name = "Книга Иван";
            this.Author = "Автор Иван";
        }

        public Book(string name,string author)
        {
            this.Name = name;
            this.Author = author;
        }
    }
}
