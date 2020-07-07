using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using WindowsFormsApp1.Forms;
using Microsoft.Office.Interop.Excel;
//using System.Windows.Forms;
using WooCommerceNET.WooCommerce.v3;
//using Microsoft.Office.Interop.Word;

namespace WindowsFormsApp1
{
    class Parse
    {
        private string path;
        
        public Parse(string Path)
        {
            path = Path;
        }

        public System.Windows.Forms.DataGridView StartParseExcel(System.Windows.Forms.DataGridView dataGridView)
        {
            Application xlApp = new Application();

            Workbook xlWorkBook = xlApp.Workbooks.Open(path, 
                UpdateLinks: 0, 
                ReadOnly: true, 
                Format: 5,
                Password: "", 
                WriteResPassword: "", 
                IgnoreReadOnlyRecommended: false, 
                Origin: XlPlatform.xlWindows, 
                Delimiter: "", 
                Editable: false, 
                Notify: false, 
                Converter: 0, 
                AddToMru: false, 
                Local: false, 
                CorruptLoad: false); 

            Worksheet xlWorkSheet = xlWorkBook.Worksheets.Item[1];
            Range columnRange = xlWorkSheet.UsedRange;
            int columnsCount  = columnRange.Columns.Count;
            int rowsCount = columnRange.Rows.Count;
            return GetDataFromSheet(xlWorkSheet, rowsCount, columnsCount,dataGridView);
        }

        public System.Windows.Forms.DataGridView GetDataFromSheet(Worksheet sheet, int rowsCount, int columnsCount, System.Windows.Forms.DataGridView dataGridView)
        {
            object[] vs = new object[rowsCount];
            //Range range = sheet.Rows.Item[rows, columns];
            for(int row = 1; row < rowsCount; row++)
            {
                vs[row-1] = sheet.Rows.EntireRow.Item[row].Value();
            } 
                for(int i = 0; i< vs.Length; i++)
            {
                dataGridView.Rows.Add(vs[i]);
            }
            return dataGridView;
        }
    }
}
