using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Library.Data;
using Library.Models;
using System.Linq;



namespace Library.Windows
{
   
    /// <summary>
    /// Interaction logic for BooksWindow.xaml
    /// </summary>
    public partial class BooksWindow : Window
    {
        private readonly LibraryContext _context;
        private Book _selectedBook;
        public BooksWindow()
        {
          
            InitializeComponent();
            _context = new LibraryContext();
            FillShelf();
            FillBookcase();
            FillBooks();
        }
        private void Reset()
        {
            CmbBookcase.SelectedItem = null;
            CmbShelf.SelectedItem = null;
            TxtName.Clear();
            TxtPrice.Clear();

            DeleteBtn.Visibility = Visibility.Hidden;
            UpdateBtn.Visibility = Visibility.Hidden;
            CreateBtn.Visibility = Visibility.Visible;
        }
        private void FillShelf()
        {
            CmbShelf.ItemsSource = _context.Shelfs.ToList();
        }
        private void FillBookcase()
        {
            CmbBookcase.ItemsSource = _context.Bookcases.ToList();
        }
        private void FillBooks()
        {
            DgbBooks.ItemsSource = _context.Books.ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                MessageBox.Show("Please Enter Name");
                return;
            }
            if (string.IsNullOrEmpty(TxtPrice.Text))
            {
                MessageBox.Show("Please Enter Price");
                return;
            }
            if (CmbBookcase.SelectedItem == null)
            {
                MessageBox.Show("Please choose Bookcase");
                return;
            }
            if (CmbShelf.SelectedItem == null)
            {
                MessageBox.Show("Please enter a shelf");
                return;
            }
            Book book = new Book()
            {
                Name = TxtName.Text,
                Shelf = (Shelf)CmbShelf.SelectedItem,
                Bookcase = (Bookcase)CmbBookcase.SelectedItem,
                Price = TxtPrice.Text
            };
            _context.Books.Add(book);
            _context.SaveChanges();
            Reset();
        }

        private void DgbBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgbBooks == null) return;
            _selectedBook = (Book)DgbBooks.SelectedItem;
            TxtName.Text = _selectedBook.Name;
            CmbShelf.SelectedItem = _selectedBook.Shelf;
            CmbBookcase.SelectedItem = _selectedBook.Bookcase;
            TxtPrice.Text = _selectedBook.Price;

            DeleteBtn.Visibility = Visibility.Visible;
            UpdateBtn.Visibility = Visibility.Visible;
            CreateBtn.Visibility = Visibility.Hidden;

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            _context.Books.Remove(_selectedBook);
            _context.SaveChanges();
            Reset();
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            _selectedBook.Name = TxtName.Text;
            _selectedBook.Shelf = (Shelf)CmbShelf.SelectedValue;
            _selectedBook.Bookcase =(Bookcase) CmbBookcase.SelectedValue;
            _selectedBook.Price = TxtPrice.Text;

            _context.SaveChanges();

            Reset();
        }
    }
}
