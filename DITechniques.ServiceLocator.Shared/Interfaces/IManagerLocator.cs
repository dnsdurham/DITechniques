
namespace DITechniques.ServiceLocator.Shared.Interfaces
{
    public interface IManagerLocator
    {
        T CreateManager<T>() where T : class;
    }
}
