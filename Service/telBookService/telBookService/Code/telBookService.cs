using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace telBookService
{


    [ServiceContract]
    public interface ItelBookService
    {
        [OperationContract]
        List<Contact> getAllContacts();
        [OperationContract]
        void deleteContactPermanentlyById(int id);
        [OperationContract]
        void updateContact(Contact cont);
        [OperationContract]
        List<Contact> getContactsByUser(User usr);
        [OperationContract]
        Contact getContactById(int id);
        [OperationContract]
        Contact getContactByName(string nimi);
        [OperationContract]
        Contact getContactBytel(string tel);
        [OperationContract]
        Contact getContactByEmail(string email);
        [OperationContract]
        Contact getContactBySkype(string skype);
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class telBookService : ItelBookService
    {

        public List<Contact> getAllContacts()
        {
            return ContactMethods.getAllContacts();
        }

        public void deleteContactPermanentlyById(int id)
        {
            ContactMethods.deleteContactPermanentlyById(id);
        }

        public void updateContact(Contact cont)
        {
            ContactMethods.updateContact(cont);
        }

        public List<Contact> getContactsByUser(User usr)
        {
            return ContactMethods.getContactsByUser(usr);
        }

        public Contact getContactById(int id)
        {
            return ContactMethods.getContactById(id);
        }

        public Contact getContactByName(string nimi)
        {
            return ContactMethods.getContactByName(nimi);
        }

        public Contact getContactBytel(string tel)
        {
            return ContactMethods.getContactByTel(tel);
        }

        public Contact getContactByEmail(string email)
        {
            return ContactMethods.getContactByEmail(email);
        }

        public Contact getContactBySkype(string skype)
        {
            return ContactMethods.getContactBySkype(skype);
        }
    }
}