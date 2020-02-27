using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.IteratorPattern
{
    class IteratorPatternMain
    {
        public IteratorPatternMain()
        {
            var history = new BrowseHistory();
            history.Push("a");
            history.Push("b");
            history.Push("c");

            IIterator<string> historyIterator = history.CreateIterator();

            while (historyIterator.HasNext())
            {
                Console.WriteLine(historyIterator.Current());
                historyIterator.Next();
            }
        }
    }
}
