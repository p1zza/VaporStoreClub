using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WooCommerceNET.WooCommerce.v3;

namespace WindowsFormsApp1
{
    public static class Extensions
    {
       
        public static object GetCellValueFromColumnHeader(this DataGridViewCellCollection CellCollection, string HeaderText)
        {
            return CellCollection.Cast<DataGridViewCell>().First(c => c.OwningColumn.HeaderText == HeaderText).Value;
        }

        public static int ToInt32(this Double DoubleValue)
        {
            return Convert.ToInt32(DoubleValue);
        }
        public static async Task<string> ReadAsStringUTF8Async(this HttpContent content)
        {
            return await content.ReadAsStringAsync(Encoding.UTF8);
        }

        public static async Task<string> ReadAsStringAsync(this HttpContent content, Encoding encoding)
        {
            using (var reader = new StreamReader((await content.ReadAsStreamAsync()), encoding))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
