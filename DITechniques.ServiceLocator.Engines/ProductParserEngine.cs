using System.Net;
using DITechniques.ServiceLocator.Shared.Interfaces;
using HtmlAgilityPack;

namespace DITechniques.ServiceLocator.Engines
{
    class ProductParserEngine : IProductParserEngine
    {
        public decimal GetProductPrice(string productPageContents)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(productPageContents);

            // look for price in the following order...
            // //*[@id="priceblock_ourprice"]
            // //*[@id="priceblock_saleprice"]
            // //*[@id="actualPriceValue"]

            HtmlNode priceNode = doc.DocumentNode.SelectSingleNode(@"//*[@id='priceblock_ourprice']") ??
                                 (doc.DocumentNode.SelectSingleNode(@"//*[@id='priceblock_saleprice']") ??
                                    doc.DocumentNode.SelectSingleNode(@"//*[@id='actualPriceValue']"));

            decimal price = -1.00m;
            if (priceNode != null)
            {
                decimal.TryParse(WebUtility.HtmlDecode(priceNode.InnerText.Trim().Replace("$", "")), out price);
            }

            return price;
        }
    }
}
