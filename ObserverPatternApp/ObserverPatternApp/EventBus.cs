using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternApp
{
    public class EventBus<T> : ISubject<T>
    {
        private List<IObserver<T>> observers =
            new List<IObserver<T>>();

        public void Subscribe(IObserver<T> observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver<T> observer)
        {
            observers.Remove(observer);
        }

        public void Notify(T data)
        {
            foreach (var observer in observers)
            {
                observer.Update(data);
            }
        }
    }
}
