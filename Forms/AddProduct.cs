using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WooCommerceNET.WooCommerce.v3;

namespace WindowsFormsApp1.Forms
{
    public partial class AddProduct : MainWindow
    {
        public AddProduct()
        {
            InitializeComponent();
            if (Rest.wc == null)
            {
                Rest r = new Rest(Forms.AccountInfo.consumer_key, Forms.AccountInfo.consumer_secret);
            }
        }
        private void AppendProductButton_Click(object sender, EventArgs e)
        {
            Rest.wc.Product.Add(
            new Product
            {
                name = ProductNameTextBox.Text,
                regular_price = Convert.ToInt32(ProductPriceTextBox.Text.ToString()),
                stock_quantity = Convert.ToInt32(ProductAmountTextBox.Text.ToString()),
                manage_stock = true,
                categories = Rest.categories.IndexOf(CategoryListBox.SelectedItem.ToString())

            }) ;

        }
        private void AddProduct_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Rest.GetCategoriesAsync().Wait();
                if (InvokeRequired)
                {
                    Invoke((Action)(
                        () =>
                        {
                            foreach (var s in Rest.categories)
                            {
                                CategoryListBox.Items.Add(s.name);
                            }
                        }));
                }
                else
                {
                    foreach (var s in Rest.categories)
                    {
                        CategoryListBox.Items.Add(s.name);
                    }
                }
            });
        }
    }
}
