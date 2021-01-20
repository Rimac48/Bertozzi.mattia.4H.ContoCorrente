using System;
using Bertozzi.mattia._4H.ContoCorrente.Models;

namespace Bertozzi.mattia._4H.ContoCorrente
{
    class Program
    {
        static void Main(string[] args)
        {

            CC Utente = new CC();

            Console.WriteLine($"Numero conto corrente: {Utente.NumeroCC}");
            Console.WriteLine($"Utente: {Utente.NomeCognome}");
            Console.WriteLine($"Saldo Iniziale: {Utente.SaldoIniziale()}\n");

            Console.WriteLine($"Lista movimenti:\n");

            Utente.Prelievo(49.50,"Ghost of Tsushima");
            Utente.Versamento(1500,"Stipendio!");
            Utente.Prelievo(499.90,"Ps5");
            Utente.Prelievo(2000,"info non disponibili");
            Utente.Prelievo(249.00,"Monitor Odyssey G5");

            Console.WriteLine($"Saldo Finale: {Utente.SaldoFinale()}");

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
