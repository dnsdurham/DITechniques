using DITechniques.ServiceLocator.Shared.DataContracts;
using DITechniques.ServiceLocator.Shared.Interfaces;

namespace DITechniques.ServiceLocator.Accessors
{
    class ProductAccessor : IProductAccessor
    {
        public Product FindByCode(string productCode)
        {
            // simulating a storage layer
            return new Product()
            {
                ProductCode = "B00007E7JU",
                PriceThreshold = 124.99m
            };
        }

        public string GetXPath(string productCode)
        {
            // simulating a service that returns the Xpath query for the
            // price of a specific product code
            return @"//*[@id='actualPriceValue']";
        }
    }
}
