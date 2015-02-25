using DITechniques.ServiceLocator.Shared.Interfaces;

namespace DITechniques.ServiceLocator.Managers
{
    class PriceManager : ManagerBase, IPriceManager
    {
        public void ProcessPriceUpdates(string productCode)
        {
            // get the necessary dependencies
            IWebPageEngine pageEngine = EngineLocator.CreateEngine<IWebPageEngine>();
            IProductParserEngine priceEngine = EngineLocator.CreateEngine<IProductParserEngine>();
            IProductAccessor productAccessor = AccessorLocator.CreateAccessor<IProductAccessor>();
            IEmailAccessor emailAccessor = AccessorLocator.CreateAccessor<IEmailAccessor>();

            // build the url
            string url = pageEngine.BuildUrl(productCode);
            // get the page contents
            string contents = pageEngine.GetWebPageContents(url);
            // get the stored product information
            var product = productAccessor.FindByCode(productCode);
            // get the current price
            decimal currentPrice = priceEngine.GetProductPrice(contents, productCode);
            // if the current price is different from the price threshold then send an email
            if (currentPrice > 0)
            {
                if (product.PriceThreshold != currentPrice)
                {
                    emailAccessor.SendPriceNotice(product, currentPrice);
                }
            }
        }
    }
}
