using System;
namespace Library
{
    class BookLibrary
    {
        public delegate int PageNumbers(int Page);

        public static void Main()
        {
            Console.Title = "My Console Library";
            Console.WriteLine("Welcome to My Console Library\n");
            BookMethods callPrompts = new BookMethods();

            

            while (true)
            {
                Console.WriteLine(
                    "What would you like to do?\n" +
                "1.Add A Book\n" +
                "2.Read Book\n" +
                "3.Scale Pages\n" +
                "4.Revert Pages\n" +
                "5.Delete Book\n" +
                "6.Exit\n");

                int userChoice = int.Parse(Console.ReadLine());


                switch (userChoice)
                {
                    case 1:
                        callPrompts.BookPrompts();
                        break;

                    case 2:
                        callPrompts.DisplayBook();
                        break;

                    case 3:
                        callPrompts.IncreasePages();
                        break;

                    case 4:
                        callPrompts.RevertPage();
                        break;

                    case 5:
                        callPrompts.ClearShelve();
                        break;

                    case 6:
                        callPrompts.CloseBook();
                        break;
                }
                continue;
            }
        }
    }
}

