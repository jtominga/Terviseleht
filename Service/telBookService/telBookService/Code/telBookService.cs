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
        void deleteContactById(int id);
        [OperationContract]
        void saveContact(Contact cont);
        [OperationContract]
        void saveUser(User usr);
        [OperationContract]
        List<Contact> getContactsByUser(User usr, int count);
        [OperationContract]
        Contact getContactById(int id);
        [OperationContract]
        List<Contact> getContactByName(string nimi, int count);
        [OperationContract]
        List<Contact> getContactBytel(string tel, int count);
        [OperationContract]
        List<Contact> getContactByEmail(string email, int count);
        [OperationContract]
        List<Contact> getContactBySkype(string skype, int count);
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class telBookService : ItelBookService
    {

        public List<Contact> getAllContacts()
        {
            return ContactMethods.getAllContacts();
        }

        public void deleteContactById(int id)
        {
            ContactMethods.deleteContactById(id);
        }

        public void saveContact(Contact cont)
        {
            cont.save();
        }
        public void saveUser(User usr)
        {
            usr.save();
        }
        public List<Contact> getContactsByUser(User usr, int count)
        {
            return ContactMethods.getContactsByUser(usr, count);
        }

        public Contact getContactById(int id)
        {
            return ContactMethods.getContactById(id);
        }

        public List<Contact> getContactByName(string nimi, int count)
        {
            return ContactMethods.getContactsByName(nimi, count);
        }

        public List<Contact> getContactBytel(string tel, int count)
        {
            return ContactMethods.getContactsByTel(tel, count);
        }

        public List<Contact> getContactByEmail(string email, int count)
        {
            return ContactMethods.getContactsByEmail(email, count);
        }

        public List<Contact> getContactBySkype(string skype, int count)
        {
            return ContactMethods.getContactsBySkype(skype, count);
        }
    }
}