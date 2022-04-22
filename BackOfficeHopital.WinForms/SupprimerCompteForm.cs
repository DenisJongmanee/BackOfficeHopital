using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BackOfficeHopital.Core;

namespace BackOfficeHopital.WinForms
{
    public partial class SupprimerCompteForm : Form
    {
        private Compte compte;
        private Core.Comptes comptes;
        public SupprimerCompteForm(Core.Compte compte, Core.Comptes comptes)
        {
            InitializeComponent();
            this.compte = compte;
            this.comptes = comptes;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            string sURL = $"http://127.0.0.1:5000/api/cs/compte/{compte.IdCompte}";
            WebRequest request = WebRequest.Create(sURL);
            request.Method = "DELETE";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            this.comptes.ListComptes.Remove(this.compte);
            this.Close();
        }
    }
}