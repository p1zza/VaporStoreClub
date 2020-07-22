using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ServerWorker
    {
        public async static void PostRequest(string url, string value)
        {
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string> ("key","value")
            };
            HttpContent httpContent = new FormUrlEncodedContent(queries);
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpResponseMessage responseMessage = await httpClient.PostAsync(url, httpContent))
                {
                    using(HttpContent content = responseMessage.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();
                        HttpContentHeaders headers = content.Headers;
                    }
                }
            }
        }

        public async static void GetRequest(string url, string value)
        {
            using (HttpClient client = new HttpClient())
            {
                using(HttpResponseMessage response = await client.GetAsync(url))
                {
                    using(HttpContent content = response.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();
                        HttpContentHeaders headers = content.Headers;
                        //return mycontent;
                    }
                }
            }
        }
    }
}
