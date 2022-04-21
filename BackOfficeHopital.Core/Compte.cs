﻿using System;

namespace BackOfficeHopital.Core
{
    class Compte
    {
        public string Nom { get; set;  }
        public string Prenom { get; set; }
        public string DateNaissance { get; set; }
        public string AdresseMail { get; set; }
        public int Role { get; set; }
        public int Service { get; set; }

        protected Compte()
        {
            Console.WriteLine("Compte crée");
        }

        protected Compte(string nom, string prenom, string dateNaissance, string adresseMail, int role, int service)
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