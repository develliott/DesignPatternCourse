namespace ProjectOne.VisitorPattern.CodeExample.Core
{
    public interface ISegment
    {
        public void ApplyFilter(IFilterOperation filterOperation);
    }
}