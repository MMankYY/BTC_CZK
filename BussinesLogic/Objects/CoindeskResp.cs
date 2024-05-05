using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Objects
{

    public class BitcoinData
    {
        public Time time { get; set; }
        public string disclaimer { get; set; }
        public string chartName { get; set; }
        public BpiData bpi { get; set; }
    }

    public class Time
    {
        public string updated { get; set; }
        public string updatedISO { get; set; }
        public string updateduk { get; set; }
    }

    public class BpiData
    {
        public CurrencyData USD { get; set; }
        public CurrencyData GBP { get; set; }
        public CurrencyData EUR { get; set; }
    }

    public class CurrencyData
    {
        public string code { get; set; }
        public string symbol { get; set; }
        public string rate { get; set; }
        public string description { get; set; }
        public decimal rate_float { get; set; }
    }
}
