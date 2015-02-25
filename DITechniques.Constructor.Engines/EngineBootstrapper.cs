using System;
using DITechniques.Constructor.Shared.Interfaces;
using Microsoft.Practices.Unity;

namespace DITechniques.Constructor.Engines
{
    public class EngineBootstrapper
    {
        /// <summary>
        /// Creates mappings of interfaces to concrete engine objects
        /// </summary>
        /// <param name="container"></param>
        public static void RegisterTypes(IUnityContainer container)
        {
            Console.WriteLine("Engine types registered");
            container.RegisterType<IProductParserEngine, ProductParserEngine>();
            container.RegisterType<IWebPageEngine, WebPageEngine>();
        }
    }
}
