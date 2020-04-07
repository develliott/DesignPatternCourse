using StructuralPatterns.DecoratorPattern.CodeProblem.Core;

namespace StructuralPatterns.DecoratorPattern.CodeProblem.Decorators
{
    public class UncommittedDecorator : IArtefact
    {
        private readonly IArtefact _artefact;

        public UncommittedDecorator(IArtefact artefact)
        {
            _artefact = artefact;
        }

        public string Render()
        {
            return $"{_artefact.Render()} [Uncommitted]";
        }
    }
}