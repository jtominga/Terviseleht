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
            Contactslist.Items.Clear();

            if (radioButtonUsr.IsChecked == true)
            {
                User arg = klient.getUserByUserName(searchValue.Text);
                if (arg != null)
                {
                    fill(Contactslist, klient.getContactsByUser(arg, 10).ToList());
                }
            }
            else if (radioButtonName.IsChecked == true)
            {
                fill(Contactslist, klient.getContactByName(searchValue.Text, 10).ToList());
            }
            else if (radioButtonMail.IsChecked == true)
            {
                fill(Contactslist, klient.getContactByEmail(searchValue.Text, 10).ToList());
            }
            else if (radioButtonTel.IsChecked == true)
            {
                fill(Contactslist, klient.getContactBytel(searchValue.Text, 10).ToList());
            }
            else if (radioButtonSkype.IsChecked == true)
            {
                fill(Contactslist, klient.getContactBySkype(searchValue.Text, 10).ToList());
            }
            else 
            {
                MainWindow top = (MainWindow)Window.GetWindow(this);
                fill(Contactslist, klient.getContactsByUser(top.LoggedUser, 10).ToList());
            }
        }

        private void fill(ListBox listbox, List<Contact> list)
        {
            foreach (Contact cont in list)
            {
                listbox.Items.Add(cont.FirstName + " " + cont.LastName);
            }
        }

    
    }
}
