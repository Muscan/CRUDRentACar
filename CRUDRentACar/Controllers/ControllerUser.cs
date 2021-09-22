using CRUDRentACar.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static CRUDRentACar.Controllers.ControllerMasina;

namespace CRUDRentACar.Controllers
{
    class ControllerUser
    {
        private List<User> users;
        public ControllerUser()
            {
            users = new List<User>();
            readUserTxt();
        }
        //Finds the user index
        public int userIndex(string user)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].getUser().Equals(users))
                {
                    return i;
                }
            }
            return -1;
        }

        

        //Save to file
        public void saveToFileUserTxt()
        {
            StreamWriter write = new StreamWriter(@"../../../Files/Users.txt");
            write.WriteLine(this.toStringObjectUserFile());
            write.Close();
        }

        public string toStringObjectUserFile()
        {
            string tot = "";
            for (int i = 0; i < users.Count; i++)
            {
                tot += users[i].toSaveUser() + "\n";

            }
            return tot;
        }

        //update password
        public void UpdatePassword(string nume, string password)
        {
            int index = userIndex(nume);
            if (index != -1)
            {
                
                users[index].setPassword(password);
                
            }
            else
            MessageBox.Show("User not found or pw not changed");
           
        }

        
        //Add user
        public bool Add(User user)
        {
            int index = userIndex(user.getUser());
            if (index == -1)
            {
                this.users.Add(user);
                Console.WriteLine("User added");
                saveToFileUserTxt();
                return true;
            }
            MessageBox.Show("User exists");
            return false;
        }

        //update User, pw and isAdmin
        public bool updateUser(User user)
        {
            int index = userIndex(user.getUser());
            if (index == -1)
            {
                this.users.Add(user);
                saveToFileUserTxt();
                return true;
            }
            return false;

        }
        //update name
        public void updateName(string nume)
        {
            int index = userIndex(nume);
            if (index != -1)
            {
                users[index].setUser(nume);
            }
            else MessageBox.Show("User name not updated");
        }

        //delete
        public void readUserTxt()
        {
            StreamReader read = new StreamReader(@"../../../Files/Users.txt");
            String line = "";
            line = read.ReadLine();

            while (line != "" && line != null)
            {
                string[] formattedUser = line.Split(",");
                string user = formattedUser[0];
                string password = formattedUser[1];
                bool isAdmin = bool.Parse(formattedUser[2]);
                line = read.ReadLine();
                
            }
            read.Close();

        }
        public string toStringFromFile()

        {
            string tot = "";
            for (int i = 0; i < users.Count; i++)
            {
                tot += users[i].toSaveUser() + "\n";
            }
            return tot;
        }
        public bool IsAdmin(String nume)
        {
            

            for(int i = 0; i < users.Count; i++)
            {

                if (users[i].getUser().Equals(nume))
                {
                    MessageBox.Show("Is admin");
                    return users[i].getIsAdmin();
                }
            }

            return false;

        }

        //return the 
        //get name and pw as params TBD

        public User returnUser(string nume, string password)
        {
            for (int i = 0; i < users.Count; i++)
            {

                if (users[i].getUser().Equals(nume) && users[i].getPassword().Equals(password))
                {
                   
                    return users[i];
                }
            }

            return null;

        }

    }
}
