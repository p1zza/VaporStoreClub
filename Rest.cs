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
        public static List<ProductCategory> categories { get; set; }

        public Rest(string key, string secretkey)
        {
            API = new RestAPI(@"http://armamivape.ru/wp-json/wc/v3", key, secretkey);
            wc = new WCObject(API);
        }

        public async static void UpdateById(int ID,Product product)
        {
            await wc.Product.Update(ID, product);
        }

        public async static Task GetCategoriesAsync()
        {
            if(categories == null)
            {
                categories = new List<ProductCategory>();
                categories = await wc.Category.GetAll();
            }
            else
            {
                categories = await wc.Category.GetAll();
            }
        }

        //private System.Windows.Forms.DataGridViewTextBoxColumn Number_Column;     1
        //private System.Windows.Forms.DataGridViewTextBoxColumn Name_Column;       2
        //private System.Windows.Forms.DataGridViewTextBoxColumn Price_Columnt;     3
        //private System.Windows.Forms.DataGridViewTextBoxColumn AmountStatus;      4
        //private System.Windows.Forms.DataGridViewTextBoxColumn Amount_Column;     5
        //private System.Windows.Forms.DataGridViewTextBoxColumn Category_Column;   6
        //private System.Windows.Forms.DataGridViewButtonColumn ActionButtonColumn; 7

        public static async Task UpdateProductFromDataRow(DataGridViewRow row)
        {
            await Task.Run(() =>
            {
                Product product = products[products.IndexOf(products.Where(o => o.id == Convert.ToInt32(row.Cells[0].Value)).First())];
                product.id = Convert.ToInt32(row.Cells[0].Value);
                product.name = row.Cells[1].Value.ToString();
                product.regular_price = Convert.ToInt32(row.Cells[2].Value);
                product.stock_status = row.Cells[3].Value.ToString();
                product.stock_quantity = Convert.ToInt32(row.Cells[4].Value);
                product.categories.Last().name = row.Cells[5].Value.ToString();
                product.manage_stock = true;
                wc.Product.Update(product.id.Value, product);
            });
        }
        //async static Task<List<Product>> GetProductsAsync()
        //{
        //    for(int i = 0; i<50;i++)
        //    {
        //        try 
        //        {
        //            products.Add(await wc.Product.Get(i));
        //        }
        //        catch(WebException ex)
        //        {
        //            if(ex.Message.Contains("404") == false)
        //            {
        //                MessageBox.Show(Regex.Replace(
        //                ex.Message.ToString(),
        //                @"\\u(?<Value>[a-zA-Z0-9]{4})",
        //                m =>
        //                {
        //                    return ((char)int.Parse(m.Groups["Value"].Value, NumberStyles.HexNumber)).ToString();
        //                }));
        //            }
        //        }   
        //    }
        //    return products; 
        //}

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


