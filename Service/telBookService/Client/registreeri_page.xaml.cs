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
    /// Interaction logic for registreeri.xaml
    /// </summary>
    public partial class registreeri : Page
    {
        ItelBookServiceClient klient;
        public registreeri()
        {
            klient = new ItelBookServiceClient("WSHttpBinding_ItelBookService");
            InitializeComponent();
        }

        private void btn_reg_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
<<<<<<< HEAD
            user.Email = email.Text;
            user.Username = username.Text;
            user.Password = password.Password;
=======
            user.Username = txt_username.Text;
            user.Password = txt_password.Password;
            user.Email = txt_email.Text;
>>>>>>> d3c44ce8d987de44505f2d1ee32c6446bb4d9f07
            user.Role = 1;

            klient.saveUser(user);

            login_window main = new login_window();
            App.Current.MainWindow = main;
            main.Show();
            Window.GetWindow(this).Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            login_window main = new login_window();
            App.Current.MainWindow = main;
            main.Show();
            Window.GetWindow(this).Close();
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is login_window)
            {
                login_window top = (login_window)Window.GetWindow(this);
                top.toLogPage();
            }
        }
    }
}
