using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BookDescriptions
    {
        public string BookName ; 
        public string Description;

        public BookDescriptions(string bookName, string description)
        {
            this.BookName = bookName;
            this.Description = description;
        }
    }
}
