using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using WindowsFormsApp1.Forms;
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    class Parse
    {
        private string path;
        
        public Parse(string Path)
        {
            path = Path;
        }

        public void GetDataFromExcel()
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

            Worksheet xlWorkSheet = xlWorkBook.Item(1);
            Range columnRange = xlWorkSheet.UsedRange; 
            
                
        }
    }

    public static class WorksheetExtension
    {
        public static object Item(this Workbook worksheet, int item)
        {
            return worksheet.Item(item); 
        }
    }
}
