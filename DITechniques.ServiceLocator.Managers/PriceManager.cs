using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DITechniques.ServiceLocator.Shared.Interfaces;

namespace DITechniques.ServiceLocator.Managers
{
    class PriceManager : ManagerBase, IPriceManager
    {
        public void ProcessPriceUpdates(string productCode)
        {
            // get the necessary dependencies
            IWebPageEngine pageEngine = EngineFactory.CreateEngine<IWebPageEngine>();
            IProductParserEngine priceEngine = EngineFactory.CreateEngine<IProductParserEngine>();
            IProductAccessor productAccessor = AccessorFactory.CreateAccessor<IProductAccessor>();
            IEmailAccessor emailAccessor = AccessorFactory.CreateAccessor<IEmailAccessor>();

            // build the url
            string url = pageEngine.BuildUrl(productCode);
            // get the page contents
            string contents = pageEngine.GetWebPageContents(url);
            // get the stored product information
            var product = productAccessor.FindByCode(productCode);
            // get the current price
            decimal currentPrice = priceEngine.GetProductPrice(contents);
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
