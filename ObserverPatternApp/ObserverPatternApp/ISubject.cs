using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternApp
{
    public interface ISubject<T>
    {
        void Subscribe(IObserver<T> observer);
        void Unsubscribe(IObserver<T> observer);
        void Notify(T data);
    }
}
