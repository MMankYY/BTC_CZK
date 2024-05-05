using BussinesLogic.Helpers;
using BussinesLogic.Objects;
using BussinesLogic.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace BussinesLogic.Dowlnoaders
{
    public class CoinDeskDowlnoader
    {
        HttpHelper _httpHelper;

        public CoinDeskDowlnoader()
        {
            _httpHelper = new HttpHelper();
        }

        public async Task<BitcoinData> ReadCoindeskData()
        {
            try
            {
                string resp = await _httpHelper.GetHttpRequest(Constants.Constants.COINDESKADDRESS);
                BitcoinData bitcoinData = JsonSerializer.Deserialize<BitcoinData>(resp);
                return bitcoinData;
            }
            catch (Exception)
            {
                // TODO
                throw;
            }
        }
    }
}
