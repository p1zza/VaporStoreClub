using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using WindowsFormsApp1.Forms;
using Microsoft.Office.Interop.Excel;
using WooCommerceNET.WooCommerce.v3;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Parse
    {
        private string path;
        private static Microsoft.Office.Interop.Excel.Application xlApp { get; set; }
        private static Workbook xlWorkBook { get; set; }
        private static Worksheet xlWorkSheet { get; set; }

        //public static RestAPI API { get; set; }
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
                xlApp = new Microsoft.Office.Interop.Excel.Application();
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
        }

        public static void PutDataInDictionary(DataGridViewRowCollection Rows, int column, string pattern)
        {
            switch (pattern)
            {
                case "Порядковый номер":
                    {
                       
                        break;
                    }
                case "Наименование":
                    {
                        break;
                    }
                case "Цена":
                    {
                        break;
                    }
                case "Кол - во":
                    {
                        break;
                    }
                case "Категория":
                    {
                        break;
                    }
                case "Пропустить":
                    {
                        break;
                    }
            }
            foreach (DataGridViewRow row in Rows)
            {
                for(int i =0; i<Rows.Count; i++)
                {
                    Rows[i].Cells[column].Value;
                }

                
                //Rows.Cast<DataGridViewCell>().ToList();

                //if (object.Equals(row.Cells.GetCellValueFromColumnHeader(pattern), pattern))
                //{

                //    // ...
                //}
            }
        }



    }

    class RawProduct
    {
        private static Dictionary<int,string> ProductNames { get; set; }
        private static Dictionary<int, int?> ProductPrice { get; set; }
        private static Dictionary<int, int?> ProductStockQuantity { get; set; }
        private static Dictionary<int, ProductCategoryLine> ProductCategory { get; set; }
        RawProduct()
        {
            ProductNames = new Dictionary<int, string>();
            ProductPrice = new Dictionary<int, int?>();
            ProductStockQuantity = new Dictionary<int, int?>();
            ProductCategory = new Dictionary<int, ProductCategoryLine>();
        }

        private void AddName(int id, string name)
        {
            ProductNames.Add(id, name);
        }

        private void AddPrice(int id, int? price)
        {
            ProductPrice.Add(id, price);
        }

        private void AddStockQuantity(int id, int? value)
        {
            ProductStockQuantity.Add(id, value);
        }

        private void AddCategory (int id, ProductCategoryLine categoryLine)
        {
            throw new Exception("Не обработано");
        }

    }
}
