using System;
using System.Windows.Forms;

namespace BackOfficeHopital.WinForms
{
    public partial class AjouterCompte : Form
    {
        public AjouterCompte()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}