using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Objects
{
    public class DisplayValues
    {
        public decimal BtcEur { get; set; }
        public decimal EurCzk { get; set; }
        public decimal BtcCzk { get; set; }
        public DateTime ValidAt { get; set; }


        public string[] GridViewValues()
        {
            return new string[]
            {
                BtcEur.ToString(),
                EurCzk.ToString(),
                BtcCzk.ToString(),
                ValidAt.ToString()
            };
        }
    }
}
