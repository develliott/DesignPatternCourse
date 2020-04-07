using StructuralPatterns.DecoratorPattern.Core;

namespace StructuralPatterns.DecoratorPattern
{
    public class CompressedCloudStream : IStream
    {
        private readonly IStream _cloudStream;

        public CompressedCloudStream(IStream cloudStream)
        {
            _cloudStream = cloudStream;
        }

        public void Write(string data)
        {
            string compressedData = CompressData(data);
            _cloudStream.Write(compressedData);
        }

        private string CompressData(string data)
        {
            return data.Substring(0, 5);
        }
    }
}