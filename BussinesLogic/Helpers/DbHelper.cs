using BussinesLogic.DBContext;
using BussinesLogic.Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Helpers
{
    public class DbHelper
    {
        BitcoinDbContext _context;

        public DbHelper()
        {
            _context = new BitcoinDbContext();
        }

        public async Task SaveDisplayValues(List<DisplayValues> displayValues)
        {
            List<BitcoinRate> rates = new List<BitcoinRate>();

            foreach (var item in displayValues)
            {
                BitcoinRate bitcoinRate = new BitcoinRate();
                bitcoinRate.BTC_EUR = item.BtcEur;
                bitcoinRate.CZK_EUR = item.EurCzk;
                bitcoinRate.BTV_CZK = item.BtcCzk;
                bitcoinRate.DownloadedDate = item.ValidAt;
                bitcoinRate.CreateDate = DateTime.Now;
                rates.Add(bitcoinRate);
            }

            _context.BitcoinRates.AddRange(rates);
            await _context.SaveChangesAsync();
        }

        public async Task<List<BitcoinRate>> GetDisplayValues()
        {
            var displayValues = await _context.BitcoinRates.ToListAsync();

            return displayValues;
        }

        public async Task DeleteValues(List<BitcoinRate> ratesToDelete)
        {
           _context.BitcoinRates.RemoveRange(ratesToDelete);
           await _context.SaveChangesAsync();
        }

        public async Task UpdateValues(List<BitcoinRate> ratesToUpdate)
        {
            _context.BitcoinRates.UpdateRange(ratesToUpdate);
            await _context.SaveChangesAsync();
        }

    }
}
