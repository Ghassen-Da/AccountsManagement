using System;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte CompteCourant = new CompteCourant("Nicolas", 2000);
            CompteCourant.Crediter(500);
            CompteCourant.Debiter(200);
            CompteCourant.Crediter(50);
            CompteCourant.AfficherHistorique();
            Compte CompteEpargne = new CompteEpargne("Nicolas", 0.06);
            CompteCourant.Debiter(100, CompteEpargne);
            CompteEpargne.AfficherHistorique();
        }
    }
}
