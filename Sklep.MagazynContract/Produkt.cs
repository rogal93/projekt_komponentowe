using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep.MagazynContract
{
    public class Produkt
    {
        #region właściwości

        public int ID { get; set; }
        public string Nazwa { get; set;}
        public decimal Cena { get; set; }
        public int Liczba { get; set; }
        public string Kategoria { get; set; }
        public string TerminPrzydatności { get; set; }

        #endregion

        #region konstruktory
        public Produkt() { }
        public Produkt(int ID, string Nazwa, decimal Cena, int Liczba, string Kategoria, string TerminPrzydatności)
        {
            this.ID = ID;
            this.Nazwa = Nazwa;
            this.Cena = Cena;
            this.Liczba = Liczba;
            this.Kategoria = Kategoria;
            this.TerminPrzydatności = TerminPrzydatności;
        }
        public Produkt(string Nazwa, decimal Cena, int Liczba, string Kategoria, string TerminPrzydatności)
        {
            this.Nazwa = Nazwa;
            this.Cena = Cena;
            this.Liczba = Liczba;
            this.Kategoria = Kategoria;
            this.TerminPrzydatności = TerminPrzydatności;
        }

        #endregion

        public override string ToString()
        {
            return Nazwa;
        }
    }
}
