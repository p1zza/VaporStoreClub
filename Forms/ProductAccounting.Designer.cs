namespace VaporStoreClubNamespace.Forms
{
    partial class ProductAccounting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataFromMagazineView = new System.Windows.Forms.DataGridView();
            this.PriceProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceProductAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataProductView = new System.Windows.Forms.DataGridView();
            this.Main_SiteProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_SiteProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_PriceProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_SiteProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_ProductDefaultPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_ProductRecommendPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_PriceProductAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_ProductSelled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_ProductInStockAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFromSiteView = new System.Windows.Forms.DataGridView();
            this.SiteProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiteProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiteProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiteProductAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiteDataGridSearchTextBox = new System.Windows.Forms.TextBox();
            this.PriceDataGridSearchTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFromMagazineView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFromSiteView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.65347F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.34653F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 460F));
            this.tableLayoutPanel1.Controls.Add(this.dataFromMagazineView, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataProductView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataFromSiteView, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 302F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1013, 731);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dataFromMagazineView
            // 
            this.dataFromMagazineView.AllowUserToOrderColumns = true;
            this.dataFromMagazineView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFromMagazineView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PriceProductID,
            this.PriceProductName,
            this.PriceProductDescription,
            this.PriceProductAmount});
            this.dataFromMagazineView.Location = new System.Drawing.Point(555, 3);
            this.dataFromMagazineView.Name = "dataFromMagazineView";
            this.dataFromMagazineView.Size = new System.Drawing.Size(454, 360);
            this.dataFromMagazineView.TabIndex = 1;
            // 
            // PriceProductID
            // 
            this.PriceProductID.HeaderText = "ID в прайсе";
            this.PriceProductID.Name = "PriceProductID";
            // 
            // PriceProductName
            // 
            this.PriceProductName.HeaderText = "Имя в прайсе";
            this.PriceProductName.Name = "PriceProductName";
            // 
            // PriceProductDescription
            // 
            this.PriceProductDescription.HeaderText = "Краткое описание товара в прайсе";
            this.PriceProductDescription.Name = "PriceProductDescription";
            // 
            // PriceProductAmount
            // 
            this.PriceProductAmount.HeaderText = "Общее количество по прайсу";
            this.PriceProductAmount.Name = "PriceProductAmount";
            // 
            // dataProductView
            // 
            this.dataProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Main_SiteProductID,
            this.Main_SiteProductName,
            this.Main_PriceProductName,
            this.Main_SiteProductDescription,
            this.Main_ProductDefaultPrice,
            this.Main_ProductRecommendPrice,
            this.Main_PriceProductAmount,
            this.Main_ProductSelled,
            this.Main_ProductInStockAmount});
            this.tableLayoutPanel1.SetColumnSpan(this.dataProductView, 3);
            this.dataProductView.Location = new System.Drawing.Point(3, 432);
            this.dataProductView.Name = "dataProductView";
            this.dataProductView.Size = new System.Drawing.Size(1007, 256);
            this.dataProductView.TabIndex = 2;
            // 
            // Main_SiteProductID
            // 
            this.Main_SiteProductID.HeaderText = "ID на сайте";
            this.Main_SiteProductID.Name = "Main_SiteProductID";
            // 
            // Main_SiteProductName
            // 
            this.Main_SiteProductName.HeaderText = "Название на сайте";
            this.Main_SiteProductName.Name = "Main_SiteProductName";
            // 
            // Main_PriceProductName
            // 
            this.Main_PriceProductName.HeaderText = "Название товара в прайсе";
            this.Main_PriceProductName.Name = "Main_PriceProductName";
            // 
            // Main_SiteProductDescription
            // 
            this.Main_SiteProductDescription.HeaderText = "Краткое описание на сайте";
            this.Main_SiteProductDescription.Name = "Main_SiteProductDescription";
            // 
            // Main_ProductDefaultPrice
            // 
            this.Main_ProductDefaultPrice.HeaderText = "Заход";
            this.Main_ProductDefaultPrice.Name = "Main_ProductDefaultPrice";
            // 
            // Main_ProductRecommendPrice
            // 
            this.Main_ProductRecommendPrice.HeaderText = "РРЦ";
            this.Main_ProductRecommendPrice.Name = "Main_ProductRecommendPrice";
            // 
            // Main_PriceProductAmount
            // 
            this.Main_PriceProductAmount.HeaderText = "Количество";
            this.Main_PriceProductAmount.Name = "Main_PriceProductAmount";
            // 
            // Main_ProductSelled
            // 
            this.Main_ProductSelled.HeaderText = "Продано";
            this.Main_ProductSelled.Name = "Main_ProductSelled";
            // 
            // Main_ProductInStockAmount
            // 
            this.Main_ProductInStockAmount.HeaderText = "Осталось";
            this.Main_ProductInStockAmount.Name = "Main_ProductInStockAmount";
            // 
            // dataFromSiteView
            // 
            this.dataFromSiteView.AllowUserToOrderColumns = true;
            this.dataFromSiteView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFromSiteView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SiteProductID,
            this.SiteProductName,
            this.SiteProductDescription,
            this.SiteProductAmount});
            this.dataFromSiteView.Location = new System.Drawing.Point(3, 3);
            this.dataFromSiteView.Name = "dataFromSiteView";
            this.dataFromSiteView.Size = new System.Drawing.Size(462, 360);
            this.dataFromSiteView.TabIndex = 0;
            // 
            // SiteProductID
            // 
            this.SiteProductID.HeaderText = "ID на сайте";
            this.SiteProductID.Name = "SiteProductID";
            // 
            // SiteProductName
            // 
            this.SiteProductName.HeaderText = "Название на сайте";
            this.SiteProductName.Name = "SiteProductName";
            // 
            // SiteProductDescription
            // 
            this.SiteProductDescription.HeaderText = "Краткое описание товара на сайте";
            this.SiteProductDescription.Name = "SiteProductDescription";
            // 
            // SiteProductAmount
            // 
            this.SiteProductAmount.HeaderText = "Общее количество";
            this.SiteProductAmount.Name = "SiteProductAmount";
            // 
            // SiteDataGridSearchTextBox
            // 
            this.SiteDataGridSearchTextBox.Location = new System.Drawing.Point(15, 40);
            this.SiteDataGridSearchTextBox.Name = "SiteDataGridSearchTextBox";
            this.SiteDataGridSearchTextBox.Size = new System.Drawing.Size(462, 20);
            this.SiteDataGridSearchTextBox.TabIndex = 4;
            // 
            // PriceDataGridSearchTextBox
            // 
            this.PriceDataGridSearchTextBox.Location = new System.Drawing.Point(568, 40);
            this.PriceDataGridSearchTextBox.Name = "PriceDataGridSearchTextBox";
            this.PriceDataGridSearchTextBox.Size = new System.Drawing.Size(454, 20);
            this.PriceDataGridSearchTextBox.TabIndex = 5;
            // 
            // ProductAccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 806);
            this.Controls.Add(this.PriceDataGridSearchTextBox);
            this.Controls.Add(this.SiteDataGridSearchTextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductAccounting";
            this.Text = "ProductAccounting";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.SiteDataGridSearchTextBox, 0);
            this.Controls.SetChildIndex(this.PriceDataGridSearchTextBox, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFromMagazineView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFromSiteView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataFromSiteView;
        private System.Windows.Forms.DataGridView dataFromMagazineView;
        private System.Windows.Forms.TextBox SiteDataGridSearchTextBox;
        private System.Windows.Forms.TextBox PriceDataGridSearchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteProductAmount;
        private System.Windows.Forms.DataGridView dataProductView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceProductAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_SiteProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_SiteProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_PriceProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_SiteProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_ProductDefaultPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_ProductRecommendPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_PriceProductAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_ProductSelled;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_ProductInStockAmount;
    }
}