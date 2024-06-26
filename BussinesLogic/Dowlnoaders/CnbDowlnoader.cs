﻿using BussinesLogic.Helpers;
using BussinesLogic.Objects;
using BussinesLogic.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;

namespace BussinesLogic.Dowlnoaders
{
    public class CnbDowlnoader
    {
        HttpHelper _httpHelper;

        public CnbDowlnoader()
        {
            _httpHelper = new HttpHelper();
        }

        public async Task<CnbResp> ReadCnbData()
        {
            string resp = await _httpHelper.GetHttpRequest(Constants.Constants.CNBADDRESS);
            CnbResp cnbData = ParseCnbResp(resp);
            return cnbData;
        }

        private CnbResp ParseCnbResp(string resp)
        {
            CnbResp cnbResp = new CnbResp()
            {
                ActValues = new List<ActValues>()
            };
            string[] lines = resp.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            string[] firstLine = lines[0].Split(" ");

            cnbResp.ValidDate = DateTime.Parse(firstLine[0]);

            for (int i = 2; i < lines.Length; i++)
            {
                string[] row = lines[i].Trim().Split('|');
                ActValues actValues = new ActValues()
                {
                    Country = row[0],
                    Currency = row[1],
                    Quantity = int.Parse(row[2]),
                    Code = row[3],
                    Rate = decimal.Parse(row[4], CultureInfo.GetCultureInfo("cs-cz"))
                };
                cnbResp.ActValues.Add(actValues);
            }
            return cnbResp;
        }
    }
}
