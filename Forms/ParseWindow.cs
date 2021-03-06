﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WooCommerceNET.WooCommerce.v3;

namespace VaporStoreClubNamespace
{
    public partial class ParseWindow : MainWindow
    {
        private DateTime DateOfExport = DateTime.Now;
        public ParseWindow()
        {
            InitializeComponent();
        }

        public void LoadDataFromSite()
        {
            try
            {
                Rest r = new Rest(Forms.AccountInfo.RestApiLink, Forms.AccountInfo.consumer_key, Forms.AccountInfo.consumer_secret);
                List<Product> products = new List<Product>();
                Task t = Task.Factory.StartNew(async () =>
                {
                        if(Rest.wc!=null)
                        {
                        products = await Rest.GetAllProducts().ConfigureAwait(true);
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
                    }
                });
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch(Exception ex)
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
                    ParserGridView.Rows.Insert(products.IndexOf(p), p.id, p.name, p.regular_price, p.stock_status, p.stock_quantity, p.categories.Last().name);
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message.ToString() + "\n в параметре" + ex.ParamName);
            }            
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ParserGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex==6)
                {
                      Task.Run(async () => { await Rest.UpdateProductFromDataRow(ParserGridView.CurrentRow).ConfigureAwait(true); }); 
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CultureInfo cultureInfo = new CultureInfo("ru"); 
            for(int i = 0; i<ParserGridView.Rows.Count;i++)
            {
                for(int j = 0; j<ParserGridView.Columns.Count;j++)
                {
                    if (ParserGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(SearchTextBox.Text.ToLower()))
                    {
                        ParserGridView.CurrentCell = ParserGridView.Rows[i].Cells[j];
                    }
                }
            }
        }

        private void GetDataFromMagazine_Button_Click(object sender, EventArgs e) => LoadDataFromSite();

        private void GetDataFromSiteDB_Button_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(@"http://34.69.5.208/get_giv_mi_to_base");
            var s = ServerWorker.GetRequest(uri);
            throw new NotImplementedException(); 
        }

        private void ParseWindow_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ParseWindow_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
