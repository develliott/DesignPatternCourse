using System;

namespace ProjectOne.VisitorPattern
{
    public class HeadingNode : IHtmlNode
    {
        public void Highlight()
        {
            Console.WriteLine("Highlight Heading");
        }
    }
}