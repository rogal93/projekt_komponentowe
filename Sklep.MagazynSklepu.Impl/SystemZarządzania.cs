using Sklep.MagazynContract;

namespace Sklep.MagazynSklepu.Impl
{
    public class SystemZarządzania : IZarządzanieProduktami<Produkt>
    {
        private KatalogProduktów katalog;
        
        public SystemZarządzania(KatalogProduktów katalog)
        {
            this.katalog = katalog;
        }
        public void WynieśZMagazynu(Produkt produkt, short liczba)
        {
            if (liczba <= produkt.Liczba)
            {   
                produkt.Liczba = produkt.Liczba - liczba;
                katalog.ZaktualizujObiekt(produkt);
            }
        }

        public Produkt WyszukajProdukt(string nazwa)
        {
            foreach (Produkt item in katalog.ListaProduktów)
            {
                if (nazwa == item.Nazwa)
                {
                    return item;
                }
            }
            return new Produkt();
        }
    }
}
