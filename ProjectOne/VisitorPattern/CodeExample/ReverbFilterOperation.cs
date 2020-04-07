using System;
using ProjectOne.VisitorPattern.CodeExample.Core;

namespace ProjectOne.VisitorPattern.CodeExample
{
    public class ReverbFilterOperation : IFilterOperation
    {
        public void ApplyFilter(FactSegment factSegment)
        {
            Console.WriteLine("Reverb - Fact Segment");

        }

        public void ApplyFilter(FormatSegment formatSegment)
        {
            Console.WriteLine("Reverb - Format Segment");

        }
    }
}