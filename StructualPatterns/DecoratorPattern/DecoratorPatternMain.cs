using System.IO;
using StructuralPatterns.DecoratorPattern.Core;

namespace StructuralPatterns.DecoratorPattern
{
    public class DecoratorPatternMain
    {
        public DecoratorPatternMain()
        {
            StoreCreditCare(new EncryptedCloudStream(new CompressedCloudStream(new CloudStream())));
        }

        public void StoreCreditCare(IStream stream)
        {
            stream.Write("1234-1234-1234-1234");
        }
    }
}