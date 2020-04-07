using System;

namespace StructuralPatterns.AdapterPattern.ThirdPartyFilters
{
    public class Caramel
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