using Czat.Contract;
using Ninject.Modules;

namespace Sklep.Infrastructure
{
    class KomunikacjaModule : NinjectModule
    {
        public override void Load()
        {
            Bind<Sklep.UI.Komunikator.UslugaKomunikatora.ICzatService>().To<Sklep.UI.Komunikator.UslugaKomunikatora.CzatServiceClient>().InSingletonScope();

            Bind<Contract.INewsletterService>().To<Newsletter.Impl.Newsletter>().InSingletonScope();
        }
    }
}
