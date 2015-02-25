using DITechniques.ServiceLocator.Accessors;
using DITechniques.ServiceLocator.Engines;
using DITechniques.ServiceLocator.Shared.Interfaces;

namespace DITechniques.ServiceLocator.Managers
{
    class ManagerBase
    {
        public IEngineLocator EngineLocator { get; set; }
        public IAccessorLocator AccessorLocator { get; set; }

        protected ManagerBase()
        {
            EngineLocator = new EngineLocator();
            AccessorLocator = new AccessorLocator();
        }
    }
}
