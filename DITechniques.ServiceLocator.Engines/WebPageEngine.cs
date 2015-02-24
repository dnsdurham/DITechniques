using System;
using System.Net;
using System.Text;
using DITechniques.ServiceLocator.Shared.Interfaces;

namespace DITechniques.ServiceLocator.Engines
{
    class WebPageEngine : IWebPageEngine
    {
        public string GetWebPageContents(string url)
        {
            // using a web client instead of HttpWebRequest
            // TODO: look into using HttpClient http://www.nuget.org/packages/Microsoft.Net.Http/

            // request the web page
            using (var client = new WebClient())
            {
                // Download data.
                byte[] pageData = client.DownloadData(url);
                // convert to string and remove leading "?"'s
                return Encoding.ASCII.GetString(pageData).TrimStart(new[] { '?' });
            }
        }

        public string BuildUrl(string productCode)
        {
            return string.Format(@"http://www.amazon.com/gp/product/{0}/", productCode);
        }
    }
}
