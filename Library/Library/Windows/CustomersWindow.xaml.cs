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
using System.Linq;
using Library.Models;
using Library.Data;

namespace Library.Windows

{
    /// <summary>
    /// Interaction logic for CustomersWindow.xaml
    /// </summary>
    public partial class CustomersWindow : Window
    {
        private readonly LibraryContext _context;
        private Customer _selectedCustomer;
        public CustomersWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
            FillCustomers();
        }

        //(Reset)Returning everything back to its original//
        private void Reset()
        {
            TxtName.Clear();
            TxtSurname.Clear();

            CreateBtn.Visibility = Visibility.Visible;
            BtnDelete.Visibility = Visibility.Hidden;
            BtnUpdate.Visibility = Visibility.Hidden;
        }
        //Filling Comboboxes//
        private void FillCustomers()
        {
            DgbCustomers.ItemsSource = _context.Customers.ToList();
        }

        //Validating information//
        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                MessageBox.Show("Please Enter Name");
                return;
            }
            if (string.IsNullOrEmpty(TxtSurname.Text))
            {
                MessageBox.Show("Please Enter Surname");
                return;
            }
            Customer customer = new Customer()
            {
                Name=TxtName.Text,
                Surname=TxtSurname.Text
            };
            _context.Customers.Add(customer);
            _context.SaveChanges();
            Reset();
        }

        private void DgbCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgbCustomers == null) return;
            _selectedCustomer = (Customer)DgbCustomers.SelectedItem;
            TxtName.Text = _selectedCustomer.Name;
            TxtSurname.Text = _selectedCustomer.Surname;

            BtnDelete.Visibility = Visibility.Visible;
            BtnUpdate.Visibility = Visibility.Visible;
            CreateBtn.Visibility = Visibility.Hidden;
           
        }

        //Deleting information//
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            _context.Customers.Remove(_selectedCustomer);
                _context.SaveChanges();
            Reset();
        }

        //Updating information//
        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                MessageBox.Show("Please Enter Name");
                return;
            }
            if (string.IsNullOrEmpty(TxtSurname.Text))
            {
                MessageBox.Show("Please Enter Surname");
                return;
            }

            _selectedCustomer.Name = TxtName.Text;
            _selectedCustomer.Surname = TxtSurname.Text;
           
          
            _context.SaveChanges();
            Reset();
        }
    }
}
