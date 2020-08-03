﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace VaporStoreClubNamespace
{
    static class ServerWorker
    {
        //string uripath = @"http://34.69.5.208/";
        public async static void PostRequest(Uri uri)
        {
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string> ("key","value")
            };
            
            using (HttpContent httpContent =new FormUrlEncodedContent(queries))
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    using (HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, httpContent).ConfigureAwait(true))
                    {
                        using (HttpContent content = responseMessage.Content)
                        {
                            string mycontent = await content.ReadAsStringAsync().ConfigureAwait(true);
                            HttpContentHeaders headers = content.Headers;
                        }
                    }
                }
            }
        }

        public async static Task<string> GetRequest(Uri uri)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(uri).ConfigureAwait(true))
                {
                    using (HttpContent content = response.Content)
                    {                   
                        return await content.ReadAsStringAsync().ConfigureAwait(true);
                    }
                }
            }
        }
    }
}
