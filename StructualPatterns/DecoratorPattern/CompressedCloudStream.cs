namespace StructuralPatterns.DecoratorPattern
{
    public class CompressedCloudStream : CloudStream
    {
        public override void Write(string data)
        {
            string compressedData = CompressData(data);

            base.Write(compressedData);
        }

        private string CompressData(string data)
        {
            return data.Substring(0, 5);
        }
    }
}