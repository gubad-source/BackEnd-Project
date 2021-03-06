﻿using System;
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
using Library.Data;
using Library.Models;
using Library.Windows;

namespace Library.Windows
{
    /// <summary>
    /// Interaction logic for DashboardWindow.xaml
    /// </summary>
    public partial class DashboardWindow : Window
    {
        private readonly LibraryContext _context;
        private Book _selectedBook;

        //Main window have been created//
        public DashboardWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
            FillCustomers();
            FillBooks();
            FillCmbCustomerReturn();
           
        }

       
        private void FillCmbCustomerReturn()
        {
            CmbCustomerReturn.ItemsSource = _context.Customers.ToList();
        }
        private void FillCustomers()
        {
            CmbCustomers.ItemsSource = _context.Customers.ToList();
        }
        private void FillBooks()
        {
            CmbBooks.ItemsSource = _context.Books.ToList();
        }

        private void ManagersBtn_Click(object sender, RoutedEventArgs e)
        {
            ManagersWindow cw = new ManagersWindow();
            cw.Show();
        }

        private void BooksBtn_Click(object sender, RoutedEventArgs e)
        {
            BooksWindow cw = new BooksWindow();
            cw.Show();
        }

        private void CustomersBtn_Click(object sender, RoutedEventArgs e)
        {
            CustomersWindow cw = new CustomersWindow();
            cw.Show();
        }

        private void OrderBtn_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order()
            {
                Book = (Book)CmbBooks.SelectedItem,
                Customer = (Customer)CmbCustomers.SelectedItem,
                DeadLine = (DateTime)DtpDeadLine.SelectedDate

            };
            _context.Orders.Add(order);
           
            _context.SaveChanges();
            
        }

        private void CustomerReturnBtn_Click(object sender, RoutedEventArgs e)
        {
            if (CmbCustomerReturn.SelectedItem == null) return;
            //_selectedBook =(Book)CmbCustomerReturn.SelectedItem;
            //ListBox.ItemsSource = _selectedBook.ToString();
            //CmbCustomerReturn.SelectedItem = "[SELECT*FROM ORDERS WHERE BookId ]";
            //ListBox.ItemsSource = _context.Orders.Where(o => o.Book = 1);



        }

        



    }
}

