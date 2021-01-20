using System;
using System.Collections.Generic;
using System.Text;

namespace Bertozzi.mattia._4H.ContoCorrente.Models
{
    class CC
    {
        private string _nomecognome;
        private double _conto;
        private double _contofinale;
        private string _numeroCC;
        private string _descrizione;

        public CC()
        {
            _nomecognome = "Mattia Bertozzi";
            _conto = 15000;
            _contofinale = _conto;
            _numeroCC = "XA124359825740";
            _descrizione = "";
        }

        public string NomeCognome
        {
            get
            {
                return _nomecognome;
            }
            set
            {
                value = _nomecognome;
            }
        }

        public double Conto
        {
            get
            {
                return _conto;
            }
            set
            {
                value = _conto;
            }
        }

        public double ContoFinale
        {
            get
            {
                return _contofinale;
            }
            set
            {
                value = _contofinale;
            }
        }

        public string NumeroCC
        {
            get
            {
                return _numeroCC;
            }
            set
            {
                value = _numeroCC;
            }
        }

        public string Descrizione
        {
            get
            {
                return _descrizione;
            }
            set
            {
                value = _descrizione;
            }
        }

        //METODI

        //serve a aggiungere soldi al CC
        public string Versamento(double soldi, string info)
        {
            double aggiungisoldi = soldi;
            _contofinale = _contofinale + aggiungisoldi;
            return Movimenti("+", aggiungisoldi, info);

        }

        //serve a toglire soldi al CC
        public string Prelievo(double soldi,string info)
        {
            double rimuovisoldi = soldi;
            _contofinale = _contofinale - rimuovisoldi;
            return Movimenti("-", rimuovisoldi,info);
        }


        public double SaldoIniziale()
        {
            return _conto;
        }

        public double SaldoFinale()
        {
            return _contofinale;
        }


        //serve a vedere i movimento effettuati nel CC
        public string Movimenti(string toglimetti,double soldi,string info)
        {
            //anno,mese,giorno

            int anno = 2021;
            int mese = 01;

            Random rnd = new Random();
            int rdngiorno = rnd.Next(1,32);

            DateTime Data = new DateTime(anno, mese, rdngiorno);
            DateTime onlyData = Data.Date;

            if (toglimetti=="+")
            {
                Console.WriteLine($"\t{onlyData.ToString("d")} \t+ {soldi} euro\t{info}\n");
                return "\n";
                
            }
            else if(toglimetti == "-")
            {
                Console.WriteLine($"\t{onlyData.ToString("d")} \t- {soldi} euro\t{info}\n");
                return "\n";
            }


            return "";
        }
    }
}
