using System;

namespace ProjectOne.VisitorPattern
{
    public class HeadingNode : IHtmlNode
    {

        public void execute(IOperation operation)
        {
            operation.apply(this);
        }
    }
}