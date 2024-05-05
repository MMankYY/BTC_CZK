using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Helpers
{
    public class HttpHelper
    {
        private HttpClient _httpClient;

        public HttpHelper()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetHttpRequest(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            string resp = await response.Content.ReadAsStringAsync();
            return resp;
        }


    }
}
