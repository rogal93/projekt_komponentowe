using Contract;
using Ninject;
using Ninject.Parameters;
using Sklep.Infrastructure;
using Sklep.UI.Kierownik;
using Sklep.UI.Komunikator;
using Sklep.UI.Logowanie;
using Sklep.UI.Magazynier;
using Sklep.UI.Newsletter;
using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace Sklep.UI.Main
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = Configuration.Container;

            string data = "Server=127.0.0.1;Port=5432;Database=SklepBazaDanych;User Id=postgres; Password=rogal123;";
            string sciezka = @"D:\probny program\Projekt\ZarzadzanieBaza\bazaDanych.conf";

            var czat = container.Get<Sklep.UI.Komunikator.UslugaKomunikatora.ICzatService>
                (new ConstructorArgument("callbackInstance", new InstanceContext(new KomunikatorCallback(new RichTextBox()))));
            
            var news = container.Get<Contract.INewsletterService>();

            var polaczenieZBaza = container.Get<IPołączenieZBazą>(new ConstructorArgument("ścieżkaKonfiguracji", sciezka), 
                new ConstructorArgument("danePołączenia", data));
            
            var uzytkownik = container.Get<IUżytkownik>();
            var adminFunkcje = container.Get<IFunkcjeAdministracyjne>(new ConstructorArgument("połaczenie", polaczenieZBaza));
            var funkcjeUzytkownika = container.Get<IFunkcjeUżytkownika>(new ConstructorArgument("połaczenie", polaczenieZBaza), 
                new ConstructorArgument("wiadomości", news));

            var newsControl = container.Get<NewsletterControl>();
            var czatControl = container.Get<KomunikatorControl>();
            var logControl = container.Get<LogowanieControl>();
            var magazynierControl = container.Get<MagazynierControls>();
            var kierownikControl = container.Get<KierownikControls>();
            var adminControl = container.Get<Admin.AdminControl>();

            Application.Run(new MainWindow(newsControl, czatControl, logControl, 
                magazynierControl, kierownikControl, adminControl));
        }
    }
}
