using System;
using ProjectOne.VisitorPattern.CodeExample.Core;

namespace ProjectOne.VisitorPattern.CodeExample
{
    public class NormaliseFilterOperation : IFilterOperation
    {
        public void ApplyFilter(FactSegment factSegment)
        {
            Console.WriteLine("Normalise - Fact Segment.");
        }

        public void ApplyFilter(FormatSegment formatSegment)
        {
            Console.WriteLine("Normalise - Format Segment");
        }
    }
}