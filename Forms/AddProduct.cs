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
            if(!IsErrorTextBoxes())
            {
                string selectedCategory = CategoryListBox.SelectedItem.ToString();
                Product p = new Product();
                p.name = ProductNameTextBox.Text;
                p.regular_price = Convert.ToInt32(ProductPriceTextBox.Text.ToString());
                p.stock_quantity = Convert.ToInt32(ProductAmountTextBox.Text.ToString());
                p.manage_stock = true;
                ProductCategoryLine productCategoryLine = new ProductCategoryLine();
                productCategoryLine.id = Rest.categories.Where(o => o.name == selectedCategory).First().id;
                productCategoryLine.name = Rest.categories.Where(o => o.name == selectedCategory).First().name;
                productCategoryLine.slug = Rest.categories.Where(o => o.name == selectedCategory).First().slug;
                if (productCategoryLine.id == null || productCategoryLine.name == null || productCategoryLine.slug == null)
                {
                    productCategoryLine.id = 15;
                    productCategoryLine.name = "Uncategorized";
                    productCategoryLine.slug = "uncategorized";
                }
                p.categories = new List<ProductCategoryLine>();
                p.categories.Add(productCategoryLine);
                Rest.wc.Product.Add(p);
            }
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

        private void ClearTextBoxButton_Click(object sender, EventArgs e)
        {
            ProductNameTextBox.Text = "";
            ProductPriceTextBox.Text = "";
            ProductAmountTextBox.Text = "";
            CategoryListBox.SelectedItem = null;
        }

        private bool IsErrorTextBoxes()
        {
            bool error = false;
            try
            {
                if (ProductNameTextBox.Text.Length == 0)
                {
                    error = true;
                    throw new Exception("Вы не указали имя товара");
                }
                if(ProductPriceTextBox.Text.Length == 0)
                {
                    error = true;
                    throw new Exception("Вы не указали цену товара");
                }
                if(ProductAmountTextBox.Text.Length == 0)
                {
                    error = true;
                    throw new Exception("Вы не указали количество товара");
                }
                if(CategoryListBox.SelectedItem == null)
                {
                    error = true;
                    throw new Exception("Вы не выбрали категорию");
                }
               // return error;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            return error;
            
        }
    }
}
