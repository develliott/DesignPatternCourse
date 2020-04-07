using System.Collections.Generic;
using StructuralPatterns.CompositePattern.Core;

namespace StructuralPatterns.CompositePattern
{
    public class Group : IComponent
    {
        private readonly List<IComponent> _components = new List<IComponent>();

        public void Add(IComponent component)
        {
            _components.Add(component);
        }

        public void Render()
        {
            _components.ForEach(component => component.Render());
        }
    }
}