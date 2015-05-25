using Contract;
using System.Collections.Generic;

namespace Sklep.MagazynContract
{
    public class KatalogProduktów
    {
        private List<Produkt> listaProduktów;
        private IPołączenieZBazą połączenie;

        public KatalogProduktów(IPołączenieZBazą połączenie)
        {
            listaProduktów = new List<Produkt>();
            this.połączenie = połączenie;
            PobierzProdukty();
        }

        public List<Produkt> ListaProduktów { get { return listaProduktów; } }

        public void Synchronizuj()
        {
            połączenie.Synchronizuj(listaProduktów.ToArray());
        }

        public List<Produkt> PobierzProdukty()
        {
            return listaProduktów = połączenie.PobierzObiekty<Produkt>();
        }

        public void DodajProdukt(Produkt produkt)
        {
            listaProduktów.Add(produkt);
            połączenie.DodajObiekt(produkt);
        }

        public void ZaktualizujObiekt(Produkt produkt)
        {
            foreach (Produkt item in listaProduktów)
            {
                if (item.Nazwa == produkt.Nazwa)
                {
                    listaProduktów.Remove(item);
                    listaProduktów.Add(produkt);
                    break;
                }
            }
            połączenie.SynchronizujObiekt(produkt);
        }
    }
}
