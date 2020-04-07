using System;

namespace StructuralPatterns.DecoratorPattern.CodeProblem
{
    public class Editor
    {

        public void OpenProject(string path)
        {
            Artefact[] artefacts = {
                new Artefact("Main"),
                new Artefact("Demo"),
                new Artefact("EmailClient"),
                new Artefact("EmailProvider")};
            artefacts[0].SetMain(true);
            artefacts[2].SetHasError(true);
            foreach (var artefact in artefacts)
            {
                Console.WriteLine(artefact.Render());
            }

        }
    }
}