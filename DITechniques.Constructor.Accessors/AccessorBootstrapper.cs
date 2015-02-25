using System;
using DITechniques.Constructor.Shared.Interfaces;
using Microsoft.Practices.Unity;

namespace DITechniques.Constructor.Accessors
{
    public class AccessorBootstrapper
    {
        /// <summary>
        /// Creates mappings of interfaces to concrete accessor objects
        /// </summary>
        /// <param name="container"></param>
        public static void RegisterTypes(IUnityContainer container)
        {
            Console.WriteLine("Accessor types registered");
            container.RegisterType<IProductAccessor, ProductAccessor>();
            container.RegisterType<IProductConfigAccessor, ProductConfigAccessor>();
            container.RegisterType<IEmailAccessor, EmailAccessor>();
        }
    }
}
