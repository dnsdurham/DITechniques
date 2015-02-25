using DITechniques.ServiceLocator.Accessors;
using DITechniques.ServiceLocator.Shared.Interfaces;

namespace DITechniques.ServiceLocator.Engines
{
    class EngineBase
    {
        public IAccessorLocator AccessorLocator { get; set; }

        protected EngineBase()
        {
            AccessorLocator = new AccessorLocator();
        }
    }
}
