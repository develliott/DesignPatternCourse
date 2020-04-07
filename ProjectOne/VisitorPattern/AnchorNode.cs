using System;

namespace ProjectOne.VisitorPattern
{
    public class AnchorNode : IHtmlNode
    {
        public void Highlight()
        {
            Console.WriteLine("Highlight Anchor");
        }
    }
}