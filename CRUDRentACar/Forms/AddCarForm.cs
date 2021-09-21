using CRUDRentACar.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static CRUDRentACar.Functions.Functii;
using CRUDRentACar.Classes;
namespace CRUDRentACar.Forms
{
    public partial class AddCarForm : Form
    {
        ControllerMasina controllerMasina = new ControllerMasina();
        Masina masina = new Masina();

        public bool IsNotEmpty { get; private set; }
        public object MandatoryField { get; private set; }

        public AddCarForm()
        {
            InitializeComponent();
        }

        private void AddCarForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelAddCar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCarOK_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(txtBoxAddMarca) == false)
            {
                MandatoryField("Marca");

            }
            else if (IsNotEmpty(txtBoxAddCombustibil) == false)
            {
                MandatoryField("Combustibil ");
            }
            else if (IsNotEmpty(txtBoxAddAn) == false)
            {
                MandatoryField("An ");
            }
            else if (IsNotEmpty(txtBoxAddKm) == false)
            {
                MandatoryField("Km ");
            }
            else if (IsNotEmpty(txtBoxAddPret) == false)
            {
                MandatoryField("Pret ");
            }
            else
            {
                masina.setMarca(txtBoxAddMarca.Text);
                masina.setCombustibil(txtBoxAddCombustibil.Text);
                masina.setAn(int.Parse(txtBoxAddAn.Text));
                masina.setKilometraj(int.Parse(txtBoxAddKm.Text));
                masina.setPret(int.Parse(txtBoxAddPret.Text));
                masina.setStare(true);
                controllerMasina.Add(masina);
                ClearFields(txtBoxAddAn, txtBoxAddCombustibil, txtBoxAddKm, txtBoxAddMarca, txtBoxAddAn);


            }

        }

        private void txtBoxAddPret_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
