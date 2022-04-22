using System;

namespace BackOfficeHopital.Core
{
    public class Vaccin
    {
        public string NomVaccin { get; set; }
        public int QuantiteeDisponible { get; set; }

        public Vaccin(string nomVaccin, int quantiteeDisponible)
        {
            this.NomVaccin = nomVaccin;
            this.QuantiteeDisponible = quantiteeDisponible;
        }
        public override string ToString()
        {
            return $"{NomVaccin}; Doses disponibles : {QuantiteeDisponible}";
        }
    }
}
