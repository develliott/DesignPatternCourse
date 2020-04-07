namespace StructuralPatterns.DecoratorPattern
{
    public class EncryptedCloudStream : CloudStream
    {
        public override void Write(string data)
        {
            string encryptedData = Encrypt(data);
            base.Write(encryptedData);
        }

        private string Encrypt(string data)
        {
            return "h43#@#%@$%$@";
        }
    }
}