using StructuralPatterns.AdapterPattern.ThirdPartyFilters;

namespace StructuralPatterns.AdapterPattern
{
    public class CaramelFilter : IFilter
    {
        private Caramel _caramel = new Caramel();

        public void Apply(Image image)
        {
            _caramel.Init();
            _caramel.Render(image);
        }
    }
}