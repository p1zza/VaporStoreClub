using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WooCommerceNET;
using WooCommerceNET.WooCommerce.v3;


namespace WindowsFormsApp1
{
    [DataContract]
    class Rest
    {
        public static RestAPI API { get; set; }
        public static WCObject wc { get; set; }
        public static List<Product> products { get; set; }

        public Rest(string key, string secretkey)
        {
            API = new RestAPI(@"http://armamivape.ru/wp-json/wc/v3", key, secretkey);
            wc = new WCObject(API);
        }

        async static Task<List<Product>> GetProductsAsync()
        {
            for(int i = 0; i<50;i++)
            {
                try 
                {
                    products.Add(await wc.Product.Get(i));
                }
                catch(WebException ex)
                {
                    if(ex.Message.Contains("404") == false)
                    {
                        MessageBox.Show(Regex.Replace(
                        ex.Message.ToString(),
                        @"\\u(?<Value>[a-zA-Z0-9]{4})",
                        m =>
                        {
                            return ((char)int.Parse(m.Groups["Value"].Value, NumberStyles.HexNumber)).ToString();
                        }));
                    }
                }   
            }
            return products; 
        }

        public async static Task<List<Product>> GetAllProducts()
        {
            if (products == null)
            {
                products = new List<Product>();
            }
            else
            {
                return products;
            }
            
            int page = 1, perPage = 20;
            Dictionary<string, string> parameters = new Dictionary<string, string>{{ "per_page", perPage.ToString()}};
            bool hasResults = true;
            while (hasResults)
            {
                parameters["page"] = (page++).ToString();
                var prods = await wc.Product.GetAll(parameters);
                products.AddRange(prods);
                hasResults = prods.Count == perPage;
            }
            return products;
        }
    }
}


