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
            this.dataFromSiteView = new System.Windows.Forms.DataGridView();
            this.dataFromMagazineView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataPurchaseView = new System.Windows.Forms.DataGridView();
            this.SiteProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiteProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiteProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiteProductAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFromSiteView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFromMagazineView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPurchaseView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.65347F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.34653F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 460F));
            this.tableLayoutPanel1.Controls.Add(this.dataFromSiteView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataFromMagazineView, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataPurchaseView, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 269F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1013, 746);
            this.tableLayoutPanel1.TabIndex = 3;
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
            this.dataFromSiteView.Size = new System.Drawing.Size(462, 434);
            this.dataFromSiteView.TabIndex = 0;
            // 
            // dataFromMagazineView
            // 
            this.dataFromMagazineView.AllowUserToOrderColumns = true;
            this.dataFromMagazineView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFromMagazineView.Location = new System.Drawing.Point(555, 3);
            this.dataFromMagazineView.Name = "dataFromMagazineView";
            this.dataFromMagazineView.Size = new System.Drawing.Size(455, 434);
            this.dataFromMagazineView.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(462, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(567, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(455, 20);
            this.textBox2.TabIndex = 5;
            // 
            // dataPurchaseView
            // 
            this.dataPurchaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataPurchaseView, 3);
            this.dataPurchaseView.Location = new System.Drawing.Point(3, 480);
            this.dataPurchaseView.Name = "dataPurchaseView";
            this.dataPurchaseView.Size = new System.Drawing.Size(1007, 263);
            this.dataPurchaseView.TabIndex = 2;
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
            // ProductAccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 806);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductAccounting";
            this.Text = "ProductAccounting";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFromSiteView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFromMagazineView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPurchaseView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataFromSiteView;
        private System.Windows.Forms.DataGridView dataFromMagazineView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteProductAmount;
        private System.Windows.Forms.DataGridView dataPurchaseView;
    }
}