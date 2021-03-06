using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static CRUDRentACar.Functions.Functii;
using CRUDRentACar.Controllers;
using CRUDRentACar.Classes;
namespace CRUDRentACar.Forms
{
    public partial class LoginForm : Form
    {
        private ControllerUser control;
        public LoginForm()
        {
            InitializeComponent();


            this.control = new ControllerUser();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(txtBoxUserName) == false)
            {
                MandatoryField("User.");
            }
            else if(IsNotEmpty(txtBoxPassword) == false)
              {
                MandatoryField("Password.");
              }
            else
            {
                LoginForm loginForm = new LoginForm();

                string name = txtBoxUserName.Text;

                string pass = txtBoxPassword.Text;

                

                User u = control.returnUser(name,pass, checkBoxIsAdmin.Checked);
                
                if (u != null )
                {
                    bool admin = control.isUserAdmin(u);
                    if (admin)
                    {

                        frmMain frmMain = new frmMain();

                        frmMain.Show();
                    }
                    else
                    {

                        LoginUserRole frm = new LoginUserRole();
                        frm.Show();  
                    }
                }
                else
                {
                    MessageBox.Show("Login does not work, user is admin or does not exist");
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void checkBoxIsAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            btn register = new btn();
            if (register.ShowDialog() == DialogResult.OK)
            {
                control.readUserTxt();
            }
        }

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
