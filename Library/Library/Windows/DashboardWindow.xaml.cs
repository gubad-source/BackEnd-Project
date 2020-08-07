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

namespace Library.Windows
{
    /// <summary>
    /// Interaction logic for DashboardWindow.xaml
    /// </summary>
    public partial class DashboardWindow : Window
    {
        //Main window have been created//
        public DashboardWindow()
        {
            InitializeComponent();
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
    }
}
