
namespace DITechniques.ServiceLocator.Shared.Interfaces
{
    public interface IWebPageEngine
    {
        string GetWebPageContents(string url);
        string BuildUrl(string productCode);
    }
}
