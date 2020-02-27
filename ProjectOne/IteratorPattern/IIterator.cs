using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.IteratorPattern
{
    public interface IIterator<out T>
    {
        bool HasNext();
        T Current();
        void Next();
    }
}
