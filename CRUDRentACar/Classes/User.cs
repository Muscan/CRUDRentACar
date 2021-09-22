﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDRentACar.Classes
{
    class User
    {
        private string user;
        private string password;

        private bool isAdmin;
        public User()
        {
        }

        public User(string user, string password, bool isAdmin)
        {
            this.user = user;
            this.password = password;
            this.isAdmin = true;

        }
        public String getUser()
        {
            return user;
       }
        public String getPassword()
        {
            return password;
        }
        public bool getIsAdmin()
        {
            return isAdmin;
        }

        public void setUser(string user)
        {
            this.user = user;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public void setIsAdmin(bool isAdmin)
        {
            this.isAdmin = isAdmin;
        }
       
        public String toSaveUser()
        {
            return user + "," + password + "," + isAdmin;
        }

        //userDesc
        public string userDesc()
        {
            string userDetails = "";
            return userDetails;
              
        }

        public void afisareUsers()
        {
            
           this.userDesc();
        }

    }
    
}