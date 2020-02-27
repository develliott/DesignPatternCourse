using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.IteratorPattern
{
    public class BrowseHistory
    {
        private string[] _urls = new string[10];
        private int _currentIndex;

        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }

        public void Push(string url)
        {
            _urls[_currentIndex] = url;
            _currentIndex++;
        }

        public string Pop()
        {
            var lastUrl = _urls[_currentIndex];
            _urls[_currentIndex] = null;
            _currentIndex--;
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
                return (_index < _history._urls.Length);
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
