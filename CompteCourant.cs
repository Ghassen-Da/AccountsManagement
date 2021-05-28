using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    class CompteCourant : Compte
    {
        private double Decouvert { get; set; }

        public CompteCourant(string proprietraire, double Decouvert) : base(proprietraire)
        {
            this.Decouvert = Decouvert;
        }

        public override void AfficherHistorique()
        {
            Console.WriteLine("Résumé du compte de " + this.Proprietaire);
            Console.WriteLine("**********************************");
            Console.WriteLine("Compte courant de " + this.Proprietaire);
            Console.WriteLine("           Solde :" + this.Solde);
            Console.WriteLine("           Découvert autorisé: " + this.Decouvert);
            Console.WriteLine();
            Console.WriteLine("Opérations:");
            foreach (double element in this.Historique)
            {
                Console.WriteLine("           " + element);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
