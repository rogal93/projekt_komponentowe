
namespace Sklep.MagazynContract
{
    public interface IMenadżerZamówień
    {
        void Zamów(Produkt produkt, short liczba);
        void EdytujDaneProduktu(Produkt produkt);
        void UsuńProdukt(Produkt produkt);
    }
}
