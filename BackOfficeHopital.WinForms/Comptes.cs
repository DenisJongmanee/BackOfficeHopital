using System;
using System.Windows.Forms;

namespace BackOfficeHopital.WinForms
{
    public partial class Comptes : Form
    {
        public Comptes()
        {
            InitializeComponent();
        }
        
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            AjouterCompte ajouterCompte = new AjouterCompte();
            ajouterCompte.ShowDialog();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            ModifierCompte modifierCompte = new ModifierCompte();
            modifierCompte.ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            SupprimerCompte supprimerCompte = new SupprimerCompte();
            supprimerCompte.ShowDialog();
        }

        private void lblComptes_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}