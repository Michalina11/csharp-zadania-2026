using System;
using System.Collections.Generic;

namespace CurrencyCalculator
{
    public class Currency
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public double RateToPLN { get; set; }

        public Currency(String code, string name, double ratetoPLN)
        {
            Code = code;
            Name = name;
            RateToPLN = ratetoPLN;
        }
    }
}
