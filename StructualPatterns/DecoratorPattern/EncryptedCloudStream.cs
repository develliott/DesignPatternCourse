using StructuralPatterns.DecoratorPattern.Core;

namespace StructuralPatterns.DecoratorPattern
{
    public class EncryptedCloudStream : IStream
    {
        private readonly IStream _cloudStream;

        public EncryptedCloudStream(IStream cloudStream)
        {
            _cloudStream = cloudStream;
        }

        public void Write(string data)
        {
            string encryptedData = Encrypt(data);
            _cloudStream.Write(encryptedData);
        }

        private string Encrypt(string data)
        {
            return "h43#@#%@$%$@";
        }
    }
}