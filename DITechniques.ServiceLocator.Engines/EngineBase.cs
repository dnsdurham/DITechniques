using DITechniques.ServiceLocator.Accessors;
using DITechniques.ServiceLocator.Shared.Interfaces;

namespace DITechniques.ServiceLocator.Engines
{
    class EngineBase
    {
        public IAccessorFactory AccessorFactory { get; set; }

        protected EngineBase()
        {
            AccessorFactory = new AccessorFactory();
        }

    }
}
