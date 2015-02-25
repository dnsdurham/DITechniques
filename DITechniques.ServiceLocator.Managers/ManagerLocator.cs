using System;
using DITechniques.ServiceLocator.Shared.Interfaces;

namespace DITechniques.ServiceLocator.Managers
{
    public class ManagerLocator : IManagerLocator
    {
        public T CreateManager<T>() where T : class
        {
            if (typeof(T) == typeof(IPriceManager))
                return new PriceManager() as T;

            throw new ArgumentException(typeof(T).Name + " is not supported by this locator");
        }
    }
}
