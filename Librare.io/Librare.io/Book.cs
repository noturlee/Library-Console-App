using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librare.io
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nAuthor: {Author}\nISBN: {ISBN}\nDescription\n{Description}\n";
        }
    }
}