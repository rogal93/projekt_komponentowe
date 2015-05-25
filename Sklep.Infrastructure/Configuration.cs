using Ninject;

namespace Sklep.Infrastructure
{
    public class Configuration
    {
        private static IKernel container;
        public static IKernel Container
        {
            get
            {
                if (container == null)
                    container = ConfigureApp();
                return container;
            }
        }

        private static IKernel ConfigureApp()
        {
            var kernel = new StandardKernel(new KomunikacjaModule(), 
                                            new BazaDanychModule(), 
                                            new UzytkownikModule());

            return kernel;
        }
    }
}
