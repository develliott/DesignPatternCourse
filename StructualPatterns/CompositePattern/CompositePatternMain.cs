namespace StructuralPatterns.CompositePattern
{
    public class CompositePatternMain
    {
        public CompositePatternMain()
        {
            var group1 = new Group();
            group1.Add(new Shape()); // Square
            group1.Add(new Shape()); // Square

            var group2 = new Group();
            group2.Add(new Shape()); // Circle
            group2.Add(new Shape()); // Circle

            var group3 = new Group();
            group3.Add(group1);
            group3.Add(group2);

            group3.Render();

        }
    }
}