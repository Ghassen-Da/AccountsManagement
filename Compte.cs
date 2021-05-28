using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    class Compte
    {
        protected double Solde { get; set; }
        protected string Proprietaire { get; set; }
        protected List<double> Historique { get; set; }

        public Compte(string proprietaire)
        {
            this.Proprietaire = proprietaire;
            this.Solde = 0;
            this.Historique = new List<double>();
        }

        public virtual void Crediter(double somme)
        {
            this.Solde += somme;
            this.Historique.Add(somme);
        }

        public virtual void Crediter(double somme, Compte c)
        {
            Crediter(somme);
            c.Debiter(somme);
        }

        public void Debiter(double somme)
        {
            this.Solde -= somme;
            this.Historique.Add(-somme);
        }

        public void Debiter(double somme, Compte c)
        {
            Debiter(somme);
            c.Crediter(somme);
        }

        public virtual void AfficherHistorique()
        {
            Console.WriteLine("Résumé du compte de " + this.Proprietaire);
            Console.WriteLine("**********************************");
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
