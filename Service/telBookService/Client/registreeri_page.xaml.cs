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
            user.Username = txt_username.Text;
            user.Password = txt_password.Password;
            user.Email = txt_email.Text;
            user.Role = 1;

            klient.saveUser(user);
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
