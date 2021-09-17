using CRUDRentACar.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRUDRentACar.Forms
{
    public partial class frmStatus : Form
    {
        public frmStatus()
        {
            InitializeComponent();
        }

        ControllerMasina controllerMasina;

        private void frmStatus_Load(object sender, EventArgs e)
        {
            controllerMasina = new ControllerMasina();
            controllerMasina.status(listMasini);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
