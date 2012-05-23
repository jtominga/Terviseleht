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
    /// Interaction logic for browsecontact_page.xaml
    /// </summary>
    public partial class browsecontact_page : Page
    {
        ItelBookServiceClient klient;
        public browsecontact_page()
        {
            klient = new ItelBookServiceClient("WSHttpBinding_ItelBookService");
            //Contactsview.DataContext = klient.getAllContacts();
            InitializeComponent();
        }

        private void Contactsview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //Contact kontakt = (sender as Contact);
            //List<String> result = new List<String>();
            //result.Add(kontakt.FirstName.ToString());
            //result.Add(kontakt.LastName.ToString());
            //result.Add(kontakt.Tel.ToString());
            //result.Add(kontakt.Email.ToString());
            //result.Add(kontakt.Skype.ToString());
            //result.Add(kontakt.Address.ToString());
            //result.Add(kontakt.Muudetud.ToString());
            //result.Add(kontakt.Loodud.ToString());

            //detailview.DataContext = result;
        }
    }
}
