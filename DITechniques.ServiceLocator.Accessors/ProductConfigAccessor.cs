using DITechniques.ServiceLocator.Shared.Interfaces;

namespace DITechniques.ServiceLocator.Accessors
{
    class ProductConfigAccessor : IProductConfigAccessor
    {
        public string GetXPath(string productCode)
        {
            // simulating a service that returns the Xpath query for the
            // price of a specific product code
            return @"//*[@id='actualPriceValue']";
        }
    }
}
