using System;

namespace StructuralPatterns.AdapterPattern.ThirdPartyFilters
{
    public class CaramelFilter
    {
        public void Init()
        {

        }

        public void Render(Image image)
        {
            Console.WriteLine("Third Party - Applying Caramel Filter.");
        }
    }
}