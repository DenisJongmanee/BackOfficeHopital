using System;
using System.Windows.Forms;

namespace BackOfficeHopital.WinForms
{
    public partial class AjouterCompteForm : Form
    {
        public AjouterCompteForm()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}