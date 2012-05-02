using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace telBookService
{
    [DataContract]
    public class SContact
    {
        //[DataMember]
        public AuthData authData;

        #region fields
        private int _id;
        private int _contactID;
        private int _userID;
        private DateTime _algusKP;
        private DateTime _loppKP;
        #endregion

        #region properties
        [DataMember]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [DataMember]
        public int ContactID
        {
            get { return _contactID; }
            set { _contactID = value; }
        }
        [DataMember]
        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }
        [DataMember]
        public DateTime AlgusKP
        {
            get { return _algusKP; }
            set { _algusKP = value; }
        }
        [DataMember]
        public DateTime LoppKP
        {
            get { return _loppKP; }
            set { _loppKP = value; }
        }
        #endregion

        public SContact() { }

        public SContact(DBA.Baas.JagatudContact scont)
        {
            this._id = scont.ID;
            this._userID = scont.UserID;
            this._contactID = scont.ContactID;
            this._algusKP = scont.AlgusKP;
            this._loppKP = scont.LoppKP.GetValueOrDefault();
        }

        public DBA.Baas.JagatudContact mapToDbJagatudContact()
        {
            DBA.Baas.JagatudContact scont = new DBA.Baas.JagatudContact();
            scont.ID = this._id;
            scont.UserID = this._userID;
            scont.ContactID = this._contactID;
            scont.AlgusKP = this._algusKP;
            scont.LoppKP = this._loppKP;

            return scont;
        }

        public void save()
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var query = (from x in db.JagatudContacts where x.ID == this._id select x).FirstOrDefault();
                if (query == null)
                {
                    SContactMethods.addSharedContact(this);
                }
            }
        }
    }
}