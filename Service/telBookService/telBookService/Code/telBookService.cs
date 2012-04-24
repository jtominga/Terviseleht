using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace telBookService
{
    [DataContract]
    public class Contact
    {
        [DataMember]
        public string submitter;
        [DataMember]
        public string tel;
        [DataMember]
        public string first;
        [DataMember]
        public string last;

        public Contact(DBA.Production.Contact contact) 
        {

        }

    }

    [ServiceContract]
    public interface ItelBookService
    {
        [OperationContract]
        void submitkontakt(Contact kontakt);
        [OperationContract]
        List<Contact> getContacts();
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class telBookService : ItelBookService
    {
        List<Contact> kontaktid = new List<Contact>();

        public void submitkontakt(Contact kontakt)
        {
            kontaktid.Add(kontakt);
        }

        public List<Contact> getContacts()
        {
            return kontaktid;
        }
    }
}
