using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using BackOfficeHopital.Core;

namespace BackOfficeHopital.WinForms
{
    public partial class ComptesForm : Form
    {
        private Comptes comptes;
        public ComptesForm()
        {
            InitializeComponent();

            // Appel à l'API Récupération de la liste des comptes (personnels soignants)
            string url = "http://127.0.0.1:5000/api/cs/compte";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            WebResponse webResponse = request.GetResponse();

            var webStream = webResponse.GetResponseStream();
            string data = new StreamReader(webStream).ReadToEnd();
            Console.WriteLine(data);
            Core.Comptes compte = JsonConvert.DeserializeObject<Core.Comptes>(data);
            this.lbxComptes.DataSource = compte.ListComptes;

            this.comptes = compte;
        }
        
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            AjouterCompteForm ajouterCompte = new AjouterCompteForm(this.comptes);
            ajouterCompte.ShowDialog();

            comptes.ListComptes.ResetBindings();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            ModifierCompteForm modifierCompte = new ModifierCompteForm((Compte)this.lbxComptes.SelectedItem, this.comptes);
            modifierCompte.ShowDialog();

            comptes.ListComptes.ResetBindings();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            SupprimerCompteForm supprimerCompte = new SupprimerCompteForm((Compte)this.lbxComptes.SelectedItem, this.comptes);
            supprimerCompte.ShowDialog();
            
            comptes.ListComptes.ResetBindings();
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