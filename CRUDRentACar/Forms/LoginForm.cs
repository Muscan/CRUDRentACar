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
        private ControllerUser controll;
        public LoginForm()
        {
            InitializeComponent();


            this.controll = new ControllerUser();
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

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();



            frmMain frm = new frmMain();

            string name = txtBoxUserName.Text;

            string pass = txtBoxPassword.Text;

            bool admin = checkBoxIsAdmin.Checked = false;


            User u = controll.returnUser(name,pass);

            if (u != null)
            {
                frm.Show();
            }
            else
            {
                MessageBox.Show("Login does not work or person does not exist");
            }
            
        }
    }
}
