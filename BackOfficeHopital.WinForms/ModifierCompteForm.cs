using System;
using System.Windows.Forms;

namespace BackOfficeHopital.WinForms
{
    public partial class ModifierCompteForm : Form
    {
        public ModifierCompteForm()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}