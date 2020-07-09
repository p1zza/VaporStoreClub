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
    public partial class AccountInfo : MainWindow
    {
        public static string consumer_secret = "cs_23239244d84a296dbed9cafbac70f3907be4b055";
        public static string consumer_key = "ck_c2acd179f1c843c2884b62f76a592eeddaf6d71e";
        public static string RestApiLink = @"http://armamivape.ru/wp-json/wc/v3";

        //public static WCObject wc { get; set; }

        public static string _consumer_secret { get;set; }
        public static string _consumer_key { get; set; }
        public static string _RestApiLink { get; set; }

        public AccountInfo()
        {
            InitializeComponent();
            OpenKeyTextBox.Text = consumer_key;
            SecretKeyTextBox.Text = consumer_secret;
            RestApiTextBox.Text = RestApiLink;
        }
    }
}
