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
    /// Interaction logic for searchcontact_page.xaml
    /// </summary>
    public partial class searchcontact_page : Page
    {
        ItelBookServiceClient klient;
        public searchcontact_page()
        {
            InitializeComponent();
            klient = new ItelBookServiceClient("WSHttpBinding_ItelBookService");
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
        //Search_btn
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (radioButtonUsr.IsChecked == true)
            {
                Contactslist.DataContext = klient.getAllContacts();
            }
            else if (radioButtonName.IsChecked == true)
            {
                List<Contact> results = klient.getContactByName(searchValue.Text,10).ToList();
                foreach (Contact res in results) 
                {
                    Contactslist.Items.Add(res.FirstName);
                }
            }
            else if (radioButtonMail.IsChecked == true)
            {
                Contactslist.DataContext = klient.getContactByEmail(searchValue.Text, 10);
            }
            else if (radioButtonTel.IsChecked == true)
            {
                Contactslist.DataContext = klient.getContactBytel(searchValue.Text, 10);
            }
            else if (radioButtonSkype.IsChecked == true)
            {
                Contactslist.DataContext = klient.getContactBySkype(searchValue.Text, 10);
            }
            else 
            {
                Contactslist.DataContext = klient.getAllContacts();
            }
        }

    
    }
}
