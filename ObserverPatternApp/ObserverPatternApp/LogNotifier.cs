using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternApp
{
    public class LogNotifier : IObserver<string>
    {
        public void Update(string data)
        {
            Console.WriteLine($"[LOG] Zapisano zdarzenie: {data}");
        }
    }
}
