using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaporStoreClubNamespace.Forms
{
    public partial class ExcelParser : MainWindow
    {
        public ExcelParser()
        {
            InitializeComponent();
            if (Rest.wc == null)
            {
                Rest r = new Rest(Forms.AccountInfo.RestApiLink, Forms.AccountInfo.consumer_key, Forms.AccountInfo.consumer_secret);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                label2.Text += openFileDialog1.FileName;
                GetDataFromExcel(openFileDialog1.FileName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void GetDataFromExcel(string path)
        {
            try
            {
                Task.Run(() => {
                Parse parser = new Parse(path);
                if (InvokeRequired)
                {
                    Invoke((Action)(
                        () =>
                        {
                            parser.StartParseExcel(dataGridView1, ExcelPatternTextBox.Text);
                        }));
                }
                else
                {
                    parser.StartParseExcel(dataGridView1, ExcelPatternTextBox.Text);
                }
                Parse.CloseExcel();
            });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ExcelParser_Load(object sender, EventArgs e)
        {

        }

        private void BeginExportButton_Click(object sender, EventArgs e)
        {
            StartParsingProcess();
        }

        private void StartParsingProcess()
        {
            Parse.raw = new RawProduct();
            GetPatternByCombobox(FirstComboBox,     0);
            GetPatternByCombobox(SecondComboBox,    1);
            GetPatternByCombobox(ThirdComboBox,     2);
            GetPatternByCombobox(FourthComboBox,    3);
            GetPatternByCombobox(FifthComboBox,     4);
            GetPatternByCombobox(SixthComboBox,     5);
            GetPatternByCombobox(SeventhComboBox,   6);
            GetPatternByCombobox(EighthComboBox,    7);

            Parse.GetData(Parse.raw);
            Task.Run(()=>Rest.AddProductFromRaw(Parse.raw, Convert.ToUInt16(ExportAmountTextbox.Text)));
        }
        
        public void SetLoadingBarMaxAmount(int max)
        {
            ExportProgressBar.Maximum = max;
        }
        public void UpdateLoadingBarAmount(int i)
        {
            ExportProgressBar.Value += i;
        }

        private void GetValuesFromParsing()
        {
            //Parse
        }


        private void GetPatternByCombobox(ComboBox comboBox,int column)
        {
            //Порядковый номер
            //Наименование
            //Цена
            //Кол - во
            //Категория
            //Пропустить
            try
            {
                if (comboBox.SelectedItem == null)
                {
                    throw new Exception(comboBox.Name + "Не выбран элемент");
                }
                else
                {
                    switch (comboBox.SelectedItem.ToString())
                    {
                        case "Порядковый номер":
                            {
                                Parse.PutDataInDictionary(dataGridView1.Rows, column, "Порядковый номер");
                                break;
                            }
                        case "Наименование":
                            {
                                Parse.PutDataInDictionary(dataGridView1.Rows, column, "Наименование");
                                break;
                            }
                        case "Цена":
                            {
                                Parse.PutDataInDictionary(dataGridView1.Rows, column, "Цена");
                                break;
                            }
                        case "Кол-во":
                            {
                                Parse.PutDataInDictionary(dataGridView1.Rows, column, "Кол-во");
                                break;
                            }
                        case "Категория":
                            {
                                Parse.PutDataInDictionary(dataGridView1.Rows, column, "Категория");
                                break;
                            }
                        case "Пропустить":
                            {
                                break;
                            }
                    }
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            
        }

        private void SaveToExcelButton_Click(object sender, EventArgs e)
        {
            //Excel.Application excelapp = new Excel.Application();
            //Excel.Workbook workbook = excelapp.Workbooks.Add();
            //Excel.Worksheet worksheet = workbook.ActiveSheet;

            //for (int i = 1; i < dataGridView1.RowCount + 1; i++)
            //{
            //    for (int j = 1; j < dataGridView1.ColumnCount + 1; j++)
            //    {
            //        worksheet.Rows[i].Columns[j] = dataGridView1.Rows[i - 1].Cells[j - 1].Value;
            //    }
            //}

            //excelapp.AlertBeforeOverwriting = false;
            //workbook.SaveAs(@"C:\ПУТЬ К ФАЙЛУ\файл.xls");
            //excelapp.Quit();
        }
    }
}
