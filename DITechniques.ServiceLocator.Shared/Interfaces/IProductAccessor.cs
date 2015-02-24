using DITechniques.ServiceLocator.Shared.DataContracts;

namespace DITechniques.ServiceLocator.Shared.Interfaces
{
    public interface IProductAccessor
    {
        Product FindByCode(string productCode);
        string GetXPath(string productCode);
    }
}
