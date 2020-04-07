using System;

namespace ProjectOne.VisitorPattern
{
    public class HighlightOperation : IOperation
    {
        public void apply(HeadingNode heading)
        {
            Console.WriteLine("Applied highlight to Heading node.");
        }

        public void apply(AnchorNode anchor)
        {
            Console.WriteLine("Applied highlight to Anchor node.");

        }
    }
}