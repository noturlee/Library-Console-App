using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Library.BookLibrary;

namespace Library
{
    public class BookMethods
    {
        List<BookFields> books = new List<BookFields>();
        List<BookDescriptions> descriptions = new List<BookDescriptions>();

        public void BookPrompts()
        {
            //create an object of the BookFields to call them

            Console.WriteLine("Enter a Book Name");
            string name = Console.ReadLine();



            Console.WriteLine($"Enter how many chapters for {name}");
            int? chapters = int.Parse(Console.ReadLine());


            Console.WriteLine($"Enter how many pages for {name}");
            int pages = int.Parse(Console.ReadLine());
            //DelegateName objectName = new DelegateName(class.method)
            PageNumbers PageCounter = new PageNumbers(Pages.PageWatcher);
            //The total number of pages stored.
            pages = PageCounter(pages);

            string description = "";
            //loop how many time theres a chapter
            for (int i = 1; i <= chapters; i++)
            {
                Console.WriteLine("Enter decription " + i);
                description = Console.ReadLine();
                description = "Chapter " + i + " Description: " + description;
                BookDescriptions desc = new BookDescriptions(name, description);
                descriptions.Add(desc);
            }

            BookFields BookField = new BookFields(name, chapters, pages, descriptions,pages);
            books.Add(BookField);

        }

        public void DisplayBook()
        {
            //Code attribution
            //This code was adapted from Everything C#'s Youtube Channel. 
            //https://youtu.be/5ceCacQCb7c
            //Everything C#
            //https://www.youtube.com/@EverythingCSharp
            books.Sort((book1, book2) => book1.BookName.CompareTo(book2.BookName));
            int count = books.Count;
            for (int i = 0; i < count; i++)
            {
                if (i > 0 && books[i].BookName.Equals(books[i - 1].BookName))
                { break; }
                Console.WriteLine("\nBook " + (i + 1) + ": " + books[i].BookName);


            }
            Console.WriteLine("Enter your chosen book name that you wish to view: ");
            string search = Console.ReadLine();
            string BookDesc = "";
            Console.WriteLine("We are searching for : " + search + "\nHang on a sec...");
            foreach (BookFields Item in books)
            {
                if (Item.BookName.Equals(search))
                {
                    for (int i = 0; i < descriptions.Count; i++)
                    {
                        if (descriptions[i].BookName.Equals(search))
                        {
                            BookDesc += "\n " + descriptions[i].Description;
                        }
                    }
                        Console.WriteLine(
                        "\nBook Name: " + Item.BookName +
                            "\nNumber of Chapters: " + Item.Chapters +
                            "\nNumber of Pages: " + Item.Pages +
                             BookDesc);
                    
                }
            }
        }

        public void IncreasePages()
        {
            
            books.Sort((book1, book2) => book1.BookName.CompareTo(book2.BookName));
            int count = books.Count;
            for (int i = 0; i < count; i++)
            {
                if (i > 0 && books[i].BookName.Equals(books[i - 1].BookName))
                { break; }
                Console.WriteLine("\nBook " + (i + 1) + ": " + books[i].BookName);
            }
            Console.WriteLine("Enter your chosen book name that you wish to change the number of pages for: ");
            string search = Console.ReadLine();
            string BookDesc = "";
            Console.WriteLine("We are searching for : " + search + "\nHang on a sec...");
            foreach (BookFields Item in books)
            {
                if (Item.BookName.Equals(search))
                {
                    Item.Pages = Item.Pages * 2;
                        for (int i = 0; i < descriptions.Count; i++)
                        {
                            if (descriptions[i].BookName.Equals(search))
                            {
                                BookDesc += "\n " + descriptions[i].Description;
                            }
                        }
                        Console.WriteLine(
                        "\nBook Name: " + Item.BookName +
                            "\nNumber of Chapters: " + Item.Chapters +
                            "\nNumber of Pages: " + Item.Pages +
                             BookDesc);


                  
                }
            }


                }

        public void RevertPage()
        {
            books.Sort((book1, book2) => book1.BookName.CompareTo(book2.BookName));
            int count = books.Count;
            for (int i = 0; i < count; i++)
            {
                if (i > 0 && books[i].BookName.Equals(books[i - 1].BookName))
                { break; }
                Console.WriteLine("\nBook " + (i + 1) + ": " + books[i].BookName);
            }
            Console.WriteLine("Enter your chosen book name that you wish to change the number of pages for: ");
            string search = Console.ReadLine();
            string BookDesc = "";
            Console.WriteLine("We are searching for : " + search + "\nHang on a sec...");
            foreach (BookFields Item in books)
            {
                if (Item.BookName.Equals(search))
                {
                    Item.Pages = Item.OgNumber;

                    for (int i = 0; i < descriptions.Count; i++)
                    {
                        if (descriptions[i].BookName.Equals(search))
                        {
                            BookDesc += "\n " + descriptions[i].Description;
                        }
                    }
                    Console.WriteLine(
                    "\nBook Name: " + Item.BookName +
                        "\nNumber of Chapters: " + Item.Chapters +
                        "\nNumber of Pages: " + Item.Pages +
                         BookDesc);
                }


            }
        }

       

        public void ClearShelve()
        {
            books.Sort((book1, book2) => book1.BookName.CompareTo(book2.BookName));
            int count = books.Count;
            for (int i = 0; i < count; i++)
            {
                if (i > 0 && books[i].BookName.Equals(books[i - 1].BookName))
                { break; }
                Console.WriteLine("\nBook " + (i + 1) + ": " + books[i].BookName);
            }
            Console.WriteLine("Enter your chosen book name that you wish to delete: ");
            string search = Console.ReadLine();
            string BookDesc = "";
            Console.WriteLine("We are searching for : " + search + "\nHang on a sec...");

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].BookName.Equals(search))
                {
                    books.RemoveAt(i);
                    Console.WriteLine("Your book has been removed.");
                }
            }
                }

        public void CloseBook()
        {
            System.Environment.Exit(0);
        }


    }
}
