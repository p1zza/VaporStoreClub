﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class ExcelParser : MainWindow
    {
        public ExcelParser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            label2.Text += openFileDialog1.FileName;
            GetDataFromExcel(openFileDialog1.FileName);        
        }

        private void GetDataFromExcel(string path)
        {
            Parse parser = new Parse(path);
            parser.StartParseExcel();
        }
    }
}
