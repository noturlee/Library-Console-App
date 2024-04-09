using System;
namespace MyConsoleLibrary
{
    class BookLibrary
    {

        public static void Main()
        {
            BookMethods callPrompts = new BookMethods();

            callPrompts.BookPrompts();

            while (true)
            {
                Console.WriteLine("\nWhat would you like to do\n\n" +
                "1.Read Book\n" +
                "2.Scale Pages\n" +
                "3.Revert Pages\n" +
                "4.Delete Book\n" +
                "5.Exit\n");

                int userChoice = int.Parse(Console.ReadLine());


                switch (userChoice)
                {
                    case 1:
                        callPrompts.DisplayBook();
                        break;

                    case 2:
                        callPrompts.IncreasePages();
                        break;

                    case 3:
                        callPrompts.RevertPage();
                        break;

                    case 4:
                        callPrompts.ClearShelve();
                        break;

                    case 5:
                        callPrompts.CloseBook();
                        break;
                }
                continue;
            }
        }
    }
}

