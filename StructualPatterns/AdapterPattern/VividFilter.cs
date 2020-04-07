using System;

namespace StructuralPatterns.AdapterPattern
{
    public class VividFilter : IFilter

    {
        public void Apply(Image image)
        {
            Console.WriteLine("Applying vivid filter.");
        }
    }
}