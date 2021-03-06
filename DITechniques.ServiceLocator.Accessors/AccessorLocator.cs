﻿using System;
using DITechniques.ServiceLocator.Shared.Interfaces;

namespace DITechniques.ServiceLocator.Accessors
{
    public class AccessorLocator : IAccessorLocator
    {
        public T CreateAccessor<T>() where T : class
        {
            if (typeof(T) == typeof(IProductAccessor))
                return new ProductAccessor() as T;

            if (typeof(T) == typeof(IEmailAccessor))
                return new EmailAccessor() as T;

            if (typeof(T) == typeof(IProductConfigAccessor))
                return new ProductConfigAccessor() as T;

            throw new ArgumentException(typeof(T).Name + " is not supported by this locator");
        }
    }
}
