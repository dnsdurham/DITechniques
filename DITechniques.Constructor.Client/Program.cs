using System;
using DITechniques.Constructor.Shared.Interfaces;
using Microsoft.Practices.Unity;

namespace DITechniques.Constructor.Client
{
    class Program
    {
        static void Main()
        {
            using (var container = new UnityContainer())
            {
                ContainerBootstrapper.RegisterTypes(container);

                // Resolve the concrete price manager class from 
                // the container registrations
                // This step also resolves the dependencies of
                // price manager and any of their dependencies
                var priceManager = container.Resolve<IPriceManager>();
                priceManager.ProcessPriceUpdates("B00007E7JU");

                Console.ReadLine();
            }
        }
    }
}
