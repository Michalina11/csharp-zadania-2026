using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternApp
{
    public class EmailNotifier : IObserver<string>
    {
        public void Update(string data)
        {
            Console.WriteLine($"[EMAIL] Otrzymano wiadomość: {data}");
        }
    }
}
