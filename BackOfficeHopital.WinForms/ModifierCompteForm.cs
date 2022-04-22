using System;
using System.Windows.Forms;

namespace BackOfficeHopital.WinForms
{
    public partial class ModifierCompte : Form
    {
        public ModifierCompte()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}