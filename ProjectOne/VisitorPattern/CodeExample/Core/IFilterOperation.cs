namespace ProjectOne.VisitorPattern.CodeExample.Core
{
    public interface IFilterOperation
    {
        public void ApplyFilter(FactSegment factSegment);
        public void ApplyFilter(FormatSegment formatSegment);
    }
}