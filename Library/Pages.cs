using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class Pages
    {   //This method will be called when accumalating calories.
        public static int PageWatcher(int Page)
        {   //The total calories is accumalated.
            
            //If the total amount of calories for a recipe is greater than 300 then a warning message will
            //be displayed to the user.
            if (Page > 300)
            {
                Console.WriteLine("WARNING! \nThis book exceeds 300 pages! It may take you some time to finish this book...");
            }
            return Page;
        }
    }
}
