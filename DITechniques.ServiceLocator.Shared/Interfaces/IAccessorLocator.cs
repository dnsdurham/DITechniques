
namespace DITechniques.ServiceLocator.Shared.Interfaces
{
    public interface IAccessorLocator
    {
        T CreateAccessor<T>() where T : class;
    }
}
