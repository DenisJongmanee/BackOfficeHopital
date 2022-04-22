using System;

namespace BackOfficeHopital.Core
{
    public class Lit
    {
        public int NumeroLit { get; set; }
        public int NumeroChambre { get; set; }
        public bool Occupation { get; set; }

        public Lit()
        {
            Console.WriteLine("Lit crée");
        }

        public Lit(int numeroLit, int numeroChambre, bool occupation)
        {
            this.NumeroLit = numeroLit;
            this.NumeroChambre = numeroChambre;
            this.Occupation = occupation;
        }

        public override string ToString()
        {
            if (Occupation)
            {
                return $"Lit n°{NumeroLit} occupé chambre {NumeroChambre}";
            }
            else
            {
                return $"Lit n°{NumeroLit} non occupé ";
            }
            
        }
    }    
}
