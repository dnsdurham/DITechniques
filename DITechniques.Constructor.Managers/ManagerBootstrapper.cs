using System;
using DITechniques.Constructor.Shared.Interfaces;
using Microsoft.Practices.Unity;

namespace DITechniques.Constructor.Managers
{
    public class ManagerBootstrapper
    {
        /// <summary>
        /// Creates mappings of interfaces to concrete manager objects
        /// </summary>
        /// <param name="container"></param>
        public static void RegisterTypes(IUnityContainer container)
        {
            Console.WriteLine("Manager types registered");
            container.RegisterType<IPriceManager, PriceManager>();
        }
    }
}
