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
    /// Interaction logic for addcontact_page.xaml
    /// </summary>
    public partial class addcontact_page : Page
    {
        ItelBookServiceClient klient;
        public addcontact_page()
        {
            InitializeComponent();
            klient = new ItelBookServiceClient("WSHttpBinding_ItelBookService");
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            MainWindow top = (MainWindow)Window.GetWindow(this);
            User adder = top.LoggedUser;

            Contact kontakt = new Contact();

            kontakt.Address = aadress.Text;
            kontakt.Email = email.Text;
            kontakt.FirstName = eesnimi.Text;
            kontakt.LastName = perenimi.Text;
            kontakt.Skype = skype.Text;
            kontakt.Tel = telefon.Text;
            kontakt.Userfk = adder.Id;
            
            klient.saveContact(kontakt);
        }
    }
}
