using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using BackOfficeHopital.Core;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BackOfficeHopital.WinForms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            
            //Appel à l'API Stock Vaccins
            string url = "http://127.0.0.1:5000/api/cs/vaccin";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            WebResponse webResponse = request.GetResponse();

            var webStream = webResponse.GetResponseStream();
            string data = new StreamReader(webStream).ReadToEnd();

            Vaccins vaccins = JsonConvert.DeserializeObject<Vaccins>(data);
            this.lbxStockVaccins.DataSource = vaccins.ListVaccins;
            
            // Appel à l'API Occupation des lits
            string url2 = "http://127.0.0.1:5000/api/cs/lit";
            HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create(url2);
            request2.Method = "GET";

            WebResponse webResponse2 = request2.GetResponse();

            var webStream2 = webResponse2.GetResponseStream();
            string data2 = new StreamReader(webStream2).ReadToEnd();
            Console.WriteLine(data2);
            Lits lits = JsonConvert.DeserializeObject<Lits>(data2);
            this.lbxOccupationLits.DataSource = lits.ListLits;
        }


        private void btnComptesHabilites_Click(object sender, EventArgs e)
        {
            ComptesForm comptes = new ComptesForm();
            comptes.ShowDialog();
        }
    }
}
