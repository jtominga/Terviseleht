using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace telBookService
{
    [DataContract]
    public class Contact
    {
        //[DataMember]
        public AuthData authData;

        #region fields
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _tel;
        private string _email;
        private string _skype;
        private string _address;
        private DateTime _loodud;
        private DateTime _muudetud;
        private DateTime _kustutatud;
        #endregion

        #region properties
        [DataMember]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [DataMember]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        [DataMember]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        [DataMember]
        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }
        [DataMember]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        [DataMember]
        public string Skype
        {
            get { return _skype; }
            set { _skype = value; }
        }
        [DataMember]
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        [DataMember]
        public DateTime Loodud
        {
            get { return _loodud; }
            set { _loodud = value; }
        }
        [DataMember]
        public DateTime Muudetud
        {
            get { return _muudetud; }
            set { _muudetud = value; }
        }
        [DataMember]
        public DateTime Kustutatud
        {
            get { return _kustutatud; }
            set { _kustutatud = value; }
        }
        #endregion

        public Contact() { }

        public Contact(DBA.Baas.Contact cont) 
        {
            this._id = cont.ID;
            this._firstName = cont.Eesnimi;
            this._lastName = cont.Perenimi;
            this._tel = cont.Telefon;
            this._email = cont.E_mail;
            this._skype = cont.Skype;
            this._address = cont.Aadress;
            this.Loodud = cont.Loodud;
            this.Muudetud = cont.Muudetud.GetValueOrDefault();
            this.Kustutatud = cont.Kustutatud.GetValueOrDefault();
        }

        public void save()
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var query = ContactMethods.getContactById(this._id);

                if (query == null)
                {
                    ContactMethods.addContact(this);
                }

                else ContactMethods.updateContact(this);
            }
        }

        public DBA.Baas.Contact mapToDbContact()
        {
            DBA.Baas.Contact kont = new DBA.Baas.Contact();
            kont.ID = this._id;
            kont.Eesnimi = this.FirstName;
            kont.Perenimi = this.LastName;
            kont.Aadress = this.Address;
            kont.E_mail = this.Email;
            kont.Skype = this.Skype;
            kont.Telefon = this.Tel;
            kont.Loodud = this.Loodud;
            kont.Muudetud = this.Muudetud;
            kont.Kustutatud = this.Kustutatud;

            return kont;
        }
    }
}
