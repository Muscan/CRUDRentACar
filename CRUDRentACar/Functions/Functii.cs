using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CRUDRentACar.Functions
{
    class Functii
    {
        public static bool IsNotEmpty(TextBox txtBox)
        {
            if (txtBox.Text.Equals("")) return false;
            return true;
        }

        public static void MandatoryField(string field)
        {
            MessageBox.Show("Obligatoriu: " + field);
        }
    }
}
