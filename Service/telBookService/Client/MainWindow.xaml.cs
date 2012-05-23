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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ItelBookServiceClient klient;

        public MainWindow()
        {
            // ItelBookServiceClient client = new ItelBookServiceClient("TelBookServiceReference.ItelBookService");
            InitializeComponent();
            _mainFrame.NavigationService.Navigate(new Uri("browsecontact_page.xaml", UriKind.Relative));
            klient = new ItelBookServiceClient("WSHttpBinding_ItelBookService");
        }


        private void btn_AddContact_Click(object sender, RoutedEventArgs e)
        {

            _mainFrame.NavigationService.Navigate(new Uri("addcontact_page.xaml", UriKind.Relative));


        }

        private void btn_SearchContact_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.NavigationService.Navigate(new Uri("searchcontact_page.xaml", UriKind.Relative));
        }

        private void btn_BrowseContact_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.NavigationService.Navigate(new Uri("browsecontact_page.xaml", UriKind.Relative));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.NavigationService.Navigate(new Uri("registeeri_page.xaml", UriKind.Relative));
        }

     
    }
}
