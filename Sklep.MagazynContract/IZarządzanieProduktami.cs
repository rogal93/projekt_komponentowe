
namespace Sklep.MagazynContract
{
    public interface IZarządzanieProduktami<T>
    {
        void WynieśZMagazynu(T produkt, short liczba);
        T WyszukajProdukt(string nazwa);
    }
}
