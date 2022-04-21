using System;

namespace BackOfficeHopital.Core
{
    class Vaccin
    {
        public string NomVaccin { get; }
        public int QuantiteeDisponible { get; }

        public Vaccin(string nomVaccin, int quantiteeDisponible)
        {
            this.NomVaccin = nomVaccin;
            this.QuantiteeDisponible = quantiteeDisponible;
        }
    }
}
