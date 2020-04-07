using ProjectOne.VisitorPattern.CodeExample;

namespace ProjectOne.VisitorPattern
{
    public class VisitorPatternMain
    {
        public VisitorPatternMain()
        {
            // var document = new HtmlDocument();
            // document.AddNode(new HeadingNode());
            // document.AddNode(new AnchorNode());
            //
            // document.Execute(new PlainTextOperation());
            // document.Execute(new HighlightOperation());

            var wav = WavFile.Read("");

            wav.ApplyFilter(new ReduceNoiseFilterOperation());
            wav.ApplyFilter(new NormaliseFilterOperation());
        }
    }
}