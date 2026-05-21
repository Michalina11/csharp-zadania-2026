using System;

namespace ObserverPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EventBus<string> eventBus = new EventBus<string>();

            EmailNotifier email = new EmailNotifier();

            SmsNotifier sms = new SmsNotifier();

            LogNotifier log = new LogNotifier();

            eventBus.Subscribe(email);
            eventBus.Subscribe(sms);
            eventBus.Subscribe(log);

            Console.WriteLine("=== PIERWSZA WIADOMOŚĆ ===");

            eventBus.Notify("Nowe powiadomienie systemowe!");

            Console.WriteLine();

            eventBus.Unsubscribe(sms);

            Console.WriteLine("=== DRUGA WIADOMOŚĆ ===");

            eventBus.Notify("SMS zostal usunięty z subskrypcji.");

            Console.ReadKey();
        }
    }
}
