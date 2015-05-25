using System.Collections.Generic;
using System.ServiceModel;

namespace Czat.Contract
{
    /// <summary>
    /// Interfejs, który umożliwia połączenie się z serwerem, wysłanie wiadomości do wybranej osoby i rozłączenie się z serwerem.
    /// </summary>
    [ServiceContract(CallbackContract = typeof(IKomunikacja), SessionMode = SessionMode.Allowed)]
    public interface ICzatService
    {
        /// <summary>
        /// Metoda, która łączy klienta z serwerem.
        /// </summary>
        /// <param name="imię">Imię osoby łączącej się z serwerem</param>
        /// <returns></returns>
        [OperationContract]
        bool Połącz(string imię);

        /// <summary>
        /// Metoda, która wysyła wiadomość do wybranej osoby.
        /// </summary>
        /// <param name="treść">Treść wiadomości</param>
        /// <param name="odbiorca">Imię odbiorcy wiadomości</param>
        [OperationContract]
        void WyślijWiadomość(string treść, string odbiorca);

        /// <summary>
        /// Metoda, która rozłącza klienta z serwerem.
        /// </summary>
        [OperationContract]
        void Rozłącz();

        /// <summary>
        /// Metoda zwracająca listę imion użytkowników podłączonych do serwera.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<string> getImiona();
    }
}
