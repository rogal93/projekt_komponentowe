using Contract;
using KomponentTworzenieUżytkownikow;
using Ninject.Modules;

namespace Sklep.Infrastructure
{
    class UzytkownikModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUżytkownik>().To<KomponentTworzenieUżytkownikow.Użytkownik>().InSingletonScope();

            Bind<IFunkcjeAdministracyjne>().To<FunkcjeAdministracyjne>().InSingletonScope();

            Bind<IFunkcjeUżytkownika>().To<FunkcjeUzytkownika>().InSingletonScope();
        }
    }
}
