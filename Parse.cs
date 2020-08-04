using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using VaporStoreClubNamespace.Forms;
using Microsoft.Office.Interop.Excel;
using WooCommerceNET.WooCommerce.v3;
using System.Windows.Forms;

namespace VaporStoreClubNamespace
{
    class Parse
    {
        private string path;
        private static Microsoft.Office.Interop.Excel.Application xlApp { get; set; }
        private static Workbook xlWorkBook { get; set; }
        private static Worksheet xlWorkSheet { get; set; }

        public static RawProduct raw { get; set; }
        //public static RestAPI API { get; set; }
        public Parse(string Path)
        {
            path = Path;
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
                return GetDataFromExcelSheet(xlWorkSheet, rowsCount, columnsCount, dataGridView,pattern);
            }
            catch(ArgumentNullException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
            }
            catch (ApplicationException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                xlApp.Quit();
                xlWorkBook.Close(false);
            }
            return null;
        }

        public System.Windows.Forms.DataGridView GetDataFromExcelSheet(Worksheet sheet, int rowsCount, int columnsCount, System.Windows.Forms.DataGridView dataGridView, string pattern)
        {
            try
            {
                int iLastRow = sheet.Cells[sheet.Rows.Count, "A"].End[Microsoft.Office.Interop.Excel.XlDirection.xlUp].Row; 
                var arrData = (object[,])sheet.Range[pattern + iLastRow].Value; 

                dataGridView.Rows.Clear();
                int RowsCount = arrData.GetUpperBound(0);
                int ColumnsCount = arrData.GetUpperBound(1);
                dataGridView.RowCount = RowsCount; 
                dataGridView.ColumnCount = ColumnsCount; 

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
            catch(ArgumentException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
            }
            catch(NullReferenceException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
            }
            catch(OutOfMemoryException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
            }
            return dataGridView;
        }


        public static void GetProductDictionary(RawProduct raw)
        {
            var s = raw.GetProductNames();
            var d = raw.GetProductPrice();
            var n = raw.GetStickQuantity();
        }

        public static void PutProductInDictionary(DataGridViewRowCollection Rows, int column, string pattern)
        {
            switch (pattern)
            {
                case "Порядковый номер":
                    {
                        break;
                    }
                case "Наименование":
                    {
                        for (int i = 0; i < Rows.Count; i++)
                        {
                            raw.AddName(i, Rows[i].Cells[column].Value.ToString());
                        }
                        break;
                    }
                case "Цена":
                    {
                        for (int i = 0; i < Rows.Count; i++)
                        {
                            double result = 0;
                            if (double.TryParse(Rows[i].Cells[column].Value.ToString(), out result))
                            {
                                result = Math.Truncate(result);
                                
                                raw.AddPrice(i, result.ToInt32());
                            }
                            else
                            {
                                raw.AddPrice(i, null);
                            }
                        }
                        break;
                    }
                case "Кол-во":
                    {
                        for (int i = 0; i < Rows.Count; i++)
                        {
                            int result = 0;
                            if (int.TryParse(Rows[i].Cells[column].Value.ToString(), out result))
                            {
                                raw.AddStockQuantity(i, result);
                            }
                            else
                            {
                                raw.AddStockQuantity(i, result);
                            }
                        }
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
        }
    } 
}
