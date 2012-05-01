using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace telBookService.Code.Classes
{
    public static class SContactMethods
    {
        public List<SContact> getSContactsByUser(User user) 
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var results = from x in db.JagatudContacts where x.UserID == user.Id select new SContact(x);

                return results.ToList();
            }
        }

        public static void addSharedContact(SContact scont)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                DBA.Baas.JagatudContact newSharedContact = scont.mapToDbJagatudContact();

                db.JagatudContacts.InsertOnSubmit(newSharedContact);
                db.SubmitChanges();
            }
        }

        public static void deleteSharedContactById(int id) 
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var result = (from x in db.JagatudContacts where x.ID == id select x).FirstOrDefault();
                db.JagatudContacts.DeleteOnSubmit(result);
                db.SubmitChanges();
            }
        }
    }
}
