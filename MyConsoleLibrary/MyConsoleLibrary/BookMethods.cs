using System;
using System.Collections;

namespace MyConsoleLibrary
{
	public class BookMethods
	{
        BookFields fetchfield = new BookFields();
        ArrayList BookShelve = new ArrayList();

        public void BookPrompts()
		{
            //create an object of the BookFields to call them

            Console.WriteLine("Welcome to My Console Library\n\n"
                            + "Enter a Book Name");
            fetchfield.BookName = Console.ReadLine();
            BookShelve.Add("Book Name -> " + fetchfield.BookName);


            Console.WriteLine($"Enter how many chapters for {fetchfield.BookName}");
            fetchfield.Chapters = int.Parse(Console.ReadLine());
            BookShelve.Add("Number of Chapters -> " + fetchfield.Chapters);


            Console.WriteLine($"Enter how many pages for {fetchfield.BookName}");
            fetchfield.Pages = int.Parse(Console.ReadLine());
            BookShelve.Add("Number of pages -> " + fetchfield.Pages);

            //loop how many time theres a chapter
            for (int i = 1; i <= fetchfield.Chapters; i++)
            {
                Console.WriteLine("Enter decription " + i);
                fetchfield.Description = Console.ReadLine();
                BookShelve.Add("Chapter " + i +" Decription -> " + fetchfield.Description);
            }
           
        }

        public void DisplayBook()
        {
            foreach(var item in BookShelve)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void IncreasePages()
        {
            fetchfield.OgNumber = fetchfield.Pages; // Restore original number of pages
            fetchfield.Pages *= 2; // Double the number of pages
            UpdateBookShelvePages(fetchfield.Pages);
        }

        public void RevertPage()
        {
            fetchfield.Pages = fetchfield.OgNumber; // Restore original number of pages
            UpdateBookShelvePages(fetchfield.Pages);
        }

        // Helper method to update BookShelve with the new number of pages
        private void UpdateBookShelvePages(int newPages)
        {
            for (int i = 0; i < BookShelve.Count; i++)
            {
                if (BookShelve[i].ToString().StartsWith("Number of pages -> "))
                {
                    BookShelve[i] = "Number of pages -> " + newPages;
                    break; // Exit loop after updating
                }
            }
        }

        public void ClearShelve()
        {
            BookShelve.Clear();
        }

        public void CloseBook()
        {
            System.Environment.Exit(0);
        }


	}
}

