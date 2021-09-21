using CRUDRentACar.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static CRUDRentACar.Functions.Functii;

namespace CRUDRentACar.Forms
{
    public partial class DataReturn : Form
    {
        ControllerMasina controllerMasina = new ControllerMasina();
        public DataReturn()
        {
            InitializeComponent();
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOKreturn_Click(object sender, EventArgs e)
        {

            if (IsNotEmpty(txtBoxNumeReturn) == false)
            {
                MandatoryField("Nume.");
            }
            else if (IsNotEmpty(txtBoxMarcaReturn) == false)
            {
                MandatoryField("Marca masinii.");
            }
            else
            {
                controllerMasina.returnCar(txtBoxMarcaReturn, txtBoxNumeReturn);
                txtBoxMarcaReturn.Clear();
                txtBoxNumeReturn.Clear();
            }
        }

        private void DataReturn_Load(object sender, EventArgs e)
        {

        }
    }
}
