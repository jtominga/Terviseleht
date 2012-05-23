using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace telBookService
{
   public class AuthData
    {
        private Boolean isLoggedIn;
        private string userName;
        private string passwordHash;
        private int role;

       public string Username
       {
           get { return userName; }
           set { userName = value; }
       }
       public string Passwordhash
       {
           get { return passwordHash; }
           set { passwordHash = value; }
       }
       public int Role
       {
           get { return role; }
           set { role = value; }
       }
       public Boolean Isloggedin
       {
           get { return isLoggedIn; }
           set { isLoggedIn = value; }
       }
    }
}
