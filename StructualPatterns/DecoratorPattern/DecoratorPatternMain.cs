namespace StructuralPatterns.DecoratorPattern
{
    public class DecoratorPatternMain
    {
        public DecoratorPatternMain()
        {
            var cloudStream = new CompressedCloudStream();

            cloudStream.Write("Here's some data.");

            // Every time we want new functionality, we have to create new classes to combine them.
            // This is a problem.
        }
    }
}