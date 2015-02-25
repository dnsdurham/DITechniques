using DITechniques.Constructor.Shared.DataContracts;

namespace DITechniques.Constructor.Shared.Interfaces
{
    public interface IEmailAccessor
    {
        void SendPriceNotice(Product product, decimal newPrice);
    }
}
