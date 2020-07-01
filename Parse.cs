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
        

        Parse(string Path)
        {
            path = Path;
        }

        private void GetDataFromExcel(string pathToFile)
        {
            Application xlApp = new Application();

            Workbook xlWorkBook = xlApp.Workbooks.Open(pathToFile, 
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

            Worksheet xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Range columnRange = xlWorkSheet.UsedRange; 
            
                
        }
    }
}
