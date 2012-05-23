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

namespace Client
{
    /// <summary>
    /// Interaction logic for Registreeri_window.xaml
    /// </summary>
    public partial class Registreeri_window : Window
    {
        public Registreeri_window()
        {
            InitializeComponent();
            frame.NavigationService.Navigate(new Uri("registreeri_page.xaml", UriKind.Relative));
        }
    }
}
