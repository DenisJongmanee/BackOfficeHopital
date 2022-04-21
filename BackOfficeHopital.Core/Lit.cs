using System;

namespace BackOfficeHopital.Core
{
    public class Lit
    {
        public int NumeroLit { get; }
        public int NumeroChambre { get; }
        public bool Occupation { get; }

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

    }    
}
