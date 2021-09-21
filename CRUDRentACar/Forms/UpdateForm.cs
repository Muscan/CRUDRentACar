using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CRUDRentACar.Controllers;
using static CRUDRentACar.Functions.Functii;

namespace CRUDRentACar.Forms
{
    public partial class UpdateForm : Form
    {
        ControllerMasina controllerMasina = new ControllerMasina();
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(txtBoxUpdateMarca) == false)
            {
                MandatoryField("Marca");

            }
            else
            {
                string message = "";
                if (IsNotEmpty(txtBoxUpdateCombustibil) == true)
                {
                    controllerMasina.UpdateCombustibil(txtBoxUpdateMarca.Text, txtBoxUpdateCombustibil.Text);
                    message += "Combustibil ";
                }
                if (IsNotEmpty(txtBoxUpdateAn) == true)
                {
                    controllerMasina.UpdateAn(txtBoxUpdateMarca.Text, int.Parse(txtBoxUpdateAn.Text));
                    message += "An ";
                }
                if (IsNotEmpty(txtBoxUpdateKM) == true)
                {
                    controllerMasina.UpdateKM(txtBoxUpdateMarca.Text, int.Parse(txtBoxUpdateKM.Text));
                    message += "KM ";
                }
                if (IsNotEmpty(txtBoxUpdatePret) == true)
                {
                    controllerMasina.UpdatePret(txtBoxUpdateMarca.Text, int.Parse(txtBoxUpdatePret.Text));
                    message += "Pret ";
                }
                if (message != "")
                {
                    message += "-Updatate cu succes.";
                    MessageBox.Show(message);
                }
                else
                {
                    MessageBox.Show("Obligatoriu: Combustibil/An/KM/Pret.");
                }
                controllerMasina.saveToFileTxt();
                ClearFields(txtBoxUpdateMarca, txtBoxUpdateCombustibil, txtBoxUpdateAn, txtBoxUpdateKM, txtBoxUpdatePret);
            }
        }
    }
}
