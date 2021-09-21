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
    public partial class DataEntry : Form
    {
        ControllerMasina controllerMasina = new ControllerMasina();
        public DataEntry()
        {
            InitializeComponent();
        }
        //marca,combustibil,pret an, kilometraj, stare, numeClient)
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(IsNotEmpty(txtBoxNume) == false)
            {

                 MandatoryField("Nume.");
            }
            else if(IsNotEmpty(txtBoxMarca) == false)
            {
                 MandatoryField("Marca masinii.");
                
            }
            else
            {
                controllerMasina.rentCar(txtBoxNume, txtBoxMarca);
                txtBoxNume.Clear();
                txtBoxMarca.Clear();
            }
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
