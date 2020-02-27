using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.IteratorPattern
{
    public class BrowseHistory
    {
        private List<string> _urls = new List<string>();

        public IIterator<string> CreateIterator()
        {
            return  new ListIterator(this);
        }

        public void Push(string url)
        {
            _urls.Add(url);
        }

        public string Pop()
        {
            var lastIndex = _urls.Count - 1;
            var lastUrl = _urls[lastIndex];
            _urls.Remove(lastUrl);
            return lastUrl;
        }

        public class ListIterator : IIterator<string>
        {
            private readonly BrowseHistory _history;
            private int _index;

            public ListIterator(BrowseHistory history)
            {
                _history = history;
            }

            public bool HasNext()
            {
                return (_index < _history._urls.Count);
            }

            public string Current()
            {
                return _history._urls[_index];
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}
