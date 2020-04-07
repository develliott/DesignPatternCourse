using System;
using StructuralPatterns.DecoratorPattern.CodeProblem.Core;
using StructuralPatterns.DecoratorPattern.CodeProblem.Decorators;

namespace StructuralPatterns.DecoratorPattern.CodeProblem
{
    public class Editor
    {

        public void OpenProject(string path)
        {
            IArtefact[] artefacts = {
                new MainDecorator( new Artefact("Main")),
                new Artefact("Demo"),
                new ErrorDecorator(new Artefact("EmailClient")),
                new UncommittedDecorator(new Artefact("EmailProvider"))};
            foreach (var artefact in artefacts)
            {
                Console.WriteLine(artefact.Render());
            }
        }
    }
}