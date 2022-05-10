using System;

namespace CasaSchimbValutar
{
    [Serializable]
    class ExchangeRate
    {
        public double rate { get; set; }
        public ExchangeRate(){}
        public ExchangeRate(double rate)
        {
            this.rate = rate;
        }
    }
}
