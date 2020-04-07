using System;

namespace ProjectOne.VisitorPattern
{
    public class PlainTextOperation : IOperation
    {
        public void apply(HeadingNode heading)
        {
            Console.WriteLine("Applied plain text operation to Heading.");
        }

        public void apply(AnchorNode anchor)
        {
            Console.WriteLine("Applied plain text operation to Anchor.");

        }
    }
}