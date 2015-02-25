using DITechniques.Constructor.Managers;
using DITechniques.Constructor.Engines;
using DITechniques.Constructor.Accessors;
using DITechniques.Constructor.Shared.Interfaces;
using Microsoft.Practices.Unity;

namespace DITechniques.Constructor.Client
{
    class ContainerBootstrapper
    {
        /// <summary>
        /// Creates mappings of interfaces to concrete objects
        /// </summary>
        /// <param name="container"></param>
        public static void RegisterTypes(IUnityContainer container)
        {
            ManagerBootstrapper.RegisterTypes(container);
            EngineBootstrapper.RegisterTypes(container);
            AccessorBootstrapper.RegisterTypes(container);

            // The following would require concrete classes be public
            //container.RegisterType<IPriceManager, PriceManager>();
            //container.RegisterType<IProductParserEngine, ProductParserEngine>();
            //container.RegisterType<IWebPageEngine, WebPageEngine>();
            //container.RegisterType<IProductAccessor, ProductAccessor>();
            //container.RegisterType<IEmailAccessor, EmailAccessor>();
        }
    }
}
