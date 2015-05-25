using Sklep.MagazynContract;

namespace Sklep.MagazynSklepu.Impl
{
    public class Zamówienia : IMenadżerZamówień
    {
        private KatalogProduktów katalog;

        public Zamówienia(KatalogProduktów katalog)
        {
            this.katalog = katalog;
        }
        public void Zamów(Produkt produkt, short liczba)
        {
            produkt.Liczba = produkt.Liczba + liczba;
            katalog.ZaktualizujObiekt(produkt);
        }

        public void EdytujDaneProduktu(Produkt produkt)
        {
            foreach (Produkt item in katalog.ListaProduktów)
            {
                if (produkt.Nazwa == item.Nazwa)
                {
                    katalog.ListaProduktów.Remove(item);
                    katalog.ListaProduktów.Add(produkt);
                    katalog.ZaktualizujObiekt(produkt);
                }
            }
        }

        public void UsuńProdukt(Produkt produkt)
        {
            if (katalog.ListaProduktów.Contains(produkt))
            {
                katalog.ListaProduktów.Remove(produkt);
            }
        }
    }
}
