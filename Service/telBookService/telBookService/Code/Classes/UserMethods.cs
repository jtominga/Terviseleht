using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace telBookService
{
    public static class UserMethods
    {
        public static User getUserById(int id)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var query = from x in db.Users where x.ID == id select new User(x);
                return query.FirstOrDefault();
            }
        }

        public static string getRoleById(int id) 
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var query = from x in db.Roles where x.ID == id select x;
                var role = query.FirstOrDefault();

                if (role != null)
                {
                    return role.Nimetus;
                }
                else return null;
            }
        }

        public static void addUser(User user)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                DBA.Baas.User newUser = user.mapToDbUser();
                newUser.Loodud = System.DateTime.Now;

                db.Users.InsertOnSubmit(newUser);
                db.SubmitChanges();                
            }
        }

        public static void deleteUserPermanentlyById(int id)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var query = (from x in db.Users where x.ID == id select x).FirstOrDefault();
                db.Users.DeleteOnSubmit(query);
                db.SubmitChanges();
            }
        }
    }
}
