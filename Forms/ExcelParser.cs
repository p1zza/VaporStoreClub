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
    }
}
