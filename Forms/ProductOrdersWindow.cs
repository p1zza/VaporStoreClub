using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaporStoreClubNamespace.Workers;

namespace VaporStoreClubNamespace.Forms
{
    public partial class ProductOrdersWindow : MainWindow
    {
        public ProductOrdersWindow()
        {
            InitializeComponent();
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            ProductOrdersWorker productOrdersWorker = new ProductOrdersWorker(OrderCompanyTextBox.Text.ToString(), OrderCommentsTextBox.Text.ToString(), OrdersDateTime.Value);
            OrdersListBox.Items.Add(productOrdersWorker.OrderItem(productOrdersWorker));
        }
    }
}
