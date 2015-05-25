using Contract;
using Ninject.Modules;
using ZarządzanieBazą;

namespace Sklep.Infrastructure
{
    class BazaDanychModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPołączenieZBazą>().To<PołączenieZBazą>().InSingletonScope();
        }
    }
}
