using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternApp
{
    public interface IObserver<T>
    {
        void Update(T data);
    }
}
