
namespace DITechniques.Constructor.Shared.Interfaces
{
    public interface IProductParserEngine
    {
        decimal GetProductPrice(string productPageContents, string productCode);
    }
}
