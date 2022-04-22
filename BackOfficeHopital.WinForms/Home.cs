using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOfficeHopital.WinForms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void lbxOccupationLits_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void lbxStockVaccins_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnComptesHabilites_Click(object sender, EventArgs e)
        {
            Comptes comptes = new Comptes();
            comptes.ShowDialog();
        }

        private void lblOccupationLits_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void lblStocksVaccins_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
