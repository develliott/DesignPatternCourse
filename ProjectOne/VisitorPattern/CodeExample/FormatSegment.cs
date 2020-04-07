using ProjectOne.VisitorPattern.CodeExample.Core;

namespace ProjectOne.VisitorPattern.CodeExample
{
    public class FormatSegment : ISegment
    {
        public void ApplyFilter(IFilterOperation filterOperation)
        {
            filterOperation.ApplyFilter(this);
        }
    }
}