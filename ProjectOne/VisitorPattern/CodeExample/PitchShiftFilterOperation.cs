using System;
using ProjectOne.VisitorPattern.CodeExample.Core;

namespace ProjectOne.VisitorPattern.CodeExample
{
    public class PitchShiftFilterOperation : IFilterOperation
    {
        public void ApplyFilter(FactSegment factSegment)
        {
            Console.WriteLine("Pitch Shift - Fact Segment");
        }

        public void ApplyFilter(FormatSegment formatSegment)
        {
            Console.WriteLine("Pitch Shift - Format Segment");

        }
    }
}