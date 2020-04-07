using StructuralPatterns.AdapterPattern.ThirdPartyFilters;

namespace StructuralPatterns.AdapterPattern
{
    public class CaramelAdapter : Caramel, IFilter
    {
        public void Apply(Image image)
        {
            Init();
            Render(image);
        }
    }
}