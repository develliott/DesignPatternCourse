using System;

namespace ProjectOne.VisitorPattern.CodeExample
{
    public class Segment
    {
        public void ReduceNoise()
        {
            Console.WriteLine("Reduce noise");
        }

        public void AddReverb()
        {
            Console.WriteLine("Add reverb");
        }

        public void Normalize()
        {
            Console.WriteLine("Normalize");
        }
    }
}