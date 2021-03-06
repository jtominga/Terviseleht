﻿using System;
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

        public static User getUserByUserName(string name)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var query = from x in db.Users where x.Username == name select new User(x);
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
                DBA.Baas.User newUser = new DBA.Baas.User();
                user.mapToDbUser(newUser);
                newUser.Loodud = System.DateTime.Now;
                newUser.Kustutatud = null;
                newUser.Muudetud = null;
                db.Users.InsertOnSubmit(newUser);
                db.SubmitChanges();
            }
        }

        public static void deleteUserByid(int id)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var query = (from x in db.Users where x.ID == id select x).FirstOrDefault();
                if (query != null)
                {
                    query.Kustutatud = DateTime.Now;
                    db.SubmitChanges();
                }
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

        public static void updateUser(User usr)
        {
            using (DBA.Baas.ProductionDataContext db = new DBA.Baas.ProductionDataContext())
            {
                var query = (from x in db.Users where x.ID == usr.Id select x).FirstOrDefault();
                if (query != null)
                {
                    usr.mapToDbUser(query);
                    query.Muudetud = DateTime.Now;
                    db.SubmitChanges();
                }
            }
        }

        public static User login(string name, string password)
        {
            User usr = getUserByUserName(name);
            if (usr.Password.Equals(password))
            {
                return usr;
            }
            else return null;
        }
    }
}
