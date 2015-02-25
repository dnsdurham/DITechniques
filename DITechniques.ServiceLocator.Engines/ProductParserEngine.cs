using System.Net;
using DITechniques.ServiceLocator.Shared.Interfaces;
using HtmlAgilityPack;

namespace DITechniques.ServiceLocator.Engines
{
    class ProductParserEngine : EngineBase, IProductParserEngine
    {
        public decimal GetProductPrice(string productPageContents, string productCode)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(productPageContents);

            // get the correct XPath for the specific product
            IProductConfigAccessor productConfigAccessor = AccessorLocator.CreateAccessor<IProductConfigAccessor>();
            string xpath = productConfigAccessor.GetXPath(productCode);

            HtmlNode priceNode = doc.DocumentNode.SelectSingleNode(xpath);

            decimal price = -1.00m;
            if (priceNode != null)
            {
                decimal.TryParse(WebUtility.HtmlDecode(priceNode.InnerText.Trim().Replace("$", "")), out price);
            }

            return price;
        }
    }
}
