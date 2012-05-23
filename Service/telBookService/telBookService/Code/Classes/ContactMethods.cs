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

        public static List<Contact> getContactsByUser(User usr, int count)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var results = (from x in db.Contacts where x.User_fk == usr.Id orderby x.ID select new Contact(x)).Take(count);

                return results.ToList();
            }
        }

        public static void addContact(Contact cont)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                DBA.Baas.Contact newContact = new DBA.Baas.Contact();
                cont.mapToDbContact(newContact);
                newContact.Loodud = System.DateTime.Now;
                newContact.Muudetud = null;
                newContact.Kustutatud = null;

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
                    cont.mapToDbContact(query);
                    query.Muudetud = DateTime.Now;
                    db.SubmitChanges();
                }
            }
        }

        public static List<Contact> getContactsByName(string name, int count)
        {
             using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
             {
                 var results = (from x in db.Contacts where x.Eesnimi == name orderby x.ID ascending select new Contact(x)).Take(count);
                 return results.ToList();
             }
        }

        public static List<Contact> getContactsByEmail(string email, int count)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var results = (from x in db.Contacts where x.E_mail == email orderby x.ID ascending select new Contact(x)).Take(count);
                return results.ToList();
            }
        }

        public static List<Contact> getContactsByTel(string tel, int count)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var results = (from x in db.Contacts where x.Telefon == tel orderby x.ID ascending select new Contact(x)).Take(count);
                return results.ToList();
            }
        }

        public static List<Contact> getContactsBySkype(string skype, int count)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var results = (from x in db.Contacts where x.Skype == skype orderby x.ID ascending select new Contact(x)).Take(count);
                return results.ToList();
            }
        }
    }
}
