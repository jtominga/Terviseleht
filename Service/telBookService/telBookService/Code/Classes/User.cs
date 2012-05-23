using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace telBookService
{
    //[DataContract]
    public class User
    {
        //[DataMember]
        public AuthData authData;

       #region fields
        private int _id;
        private string _username;
        private string _password;
        private string _email;
        private int _role;
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
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        [DataMember]
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        [DataMember]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        [DataMember]
        public int Role
        {
            get { return _role; }
            set { _role = value; }
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

        public User() { }

        public User(DBA.Baas.User usr) 
        {
            this._id = usr.ID;
            this._username = usr.Username;
            this._password = usr.Password;
            this._email = usr.E_mail;
            this._role = usr.Role_fk;
            this.Loodud = usr.Loodud;
            this.Muudetud = usr.Muudetud.GetValueOrDefault();
            this.Kustutatud = usr.Kustutatud.GetValueOrDefault();
        }

        public DBA.Baas.User mapToDbUser()
        {
            DBA.Baas.User user = new DBA.Baas.User();
            user.ID = this._id;
            user.Username = this._username;
            user.Password = this._password;
            user.Role_fk = this._role;
            user.E_mail = this._email;
            user.Loodud = this._loodud;
            user.Muudetud = this._muudetud;
            user.Kustutatud = this._kustutatud;

            return user;
        }

        public void save()
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var query = (from x in db.Users where x.ID == this.Id select x).FirstOrDefault();

                if (query == null)
                {
                    UserMethods.addUser(this);
                }
                else UserMethods.updateUser(this);
            }
        }
    }
}
