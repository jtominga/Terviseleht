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
    }
}
