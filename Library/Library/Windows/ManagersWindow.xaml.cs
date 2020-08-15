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
    /// Interaction logic for ManagersWindow.xaml
    /// </summary>
    public partial class ManagersWindow : Window
    {
        //Managers Window have been created all users of this program will be listed in here//
        private readonly LibraryContext _context;
        private Manager _selectedManager;
        public ManagersWindow()
        {

            InitializeComponent();
            _context = new LibraryContext();
            FillManagers();
            Reset();
        }

        //Reseting means clearing information//
        private void Reset (){
            TxtName.Clear();
            TxtSurname.Clear();

            BtnCreate.Visibility = Visibility.Visible;
            BtnDelete.Visibility = Visibility.Hidden;
            BtnUpdate.Visibility = Visibility.Hidden;
            FillManagers();
        }
        private void FillManagers()
        {
            DgbManagers.ItemsSource = _context.Managers.ToList();
        }

        //Validating information//
        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
           
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                LblName.Foreground = new SolidColorBrush(Colors.Red);
                MessageBox.Show("Please enter Admin name");
                return;
            }
            else
            {
                LblName.Foreground = new SolidColorBrush(Colors.Black);
                
            }
            if (string.IsNullOrEmpty(TxtSurname.Text))
            {
                LblSurname.Foreground = new SolidColorBrush(Colors.Red);
                MessageBox.Show("Please Enter Surname");
                return;
            }
            else
            {
                LblSurname.Foreground = new SolidColorBrush(Colors.Black);
            }
            Manager manager = new Manager()
            {
                Name = TxtName.Text,
                Surname=TxtSurname.Text
            };
            _context.Managers.Add(manager);
            _context.SaveChanges();
            Reset();
            MessageBox.Show("Admin has been added");
            //FillManagers();
        }

        //Selection Response//
        private void DgbManagers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgbManagers.SelectedItem == null) return;
            _selectedManager = (Manager)DgbManagers.SelectedItem;
            TxtName.Text = _selectedManager.Name;
            TxtSurname.Text = _selectedManager.Surname;

            BtnCreate.Visibility = Visibility.Hidden;
            BtnDelete.Visibility = Visibility.Visible;
            BtnUpdate.Visibility = Visibility.Visible;
        }

        //Deleting information//
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            _context.Managers.Remove(_selectedManager);
            _context.SaveChanges();
          
            Reset();
        }

        //Updating information//
        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                LblName.Foreground = new SolidColorBrush(Colors.Red);
                MessageBox.Show("Please enter Admin name");
                return;
            }
            else
            {
                LblName.Foreground = new SolidColorBrush(Colors.Black);

            }
            if (string.IsNullOrEmpty(TxtSurname.Text))
            {
                LblSurname.Foreground = new SolidColorBrush(Colors.Red);
                MessageBox.Show("Please Enter Surname");
                return;
            }
            else
            {
                LblSurname.Foreground = new SolidColorBrush(Colors.Black);
            }

            _selectedManager.Name = TxtName.Text;
            _selectedManager.Surname = TxtSurname.Text;
         
            _context.SaveChanges();
            Reset();
            MessageBox.Show("Data has been updated");
        }
    }
}
