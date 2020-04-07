using System.Collections.Generic;
using ProjectOne.VisitorPattern.CodeExample.Core;

namespace ProjectOne.VisitorPattern.CodeExample
{
    public class WavFile
    {
        private readonly List<ISegment> _segments = new List<ISegment>();

        public static WavFile Read(string fileName)
        {
            // Simulate reading a wav file and building the segments
            var wavFile = new WavFile();
            wavFile._segments.Add(new FormatSegment());
            wavFile._segments.Add(new FactSegment());
            wavFile._segments.Add(new FactSegment());
            wavFile._segments.Add(new FactSegment());

            return wavFile;
        }

        public void ApplyFilter(IFilterOperation filterOperation)
        {
            _segments.ForEach(segment => segment.ApplyFilter(filterOperation));

        }
    }
}