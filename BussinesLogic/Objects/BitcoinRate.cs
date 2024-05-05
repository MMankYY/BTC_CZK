using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Objects
{
    public class BitcoinRate
    {
        public int? ID { get; set; }
        public decimal BTC_EUR { get; set; }
        public decimal CZK_EUR { get; set; }
        public decimal BTC_CZK { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DownloadedDate { get; set; }
        public string? Note { get; set; }

        public string[] GridViewValues()
        {
            return new string[]
            {
                ID.ToString(),
                BTC_EUR.ToString(),
                CZK_EUR.ToString(),
                BTC_CZK.ToString(),
                CreateDate.ToString(),
                DownloadedDate.ToString(),
                Note ?? string.Empty 
            };
        }
    }
}
