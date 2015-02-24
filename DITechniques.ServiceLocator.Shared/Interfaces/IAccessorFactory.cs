
namespace DITechniques.ServiceLocator.Shared.Interfaces
{
    public interface IAccessorFactory
    {
        T CreateAccessor<T>() where T : class;
    }
}
