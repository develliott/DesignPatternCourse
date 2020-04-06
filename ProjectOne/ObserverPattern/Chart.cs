using System;
using System.Collections.Generic;
using System.Text;
using ProjectOne.ObserverPattern.Core;

namespace ProjectOne.ObserverPattern
{
    public class Chart : IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine($"Chart was updated. New Value: {value}");
        }
    }
}
