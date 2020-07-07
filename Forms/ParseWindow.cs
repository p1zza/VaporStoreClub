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

namespace WindowsFormsApp1
{
    public partial class ParseWindow : MainWindow
    {
        private DateTime DateOfExport = DateTime.Now;
        public ParseWindow()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                Rest r = new Rest(Forms.AccountInfo.consumer_key, Forms.AccountInfo.consumer_secret);
                List<Product> products = new List<Product>();
                Task t = Task.Factory.StartNew(async () =>
                {
                    products = await Rest.GetAllProducts();
                    if(InvokeRequired)
                    {
                        Invoke((Action)(
                            ()=>
                            {
                                InsertData(products);
                                label2.Text = "Найдено товаров" + products.Count + "\nВремя загрузки" + DateOfExport;
                            })); 
                    }
                    else
                    {
                        InsertData(products);
                        label2.Text = "Найдено товаров" + products.Count + "\nВремя загрузки" + DateOfExport;
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void InsertData(List<Product> products)
        {
            try
            {
                foreach (Product p in products)
                {
                    dataGridView1.Rows.Insert(products.IndexOf(p), p.id, p.name, p.regular_price, p.stock_status, p.stock_quantity, p.categories.Last().name);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex==6)
                {
                      Task.Run(async () => { await Rest.UpdateProductFromDataRow(dataGridView1.CurrentRow); }); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
