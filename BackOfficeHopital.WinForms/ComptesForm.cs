﻿using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using BackOfficeHopital.Core;

namespace BackOfficeHopital.WinForms
{
    public partial class Comptes : Form
    {
        private Core.Comptes comptes;
        public Comptes()
        {
            InitializeComponent();
            
            
            string url = "http://127.0.0.1:5000/api/cs/compte";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            WebResponse webResponse = request.GetResponse();

            var webStream = webResponse.GetResponseStream();
            string data = new StreamReader(webStream).ReadToEnd();

            Core.Comptes compte = JsonConvert.DeserializeObject<Core.Comptes>(data);
            this.lbxComptes.DataSource = compte.ListComptes;

            this.comptes = compte;
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
            SupprimerCompte supprimerCompte = new SupprimerCompte((Core.Compte)this.lbxComptes.SelectedItem, this.comptes);
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

        private void lbxComptes_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}