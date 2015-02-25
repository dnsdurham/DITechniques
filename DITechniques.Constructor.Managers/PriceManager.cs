using System;
using DITechniques.Constructor.Shared.Interfaces;

namespace DITechniques.Constructor.Managers
{
    class PriceManager : IPriceManager
    {
        private readonly IWebPageEngine _pageEngine;
        private readonly IProductParserEngine _priceEngine;
        private readonly IProductAccessor _productAccessor;
        private readonly IEmailAccessor _emailAccessor;

        /// <summary>
        /// Constructor used for dependency injection
        /// </summary>
        public PriceManager(IWebPageEngine pageEngine, 
                            IProductParserEngine priceEngine, 
                            IProductAccessor productAccessor, 
                            IEmailAccessor emailAccessor)
        {
            Console.WriteLine("PriceManager constructor called");
            _emailAccessor = emailAccessor;
            _pageEngine = pageEngine;
            _priceEngine = priceEngine;
            _productAccessor = productAccessor;
        }

        public void ProcessPriceUpdates(string productCode)
        {
            // build the url
            string url = _pageEngine.BuildUrl(productCode);
            // get the page contents
            string contents = _pageEngine.GetWebPageContents(url);
            // get the stored product information
            var product = _productAccessor.FindByCode(productCode);
            // get the current price
            decimal currentPrice = _priceEngine.GetProductPrice(contents, productCode);
            // if the current price is different from the price threshold then send an email
            if (currentPrice > 0)
            {
                if (product.PriceThreshold != currentPrice)
                {
                    _emailAccessor.SendPriceNotice(product, currentPrice);
                }
            }
        }
    }
}
