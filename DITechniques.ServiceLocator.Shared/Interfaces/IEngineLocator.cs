
namespace DITechniques.ServiceLocator.Shared.Interfaces
{
    public interface IEngineLocator
    {
        T CreateEngine<T>() where T : class;
    }
}
