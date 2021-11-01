using CRUDRentACar.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CRUDRentACar.Classes;


using static CRUDRentACar.Functions.Functii;

namespace CRUDRentACar.Forms
{
    public partial class btn : Form//btn = Register :)
    {
        private ControllerUser controlUser;
        public btn()
        {
            InitializeComponent();

            controlUser = new ControllerUser();

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(txtBoxName) == false)
            {
                MandatoryField("Name.");
            }
            else if (IsNotEmpty(txtBoxPassword) == false)
            {
                MandatoryField("password.");
            }
            else
            {
                btn registerForm = new btn();
                frmMain frm = new frmMain();

                string registerUser = txtBoxName.Text;
                string registerPassword = txtBoxPassword.Text;
                bool admin = checkBoxAddIsAdmin.Checked;
                User user = new User(registerUser, registerPassword, admin);
                controlUser.Add(user);
                controlUser.saveToFileUserTxt();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
