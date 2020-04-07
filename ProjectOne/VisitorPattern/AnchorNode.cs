using System;

namespace ProjectOne.VisitorPattern
{
    public class AnchorNode : IHtmlNode
    {

        public void execute(IOperation operation)
        {
            operation.apply(this);
        }
    }
}