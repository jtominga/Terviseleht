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
        private User usr_help = null;
        private string srch_text_help = null;

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
                usr_help = arg;
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
            srch_text_help = searchValue.Text;
        }

        private void fill(ListBox listbox, List<Contact> list)
        {
            MainWindow top = (MainWindow)Window.GetWindow(this);
            foreach (Contact cont in list)
            {
                //if (cont.Userfk == top.LoggedUser.Id)
                    listbox.Items.Add(cont.FirstName + " " + cont.LastName);
            }
        }

        private void Contactslist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Contact uus = new Contact();
            List<string> result = new List<string>();

            if (Contactslist.SelectedIndex >= 0)
            {

                if (usr_help != null)
                {
                    uus = klient.getContactsByUser(usr_help, 10).ToList().ElementAt(Contactslist.SelectedIndex);
                }
                else if (radioButtonSkype.IsChecked == true)
                {
                    uus = klient.getContactBySkype(srch_text_help, 10).ToList().ElementAt(Contactslist.SelectedIndex);
                }
                else if (radioButtonName.IsChecked == true)
                {
                    uus = klient.getContactByName(srch_text_help, 10).ToList().ElementAt(Contactslist.SelectedIndex);
                }
                else if (radioButtonTel.IsChecked == true)
                {
                    uus = klient.getContactBytel(srch_text_help, 10).ToList().ElementAt(Contactslist.SelectedIndex);
                }
                else if (radioButtonSkype.IsChecked == true)
                {
                    uus = klient.getContactByEmail(srch_text_help, 10).ToList().ElementAt(Contactslist.SelectedIndex);
                }
                else
                {
                    MainWindow top = (MainWindow)Window.GetWindow(this);
                    uus = klient.getContactsByUser(top.LoggedUser, 10).ToList().ElementAt(Contactslist.SelectedIndex);
                }
                
            }
            if (uus != null)
            {
                deatilslist.Items.Clear();
                if (uus.FirstName != null)
                {
                    deatilslist.Items.Add("FirstName: " + uus.FirstName.ToString());
                }
                if (uus.LastName != null)
                {
                    deatilslist.Items.Add("LastName: " + uus.LastName.ToString());
                }
                if (uus.Tel != null)
                {
                 deatilslist.Items.Add("Telefon: " + uus.Tel.ToString());
                }
                if (uus.Email != null)
                {
                    deatilslist.Items.Add("Email: " + uus.Email.ToString());
                }
                if (uus.Skype != null)
                {
                 deatilslist.Items.Add("Skype: " + uus.Skype.ToString());
                }
                 if (uus.Address != null)
                {
                    deatilslist.Items.Add("Adress: " + uus.Address.ToString());
                }
                if (uus.Muudetud != null)
                {
                    deatilslist.Items.Add("Changed: " + uus.Muudetud.ToString());
                }
                if (uus.Loodud != null)
                {
                    deatilslist.Items.Add("Created: " + uus.Loodud.ToString());
                }
                usr_help = null;
            }
        }

    
    }
}
