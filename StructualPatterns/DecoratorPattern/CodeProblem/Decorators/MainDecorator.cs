using StructuralPatterns.DecoratorPattern.CodeProblem.Core;

namespace StructuralPatterns.DecoratorPattern.CodeProblem.Decorators
{
    public class MainDecorator : IArtefact
    {
        private readonly IArtefact _artefact;

        public MainDecorator(IArtefact artefact)
        {
            _artefact = artefact;
        }

        public string Render()
        {
            return $"{_artefact.Render()} Main";
        }
    }
}
