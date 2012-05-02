using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace telBookService
{
    public static class ContactMethods
    {
        public static List<Contact> getAllContacts()
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var results = from x in db.Contacts select new Contact(x);

                return results.ToList();
            }
        }

        public static Contact getContactById(int id)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var results = from x in db.Contacts where x.ID == id select new Contact(x);

                return results.ToList().FirstOrDefault();
            }
        }

        public static List<Contact> getContactsByUser(User usr)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var results = from x in db.Contacts where x.ID == usr.Id select new Contact(x);

                return results.ToList();
            }
        }

        public static void addContact(Contact cont)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                DBA.Baas.Contact newContact = cont.mapToDbContact();
                newContact.Loodud = System.DateTime.Now;

                db.Contacts.InsertOnSubmit(newContact);
                db.SubmitChanges();
            }
        }

        public static void deleteContactById(int id)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var query = (from x in db.Contacts where x.ID == id select x).FirstOrDefault();
                if (query != null)
                {
                    query.Kustutatud = DateTime.Now;
                    db.SubmitChanges();
                }
            }
        }

        public static void deleteContactPermanentlyById(int id)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var result = (from x in db.Contacts where x.ID == id select x).FirstOrDefault();
                db.Contacts.DeleteOnSubmit(result);
                db.SubmitChanges();
            }
        }

        public static void updateContact(Contact cont)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var query = (from x in db.Contacts where x.ID == cont.Id select x).FirstOrDefault();
                if (query != null)
                {
                    query = cont.mapToDbContact();
                    query.Muudetud = DateTime.Now;
                    db.SubmitChanges();
                }
            }
        }

        public static Contact getContactByName(string name)
        {
             using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
             {
                 var results = from x in db.Contacts where x.Eesnimi == name select new Contact(x);
                 return results.ToList().FirstOrDefault();
             }
        }

        public static Contact getContactByEmail(string email)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var results = from x in db.Contacts where x.E_mail == email select new Contact(x);
                return results.ToList().FirstOrDefault();
            }
        }

        public static Contact getContactByTel(string tel)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var results = from x in db.Contacts where x.Telefon == tel select new Contact(x);
                return results.ToList().FirstOrDefault();
            }
        }

        public static Contact getContactBySkype(string skype)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var results = from x in db.Contacts where x.Skype == skype select new Contact(x);
                return results.ToList().FirstOrDefault();
            }
        }
    }
}
