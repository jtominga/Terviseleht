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
using System.Windows.Shapes;
using Client.TelBookServiceReference;

namespace Client
{
    /// <summary>
    /// Interaction logic for login_window.xaml
    /// </summary>
    public partial class login_window : Window
    {
        public login_window()
        {
            InitializeComponent();
            frame.NavigationService.Navigate(new Uri("login_page.xaml", UriKind.Relative));
        }

        
    }
}
