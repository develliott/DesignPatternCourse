using StructuralPatterns.AdapterPattern.ThirdPartyFilters;

namespace StructuralPatterns.AdapterPattern
{
    public class AdapterPatternMain
    {
        // Convert the interface to a different form.
        public AdapterPatternMain()
        {
            var imageView = new ImageView(new Image());

            imageView.Apply(new CaramelFilter());
        }
    }
}