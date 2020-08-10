using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaporStoreClubNamespace.Forms;
using WooCommerceNET;
using WooCommerceNET.Base;
using WooCommerceNET.WooCommerce.v1;
//using WooCommerceNET.WooCommerce.Legacy;

namespace VaporStoreClubNamespace
{
    [Serializable]
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            CryptoWorker cryptoWorker = new CryptoWorker("Hello");
        }
        private void аккаунтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("AccountInfo"))
            {
                AccountInfo accountInfo = new AccountInfo();  
                accountInfo.FormClosed += WinFormClosed;
                accountInfo.Show();
            }
        }
        private bool FormIsOpen(string FormName)
        {
            int flag = 0;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == FormName)
                {
                    flag++;
                }
            }

            if (flag < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void главноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if(!FormIsOpen("MainWindow"))
            //{
            //    MainWindow mainWindow = new MainWindow();
            //    mainWindow.Visible = true;
            //    mainWindow.Show();
            //}
            //else
            //{
            //    this.Close();
            //}
        }

        private void посмотретьТаблицуЭкспортаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("ExcelParser"))
            {
                ExcelParser excelParser = new ExcelParser();
                excelParser.FormClosed += WinFormClosed;
                excelParser.Show();
                
            }
        }

        private void добавитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.FormClosed += WinFormClosed;
            addProduct.Show();
            
        }

        private void списокТоваровToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("ParseWindow"))
            {
                VaporStoreClubNamespace.ParseWindow parseWindow = new VaporStoreClubNamespace.ParseWindow();
                parseWindow.FormClosed += WinFormClosed;
                parseWindow.Show();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void учётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void учётПоставокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(FormIsOpen("ProductOrdersWindow"))
            {
                VaporStoreClubNamespace.Forms.ProductOrdersWindow productOrdersWindow = new ProductOrdersWindow();
                productOrdersWindow.FormClosed += WinFormClosed;
                productOrdersWindow.Show();
            }
        }

        private void учётТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("ProductAccounting"))
            {
                VaporStoreClubNamespace.Forms.ProductAccounting productAccounting = new ProductAccounting();
                productAccounting.Show();
                productAccounting.FormClosed += WinFormClosed;               
            }
        }

        private void WinFormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }
    }
}
