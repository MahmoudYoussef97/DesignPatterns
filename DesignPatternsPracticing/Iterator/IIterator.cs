using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.Iterator
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Current();
        void Next();
    }
}
