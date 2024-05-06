using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BookFields
    {
        public string? BookName { get; set; }
        public int? Chapters { get; set; }
        public int Pages { get; set; }
        public List<BookDescriptions> description = new List<BookDescriptions>();
        public int OgNumber { get; set; }

        public BookFields(string? bookName, int? chapters,
            int pages, List<BookDescriptions> Desc, int ogNum)
        {
            this.BookName = bookName;
            this.Chapters = chapters;
            this.Pages = pages;
            this.description = Desc;
            this.OgNumber = ogNum;
        }
    }
}
