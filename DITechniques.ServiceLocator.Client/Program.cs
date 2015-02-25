using System;
using DITechniques.ServiceLocator.Managers;
using DITechniques.ServiceLocator.Shared.Interfaces;

namespace DITechniques.ServiceLocator.Client
{
    class Program
    {
        static void Main()
        {
            // NOTE: in "real" world would likely use a base class for access to the 
            // manager locator similar to ManagerBase
            IManagerLocator managerLocator = new ManagerLocator();
            IPriceManager priceManager = managerLocator.CreateManager<IPriceManager>();
            priceManager.ProcessPriceUpdates("B00007E7JU");

            Console.ReadLine();

        }
    }
}
