using System;
using StructuralPatterns.DecoratorPattern.Core;

namespace StructuralPatterns.DecoratorPattern
{
    public class CloudStream : IStream
    {
        public void Write(string data)
        {
            Console.WriteLine($"Storing {data}");
        }
    }
}