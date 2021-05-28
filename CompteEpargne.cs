using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    class CompteEpargne : Compte
    {        
        private double Abondement { get; set; }

        public CompteEpargne(string proprietaire, double Abondement) : base(proprietaire)
        {
            this.Abondement = Abondement;   
        }

        public override void Crediter(double somme)
        {
            this.Solde += somme * (1 + this.Abondement);
            this.Historique.Add(somme);
        }

        public override void Crediter(double somme, Compte c)
        {
            Crediter(somme);
            c.Debiter(somme);
        }

        public override void AfficherHistorique()
        {
            Console.WriteLine("Résumé du compte de " + this.Proprietaire);
            Console.WriteLine("**********************************");
            Console.WriteLine("Compte courant de " + this.Proprietaire);
            Console.WriteLine("           Solde :" + this.Solde);
            Console.WriteLine("           Taux: " + this.Abondement);
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
