using System;
using System.Collections.Generic;

namespace CurrencyCalculator
{
    public class CurrencyConverter
    {
        public static readonly Dictionary<string, Currency> currencies =
            new Dictionary<string, Currency>()
            {
                {"PLN", new Currency("PLN", "Polski Złoty", 1.0) },
                {"USD", new Currency("USD", "Dolar Amerykański", 3.98) },
                {"EUR", new Currency("EUR", "Euro", 4.30) },
                {"GBP", new Currency("GBP", "Funt Brytyjski", 5.02) },
                {"CHF", new Currency("CHF", "Frank Szwajcarski", 4.55) },
                {"JPY", new Currency("JPY", "Jen Japoński", 0.027) },
            };

        public static double Convert(double amount, string fromCode, string toCode)
        {
            fromCode = fromCode.ToUpper();
            toCode = toCode.ToUpper();

            if (!currencies.ContainsKey(fromCode) || !currencies.ContainsKey(toCode))
            {
                throw new InvalidOperationException("Nie istnieje taka waluta.");
            }

            double fromRate = currencies[fromCode].RateToPLN;
            double toRate = currencies[toCode].RateToPLN;

            double amountInPLN = amount * fromRate; 
            double result = amountInPLN / toRate;

            return result;
        }
    }
}
