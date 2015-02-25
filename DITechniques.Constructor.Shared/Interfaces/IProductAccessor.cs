using DITechniques.Constructor.Shared.DataContracts;

namespace DITechniques.Constructor.Shared.Interfaces
{
    public interface IProductAccessor
    {
        Product FindByCode(string productCode);
        string GetXPath(string productCode);
    }
}
