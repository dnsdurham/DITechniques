
namespace DITechniques.ServiceLocator.Shared.Interfaces
{
    public interface IEngineFactory
    {
        T CreateEngine<T>() where T : class;
    }
}
