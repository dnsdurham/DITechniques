using System;
using System.Net;
using DITechniques.Constructor.Shared.Interfaces;
using HtmlAgilityPack;

namespace DITechniques.Constructor.Engines
{
    class ProductParserEngine : IProductParserEngine
    {
        private readonly IProductConfigAccessor _productConfigAccessor;

        /// <summary>
        /// Constructor used for dependency injection
        /// </summary>
        public ProductParserEngine(IProductConfigAccessor productConfigAccessor)
        {
            Console.WriteLine("ProductParserEngine constructor called");
            _productConfigAccessor = productConfigAccessor;
        }

        public decimal GetProductPrice(string productPageContents, string productCode)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(productPageContents);

            // get the correct XPath for the specific product
            string xpath = _productConfigAccessor.GetXPath(productCode);

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
