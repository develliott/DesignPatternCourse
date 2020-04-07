using System.Collections.Generic;

namespace ProjectOne.VisitorPattern
{
    public class HtmlDocument
    {
        private List<IHtmlNode> _htmlNodes = new List<IHtmlNode>();

        public void AddNode(IHtmlNode node)
        {
            _htmlNodes.Add(node);
        }

        public void Execute(IOperation operation)
        {
            _htmlNodes.ForEach(htmlNode => htmlNode.execute(operation));
        }
    }
}