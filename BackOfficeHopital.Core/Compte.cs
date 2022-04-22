using System;

namespace BackOfficeHopital.Core
{
    public class Compte
    {
        public int IdCompte { get; set; }
        public string Nom { get; set;  }
        public string Prenom { get; set; }
        public string DateNaissance { get; set; }
        public string MotDePasse { get; set; }
        public string AdresseMail { get; set; }
        public int Role { get; set; }
        public int Service { get; set; }

        public Compte()
        {
            Console.WriteLine("Compte crée");
        }

        public Compte(string nom, string prenom, string dateNaissance, string adresseMail, int role, int service)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = dateNaissance;
            this.AdresseMail = adresseMail;
            this.Role = role;
            this.Service = service;
        }

        ~Compte()
        {
            Console.WriteLine("Compte détruit");
        }
    }
}
