using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Remove(IObserver observer);
        void Notify();
    }
}
