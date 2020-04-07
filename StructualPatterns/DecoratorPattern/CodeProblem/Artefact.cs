using StructuralPatterns.DecoratorPattern.CodeProblem.Core;

namespace StructuralPatterns.DecoratorPattern.CodeProblem
{
    public class Artefact : IArtefact
    {

        private readonly string _name;

        public Artefact(string name)
        {
            _name = name;
        }

        public string Render()
        {
            return _name;
        }
    }
}
