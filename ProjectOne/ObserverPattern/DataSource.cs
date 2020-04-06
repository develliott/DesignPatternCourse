using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.ObserverPattern
{
    public class DataSource : Subject
    {
        private int _value;
        public int Value
        {
            get => _value;
            set
            {
                if (value == _value) return;
                _value = value;
                NotifyObservers(value);
            }
        }

    }
}
