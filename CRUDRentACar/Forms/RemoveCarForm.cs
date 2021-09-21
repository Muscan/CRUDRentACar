using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static CRUDRentACar.Functions.Functii;
using CRUDRentACar.Controllers;

namespace CRUDRentACar.Forms
{
    public partial class RemoveCarForm : Form
    {
        ControllerMasina controllerMasina = new ControllerMasina();
        public RemoveCarForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEliminareMarca_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminareMasina_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(txtBoxEliminareMarca) == false)
            {
                MandatoryField("Marca.");
            }
            else
            {
                controllerMasina.Delete(txtBoxEliminareMarca.Text);
                txtBoxEliminareMarca.Clear();
            }
        }
    }
}
