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
    /// Interaction logic for registteri.xaml
    /// </summary>
    public partial class registteri : Page
    {
        ItelBookServiceClient klient;
        public registteri()
        {
            klient = new ItelBookServiceClient("WSHttpBinding_ItelBookService");
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.Email = mail.Text;
            user.Username = usr.Text;
            user.Password = pw.Text;
            user.Role = 1;

            klient.saveUser(user);
        }
    }
}
