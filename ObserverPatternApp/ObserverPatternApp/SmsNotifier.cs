using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternApp
{
    public class SmsNotifier : IObserver<string>
    {
        public void Update(string data)
        {
            Console.WriteLine($"[SMS] Otrzymano wiadomość: {data}");
        }
    }
}
