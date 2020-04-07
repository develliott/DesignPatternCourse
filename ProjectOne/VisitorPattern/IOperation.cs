namespace ProjectOne.VisitorPattern
{
    public interface IOperation
    {
        void apply(HeadingNode heading);
        void apply(AnchorNode anchor);

    }
}