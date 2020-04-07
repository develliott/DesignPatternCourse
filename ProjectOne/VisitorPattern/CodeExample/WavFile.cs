using System.Collections.Generic;

namespace ProjectOne.VisitorPattern.CodeExample
{
    public class WavFile
    {
        private readonly List<Segment> _segments = new List<Segment>();

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

        public void ReduceNoise()
        {
            _segments.ForEach(segment => segment.ReduceNoise());
        }

        public void AddReverb()
        {
            _segments.ForEach(segment => segment.AddReverb());

        }

        public void Normalize()
        {
            _segments.ForEach(segment => segment.Normalize());

        }
    }
}