using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace Czat.Contract
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class CzatService : ICzatService
    {
        private Dictionary<IKomunikacja, string> clientsAndNames = new Dictionary<IKomunikacja, string>();
        public bool Połącz(string imię)
        {
            if (clientsAndNames.ContainsValue(imię))
            {
                return false;
            }
            IKomunikacja clientCallback = OperationContext.Current.GetCallbackChannel<IKomunikacja>();
            clientsAndNames.Add(clientCallback, imię);

            return true;
        }

        public void WyślijWiadomość(string treść, string odbiorca)
        {
            IKomunikacja clientCallback = OperationContext.Current.GetCallbackChannel<IKomunikacja>();
            string imie = clientsAndNames[clientCallback];

            KeyValuePair<IKomunikacja, string>[] copiedNames = clientsAndNames.ToArray();
            foreach (KeyValuePair<IKomunikacja, string> client in copiedNames)
            {
                if (client.Value == odbiorca && client.Key != clientCallback)
                {
                    try
                    {
                        client.Key.WyświetlWiadomość(imie, treść);
                    }
                    catch (Exception)
                    {
                        RozłączKlienta(client.Key);
                    }
                }
            }
        }

        private void RozłączKlienta(IKomunikacja clientCallback)
        {
            string imie = clientsAndNames[clientCallback];
            clientsAndNames.Remove(clientCallback);
        }

        public void Rozłącz()
        {
            IKomunikacja clientCallback = OperationContext.Current.GetCallbackChannel<IKomunikacja>();
            RozłączKlienta(clientCallback);
        }

        public List<string> getImiona()
        {
            return clientsAndNames.Values.ToArray().ToList();
        }
    }
}
