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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Librare.io
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Collection to hold book details
        private ObservableCollection<Book> books = new ObservableCollection<Book>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Capture user inputs and create a new book
            var book = new Book
            {
                Name = BookNameTextBox.Text,
                Author = AuthorTextBox.Text,
                ISBN = IsbnTextBox.Text,
                Description = DescriptionTextBox.Text
            };

            // Add the book to the collection
            books.Add(book);

            // Create and show the ViewBook window with book details collection
            ViewBook viewBookWindow = new ViewBook(books);
            viewBookWindow.Show();
        }

    }
}
