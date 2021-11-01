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


namespace CRUDRentACar.Forms
{
    public partial class LoginUserRole : Form
    {
        ControllerUser control = new ControllerUser();
        public LoginUserRole()
        {
            InitializeComponent();
        }

        private void LoginUserRole_Load(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void operatiiToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
