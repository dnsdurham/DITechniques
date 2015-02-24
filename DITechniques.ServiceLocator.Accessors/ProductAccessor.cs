using System;
using DITechniques.ServiceLocator.Shared.DataContracts;
using DITechniques.ServiceLocator.Shared.Interfaces;

namespace DITechniques.ServiceLocator.Accessors
{
    class ProductAccessor : IProductAccessor
    {
        public Product FindByCode(string productCode)
        {
            throw new NotImplementedException();
        }
    }
}
