using System;
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
            try
            {
                openFileDialog1.ShowDialog();
                label2.Text += openFileDialog1.FileName;
                GetDataFromExcel(openFileDialog1.FileName);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
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
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ExcelParser_Load(object sender, EventArgs e)
        {

        }

        private void BeginExportButton_Click(object sender, EventArgs e)
        {

            //dataGridView1.Columns[1]
        }




        private void GetPatternByCombobox(ComboBox comboBox)
        {
            //Порядковый номер
            //Наименование
            //Цена
            //Кол - во
            //Категория
            //Пропустить

            switch (comboBox.SelectedItem.ToString())
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
        }
    }
}
