using Newtonsoft.Json;
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
using WindowsFormsApp1.Forms;
using WooCommerceNET;
using WooCommerceNET.Base;
using WooCommerceNET.WooCommerce.v1;
//using WooCommerceNET.WooCommerce.Legacy;

namespace WindowsFormsApp1
{
    [Serializable]
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void выбратьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(FormIsOpen("ExcelParser"))
            {
                ExcelParser excelParser = new ExcelParser();
                excelParser.Show();
            }
        }

        private void списокТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(FormIsOpen("ParseWindow"))
            {
                ParseWindow parseWindow = new ParseWindow();
                parseWindow.Show();
            }
        }

        private void аккаунтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("AccountInfo"))
            {
                AccountInfo accountInfo = new AccountInfo();
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
                excelParser.Show();
            }
        }
    }
}
