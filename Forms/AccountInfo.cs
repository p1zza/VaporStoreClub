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
    public partial class AccountInfo : MainWindow
    {
        //public static WCObject wc { get; set; }

        public static string consumer_secret { get;set; }
        public static string consumer_key { get; set; }
        public static string RestApiLink { get; set; }

        public AccountInfo()
        {
            InitializeComponent();
            GetDataFromRegistry();
        }

        private void AddDataToRegistry_Click(object sender, EventArgs e)
        {
            RegistryWorker registryWorker = new RegistryWorker();
            registryWorker.RegisterKeyApi(OpenKeyTextBox.Text, SecretKeyTextBox.Text, RestApiTextBox.Text);
        }

        private void UpdateDataFromRegistryButton_Click(object sender, EventArgs e)
        {
            RegistryWorker registryWorker = new RegistryWorker();
            registryWorker.SetData(OpenKeyTextBox.Text, SecretKeyTextBox.Text, RestApiTextBox.Text);
        }

        private void GetDataFromRegistry()
        {
            RegistryWorker registryWorker = new RegistryWorker();
            string[] vs = registryWorker.GetData();
            OpenKeyTextBox.Text = vs[0].ToString();
            SecretKeyTextBox.Text = vs[1].ToString();
            RestApiTextBox.Text = vs[2].ToString();
        }
    }
}
