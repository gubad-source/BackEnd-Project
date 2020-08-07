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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        //Entrance window have been created//
        public Login()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            ////UserName////
            //if(UserTxt.Text=="")
            //{
            //    MessageBox.Show("Please Enter Username");
            //}else if (UserTxt.Text == "Dalek")
            //{
            //    MessageBox.Show("crap");
            //}else
            //{
            //    MessageBox.Show("Username is not correct");
            //}

            ////Password////
            if (PassTxt.Text=="")
            {
                MessageBox.Show("Please enter password");
            }else if (PassTxt.Text == "a")
            {
                DashboardWindow cw = new DashboardWindow();
                cw.Show();
               
            }
            else
            {
                MessageBox.Show("Password is incorrrect");
            }
        }
    }
}
