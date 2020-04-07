namespace ProjectOne.VisitorPattern
{
    public class VisitorPatternMain
    {
        public VisitorPatternMain()
        {
            var document = new HtmlDocument();
            document.AddNode(new HeadingNode());
            document.AddNode(new AnchorNode());

            document.Highlight();
        }
    }
}