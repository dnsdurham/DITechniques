using DITechniques.ServiceLocator.Accessors;
using DITechniques.ServiceLocator.Engines;
using DITechniques.ServiceLocator.Shared.Interfaces;

namespace DITechniques.ServiceLocator.Managers
{
    class ManagerBase
    {
        public IEngineFactory EngineFactory { get; set; }
        public IAccessorFactory AccessorFactory { get; set; }

        protected ManagerBase()
        {
            EngineFactory = new EngineFactory();
            AccessorFactory = new AccessorFactory();
        }
    }
}
