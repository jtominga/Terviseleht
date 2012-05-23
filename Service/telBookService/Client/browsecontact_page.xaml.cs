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
        private MainWindow top1 = new MainWindow();
        private Contact con_help;
        public browsecontact_page()
        {
            InitializeComponent();
            klient = new ItelBookServiceClient("WSHttpBinding_ItelBookService");
        }

        public void displayContacts(MainWindow top)
        {
            foreach (Contact cont in klient.getContactsByUser(top.LoggedUser, 10).ToList()) 
            {
                if(cont.Kustutatud == null)
                Contactsview.Items.Add(cont.FirstName + " " + cont.LastName);
                else
                Contactsview.Items.Add(cont.FirstName + " " + cont.LastName + " -- > kustutatud");
            }
            top1 = top;
        }

        private void Contactsview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Contact uus = new Contact();
            List<string> result = new List<string>();
            
            if (Contactsview.SelectedIndex >= 0)
            {
                uus = klient.getContactsByUser(top1.LoggedUser, 10).ToList().ElementAt(Contactsview.SelectedIndex);
                con_help = uus;
            }
            if (uus != null)
            {
                detailview.Items.Clear();
                detailview.Items.Add("FirstName: " + uus.FirstName.ToString());
                detailview.Items.Add("LastName: " + uus.LastName.ToString());
                detailview.Items.Add("Telefon: " + uus.Tel.ToString());
                detailview.Items.Add("Email: " + uus.Email.ToString());
                detailview.Items.Add("Skype: " + uus.Skype.ToString());
                detailview.Items.Add("Adress: " + uus.Address.ToString());
                if (uus.Muudetud != null)
                {
                    detailview.Items.Add("Changed: " + uus.Muudetud.ToString());
                }
                detailview.Items.Add("Created: " + uus.Loodud.ToString());

            }

        }

        //Edit button - Ables to chaneg Contact information
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow)
            {
                MainWindow top = (MainWindow)Window.GetWindow(this);
                top.toEditPage(con_help);
            }
        }
        //Delete button - Ables to Delete contact
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            klient.deleteContactById(con_help.Id);

            if (Window.GetWindow(this) is MainWindow)
            {
                MainWindow top = (MainWindow)Window.GetWindow(this);
                top.toBrowsePage();
            }
        
        }
    }
}

            //Contact kontakt = (sender as Contact);

 