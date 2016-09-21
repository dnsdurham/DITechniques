using DITechniques.Constructor.Shared.Interfaces;

namespace DITechniques.Constructor.Accessors
{
    class ProductConfigAccessor : IProductConfigAccessor
    {
        public string GetXPath(string productCode)
        {
            // simulating a service that returns the Xpath query for the
            // price of a specific product code
            return @"//*[@id='priceblock_ourprice']";
        }
    }
}
