using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Librare.io
{
    /// <summary>
    /// Interaction logic for ViewBook.xaml
    /// </summary>
    public partial class ViewBook : Window
    {
        private ObservableCollection<Book> books;

        public ViewBook()
        {
            InitializeComponent();
        }

        // New constructor that accepts book details collection
        public ViewBook(ObservableCollection<Book> bookDetails) : this()
        {
            // Initialize the book collection
            books = bookDetails;
            BookDetailsTextBlock.Text = string.Join("\n\n", books.Select(b => b.ToString()));
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchIsbn = IsbnSearchTextBox.Text;

            // Find the book with the matching ISBN
            var book = books.FirstOrDefault(b => b.ISBN == searchIsbn);

            if (book != null)
            {
                // Display the book's details
                BookDetailsTextBlock.Text = book.ToString();
            }
            else
            {
                // Clear the details text block if no match is found
                BookDetailsTextBlock.Text = "No book found with the given ISBN.";
            }
        }

        private void ShowAllButton_Click(object sender, RoutedEventArgs e)
        {
            // Display all books
            BookDetailsTextBlock.Text = string.Join("\n\n", books.Select(b => b.ToString()));
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Handle selection change if needed
        }
    }
}