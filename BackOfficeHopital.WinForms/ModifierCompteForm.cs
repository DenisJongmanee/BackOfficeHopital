using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using BackOfficeHopital.Core;
using Newtonsoft.Json;

namespace BackOfficeHopital.WinForms
{
    public partial class ModifierCompteForm : Form
    {
        private Compte compte;
        private Comptes comptes;

        public ModifierCompteForm(Compte compte, Comptes comptes)
        {
            InitializeComponent();
            this.compte = compte;
            this.comptes = comptes;

            // Appel à l'API Liste des roles
            string url = "http://127.0.0.1:5000/api/cs/role";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            WebResponse webResponse = request.GetResponse();

            var webStream = webResponse.GetResponseStream();
            string data = new StreamReader(webStream).ReadToEnd();

            Roles roles = JsonConvert.DeserializeObject<Roles>(data);
            this.comboBoxRole.DataSource = roles.ListRoles;

            // Appel à l'API Liste des services
            string url2 = "http://127.0.0.1:5000/api/cs/service";
            HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create(url2);
            request2.Method = "GET";

            WebResponse webResponse2 = request2.GetResponse();

            var webStream2 = webResponse2.GetResponseStream();
            string data2 = new StreamReader(webStream2).ReadToEnd();
            Services services = JsonConvert.DeserializeObject<Services>(data2);

            this.comboBoxService.DataSource = services.ListServices;


            this.textBoxNom.Text = compte.Nom;
            this.textBoxPrenom.Text = compte.Prenom;

            this.textBoxDateNaissance.Text = compte.DateNaissance;
            this.textBoxMail.Text = compte.AdresseMail;


        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            compte.Nom = this.textBoxNom.Text;
            compte.Prenom = this.textBoxPrenom.Text;
            compte.DateNaissance = this.textBoxDateNaissance.Text;
            compte.AdresseMail = this.textBoxMail.Text;

            Role newRole = (Role)this.comboBoxRole.SelectedItem;
            compte.Role = newRole.IdRole;
            compte.NomRole = newRole.NomRole;

            Service newService = (Service)this.comboBoxService.SelectedItem;
            compte.Service = newService.IdService;
            compte.NomService = newService.NomService;


            string url = "http://127.0.0.1:5000/api/cs/compte";
            var request = WebRequest.Create(url);
            request.Method = "PUT";

         
            var json = JsonConvert.SerializeObject(compte);
            byte[] byteArray = Encoding.UTF8.GetBytes(json);

            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;

            var reqStream = request.GetRequestStream();
            reqStream.Write(byteArray, 0, byteArray.Length);

            var response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            var respStream = response.GetResponseStream();

            var reader = new StreamReader(respStream);
            string data = reader.ReadToEnd();


            this.Close();
        }
    }
}