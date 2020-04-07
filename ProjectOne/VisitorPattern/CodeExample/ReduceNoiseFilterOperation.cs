using System;
using ProjectOne.VisitorPattern.CodeExample.Core;

namespace ProjectOne.VisitorPattern.CodeExample
{
    public class ReduceNoiseFilterOperation : IFilterOperation
    {
        public void ApplyFilter(FactSegment factSegment)
        {
            Console.WriteLine("Reduce Noise - Fact Segment");

        }

        public void ApplyFilter(FormatSegment formatSegment)
        {
            Console.WriteLine("Reduce Noise - Format Segment");

        }
    }
}