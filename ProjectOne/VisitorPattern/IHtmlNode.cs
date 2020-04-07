namespace ProjectOne.VisitorPattern
{
    public interface IHtmlNode
    {
        void execute(IOperation operation);
    }
}