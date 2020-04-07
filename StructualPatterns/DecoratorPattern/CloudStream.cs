using System;

namespace StructuralPatterns.DecoratorPattern
{
    public class CloudStream
    {
        public virtual void Write(string data)
        {
            Console.WriteLine($"Storing {data}");
        }
    }
}