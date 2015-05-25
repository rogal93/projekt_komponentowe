using System.ServiceModel;

namespace Czat.Contract
{
    /// <summary>
    /// Interfejs umożliwiający przesłanie szczegółów wiadomości do odbiorcy.
    /// </summary>
    public interface IKomunikacja
    {
        /// <summary>
        /// Metoda, która przesyła treść wiadomości wraz z imieniem nadawcy.
        /// </summary>
        /// <param name="nadawca">Imię nadawcy</param>
        /// <param name="treść">Treść wiadomości</param>
        [OperationContract]
        void WyświetlWiadomość(string nadawca, string treść);
    }
}
