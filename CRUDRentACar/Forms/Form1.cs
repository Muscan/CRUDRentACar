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

namespace CRUDRentACar
{
    public partial class frmMain : Form
    {
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
    }
}
