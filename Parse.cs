using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using WindowsFormsApp1.Forms;
using Microsoft.Office.Interop.Excel;
using WooCommerceNET.WooCommerce.v3;


namespace WindowsFormsApp1
{
    class Parse
    {
        private string path;
        private static Application xlApp;
        private static Workbook xlWorkBook;
        private static Worksheet xlWorkSheet;

        public Parse(string Path)
        {
            path = Path;
        }

        public static void CloseExcel()
        {
            if(xlWorkBook != null)
            {
                xlWorkBook.Close(false);
            }
            if(xlApp !=null)
            {
                xlApp.Quit();
            } 
        }

        public System.Windows.Forms.DataGridView StartParseExcel(System.Windows.Forms.DataGridView dataGridView,string pattern)
        {
            try
            {
                xlApp = new Application();
                xlWorkBook = xlApp.Workbooks.Open(path, 
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

                xlWorkSheet = xlWorkBook.Worksheets.Item[1];
            
                Range columnRange = xlWorkSheet.UsedRange;
                int columnsCount  = columnRange.Columns.Count;
                int rowsCount = columnRange.Rows.Count;
                return GetDataFromSheet(xlWorkSheet, rowsCount, columnsCount, dataGridView,pattern);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
            }
            return null;
        }

        public System.Windows.Forms.DataGridView GetDataFromSheet(Worksheet sheet, int rowsCount, int columnsCount, System.Windows.Forms.DataGridView dataGridView, string pattern)
        {
            try
            {
                int iLastRow = sheet.Cells[sheet.Rows.Count, "A"].End[Microsoft.Office.Interop.Excel.XlDirection.xlUp].Row;  //последняя заполненная строка в столбце А            
                var arrData = (object[,])sheet.Range[pattern + iLastRow].Value; //берём данные с листа Excel

                //настройка DataGridView
                dataGridView.Rows.Clear();
                int RowsCount = arrData.GetUpperBound(0);
                int ColumnsCount = arrData.GetUpperBound(1);
                dataGridView.RowCount = RowsCount; //кол-во строк в DGV
                dataGridView.ColumnCount = ColumnsCount; //кол-во столбцов в DGV

                //заполняем DataGridView данными из массива
                int i, j;
                for (i = 1; i <= RowsCount; i++)
                {
                    for (j = 1; j <= ColumnsCount; j++)
                    {
                        dataGridView.Rows[i - 1].Cells[j - 1].Value = arrData[i, j];
                    }
                }
                return dataGridView;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
            }

            return dataGridView;
            //for(int row = 1; row < rowsCount; row++)
            //{
            //    dataGridView.Rows.Insert(row-1, sheet.Rows.EntireRow.Item[row].Value());
            //    //vs[row-1] = sheet.Rows.EntireRow.Item[row].Value();
            //} 
            //for(int i = 0; i< vs.Length; i++)
            //{
            //    foreach(var s in vs.ToList())
            //    {
            //        dataGridView.Rows.Insert(i,s);
            //        dataGridView.Rows.Add(s);
            //    }
            //}

        }
    }
}
