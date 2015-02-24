using DITechniques.ServiceLocator.Shared.DataContracts;

namespace DITechniques.ServiceLocator.Shared.Interfaces
{
    public interface IEmailAccessor
    {
        void SendPriceNotice(Product product, decimal newPrice);
    }
}
