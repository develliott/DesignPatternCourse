using System;
using StructuralPatterns.CompositePattern.Core;

namespace StructuralPatterns.CompositePattern
{
    public class Shape : IComponent
    {
        public void Render()
        {
            Console.WriteLine("Render Shape.");
        }
    }
}