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
                new Artefact("Main"),
                new Artefact("Demo"),
                new Artefact("EmailClient"),
                new Artefact("EmailProvider")};

            artefacts[0] = new MainDecorator(artefacts[0]);
            artefacts[2] = new ErrorDecorator(artefacts[2]);
            artefacts[3] = new ErrorDecorator(new UncommittedDecorator(artefacts[3]));

            foreach (var artefact in artefacts)
            {
                Console.WriteLine(artefact.Render());
            }
        }
    }
}