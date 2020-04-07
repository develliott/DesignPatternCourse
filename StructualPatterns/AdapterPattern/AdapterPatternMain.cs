using StructuralPatterns.AdapterPattern.ThirdPartyFilters;

namespace StructuralPatterns.AdapterPattern
{
    public class AdapterPatternMain
    {
        // Convert the interface to a different form.
        public AdapterPatternMain()
        {
            var imageView = new ImageView(new Image());

            // This code expects the 'IFilter' interface, but the Third Party Code doesn't conform to the interface.
            imageView.Apply(new CaramelFilter());
        }
    }
}