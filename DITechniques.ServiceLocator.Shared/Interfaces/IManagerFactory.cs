
namespace DITechniques.ServiceLocator.Shared.Interfaces
{
    public interface IManagerFactory
    {
        T CreateManager<T>() where T : class;
    }
}
