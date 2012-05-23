using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Client.TelBookServiceReference;

namespace Client
{
    /// <summary>
    /// Interaction logic for login_page.xaml
    /// </summary>
    public partial class login_page : Page
    {
        ItelBookServiceClient klient;

        public login_page()
        {
            InitializeComponent();
            klient = new ItelBookServiceClient("WSHttpBinding_ItelBookService");
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            string name = text_username.Text;
<<<<<<< HEAD
<<<<<<< HEAD
            string pswd = text_password.Password;
=======
            string pswd = text_password.Text;
>>>>>>> 360ada5648cdb70ff12834732d177159f8598db7
=======
            string pswd = text_password.Password;
>>>>>>> d3c44ce8d987de44505f2d1ee32c6446bb4d9f07

            User user = klient.login(name, pswd);

            if (user != null)
            {
                MainWindow main = new MainWindow();
                App.Current.MainWindow = main;
                main.LoggedUser = user;
                main.Show();
                Window.GetWindow(this).Close();
            }
        }
<<<<<<< HEAD
<<<<<<< HEAD

        private void btn_reg_Click(object sender, RoutedEventArgs e)
        {
            Registreeri_window main = new Registreeri_window();
            App.Current.MainWindow = main;
            main.Show();
            Window.GetWindow(this).Close();
        }


=======
>>>>>>> 360ada5648cdb70ff12834732d177159f8598db7
=======

        private void btn_reg_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is login_window)
            {
                login_window top = (login_window)Window.GetWindow(this);
                top.toRegPage();
            }
        }
>>>>>>> d3c44ce8d987de44505f2d1ee32c6446bb4d9f07
    }
}
