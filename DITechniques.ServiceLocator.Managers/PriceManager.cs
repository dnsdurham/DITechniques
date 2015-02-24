using System;
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

            // build the url
            string url = pageEngine.BuildUrl(productCode);
            // get the page contents
            string contents = pageEngine.GetWebPageContents(url);
            // get the current price
            decimal currentPrice = priceEngine.GetProductPrice(contents);
        }
    }
}
