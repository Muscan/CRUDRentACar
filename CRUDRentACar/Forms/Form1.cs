using CRUDRentACar.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDRentACar.Controllers;
using static CRUDRentACar.Functions.Functii;
using CRUDRentACar.Classes;

namespace CRUDRentACar
{
    public partial class frmMain : Form

    {
        ControllerUser control = new ControllerUser();

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void statusParcAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStatus status = new frmStatus();
            status.Show();
        }

        private void inchiriereMasinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataEntry dataEntry = new DataEntry();
            dataEntry.Show();
        }

        private void returnareMasinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataReturn dataReturn = new DataReturn();
            dataReturn.Show();
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCarForm addCar = new AddCarForm();
            addCar.Show();
        }

        private void eliminareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCarForm removeCarForm = new RemoveCarForm();
            removeCarForm.Show();
        }

        private void editareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void btnPrintAllUsers_Click(object sender, EventArgs e)
        {
           
            control.AfisareUsers(lstUsers);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(txtBoxDeleteUser) == false)
            {
                MandatoryField("User to delete.");
            }
            else
            {
                control.DeleteUser(txtBoxDeleteUser.Text);
                control.AfisareUsers(lstUsers);
                txtBoxDeleteUser.Clear();

            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            btn register = new btn();
            register.Show();
            
            control.AfisareUsers(lstUsers);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(txtBoxEditName) == false)
            {
                MandatoryField("User ");
            }
            else if (IsNotEmpty(txtBoxEditPassword) == false)
            {
                MandatoryField("Password ");
            }
            else
            {
                string editUser = txtBoxEditName.Text;
                string editPassword = txtBoxEditPassword.Text;
                bool isAdmin = checkBoxEditIsAdmin.Checked;

                User usr = new User(editUser, editPassword, isAdmin);

                control.updateUser(usr);
                control.AfisareUsers(lstUsers);
                ClearLoginFields(txtBoxEditName, txtBoxEditPassword);
                checkBoxEditIsAdmin.Checked = false;

                
            }
        }
    }
}
