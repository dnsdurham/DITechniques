using System;
using DITechniques.ServiceLocator.Shared.Interfaces;

namespace DITechniques.ServiceLocator.Engines
{
    public class EngineFactory : IEngineFactory
    {
        public T CreateEngine<T>() where T : class
        {
            if (typeof(T) == typeof(IWebPageEngine))
                return new WebPageEngine() as T;

            if (typeof(T) == typeof(IProductParserEngine))
                return new ProductParserEngine() as T;

            throw new ArgumentException(typeof(T).Name + " is not supported by this factory");
        }
    }
}
