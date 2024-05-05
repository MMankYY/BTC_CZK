using BussinesLogic.Constants;
using BussinesLogic.DBContext;
using BussinesLogic.Dowlnoaders;
using BussinesLogic.Helpers;
using BussinesLogic.Objects;
using Microsoft.EntityFrameworkCore;

namespace BussinesLogicTests
{
    public class General
    {
        [Test]
        public async Task HttpHelper_GetHttpRequest_Google_Test()
        {
            HttpHelper httpHelper = new HttpHelper();
            string resp = await httpHelper.GetHttpRequest("http://google.com");

            Assert.NotNull(resp);
        }

        [Test]
        public async Task HttpHelper_GetHttpRequest_Coindesk_Test()
        {
            HttpHelper httpHelper = new HttpHelper();
            string resp = await httpHelper.GetHttpRequest(Constants.COINDESKADDRESS);

            Assert.NotNull(resp);
        }
        [Test]
        public async Task HttpHelper_GetHttpRequest_CNB_Test()
        {
            HttpHelper httpHelper = new HttpHelper();
            string resp = await httpHelper.GetHttpRequest(Constants.CNBADDRESS);

            Assert.NotNull(resp);
        }
        [Test]
        public async Task HttpHelper_GetHttpRequest_Exception_Test()
        {
            HttpHelper httpHelper = new HttpHelper();
            try
            {
                await httpHelper.GetHttpRequest("");
            }
            catch (Exception ex)
            {
                Assert.Pass();
            }

            Assert.Fail("Exception was expected");
        }

        [Test]
        public async Task CoinDeskDowlnoader_Test()
        {
            CoinDeskDowlnoader coinDeskDowlnoader = new CoinDeskDowlnoader();
            BitcoinData bitcoinData = await coinDeskDowlnoader.ReadCoindeskData();
            Assert.NotNull(bitcoinData);
        }

        [Test]
        public async Task CnbDowlnoader_Test()
        {
            CnbDowlnoader cnbDowlnoader = new CnbDowlnoader();
            CnbResp cnbResp = await cnbDowlnoader.ReadCnbData();
            Assert.NotNull(cnbResp);
        }

        [Test]
        public async Task CalculationHelper_Test()
        {            
            BitcoinData bitcoinData = new BitcoinData()
            {
                bpi = new BpiData() 
                { 
                    EUR = new CurrencyData() 
                    {
                        rate_float = 10,
                    }
                }
            };
            
            CnbResp cnbResp = new CnbResp()
            {
                ActValues = new List<ActValues>()
                {
                    new ActValues() 
                    {
                        Code = Constants.EURCODE,
                        Rate = 100,
                    }
                }
            };

            var result = CalculationHelper.CalculateCzkRate(bitcoinData, cnbResp);
            Assert.True(result == 1000);
        }

        [Test]
        public async Task DbContext_Test()
        {
            var context = new BitcoinDbContext();

            var virRates = await context.BitcoinRates.ToListAsync();
        }

        [Test]
        public async Task CalculationHelper_GetDisplayValues_Test()
        {
            BitcoinData bitcoinData = new BitcoinData()
            {
                bpi = new BpiData()
                {
                    EUR = new CurrencyData()
                    {
                        rate_float = 10,
                    }
                },
                time = new Time()
                {
                    updatedISO = "2024-05-03T15:36:48+00:00"
                }
            };

            CnbResp cnbResp = new CnbResp()
            {
                ActValues = new List<ActValues>()
                {
                    new ActValues()
                    {
                        Code = Constants.EURCODE,
                        Rate = 100,
                    }
                }
            };
            var result = CalculationHelper.GetDisplayValues(bitcoinData, cnbResp);

            Assert.NotNull(result);
        }
    }
}