using BussinesLogic.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Helpers
{
    public static class CalculationHelper
    {
        public static decimal CalculateCzkRate(BitcoinData bitcoinData, CnbResp cnbResp)
        {            
            decimal BtcEur = GetRateFromBtcData(bitcoinData);
            decimal EurCzk = GetRateFromCnbData(cnbResp);
            decimal result = BtcEur * EurCzk;

            return result;
        }

        public static DisplayValues GetDisplayValues(BitcoinData bitcoinData, CnbResp cnbResp)
        {
            DisplayValues displayValues = new DisplayValues();
            displayValues.BtcEur = GetRateFromBtcData(bitcoinData);
            displayValues.EurCzk = GetRateFromCnbData(cnbResp);
            displayValues.BtcCzk = CalculateCzkRate(bitcoinData, cnbResp);
            displayValues.ValidAt = GetDateFromBtcData(bitcoinData);

            return displayValues;
        }

        private static decimal GetRateFromBtcData(BitcoinData bitcoinData)
        {
            return bitcoinData.bpi.EUR.rate_float;
        }

        private static DateTime GetDateFromBtcData(BitcoinData bitcoinData)
        {
            // TODO osetrit
            return DateTime.Parse(bitcoinData.time.updatedISO);
        }

        private static decimal GetRateFromCnbData(CnbResp cnbResp)
        {
            return cnbResp.ActValues.FirstOrDefault(a => a.Code == Constants.Constants.EURCODE).Rate;
        }


    }
}
