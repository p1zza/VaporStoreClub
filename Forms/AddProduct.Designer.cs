namespace WindowsFormsApp1.Forms
{
    partial class AddProduct
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
            this.AppendProductButton = new System.Windows.Forms.Button();
            this.ClearTextBoxButton = new System.Windows.Forms.Button();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.ProductAmountTextBox = new System.Windows.Forms.TextBox();
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.AppendProductButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ClearTextBoxButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ProductNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PriceLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AmountLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CategoryLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ProductNameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ProductPriceTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ProductAmountTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CategoryListBox, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.44737F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.55263F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 219);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // AppendProductButton
            // 
            this.AppendProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppendProductButton.Location = new System.Drawing.Point(3, 156);
            this.AppendProductButton.Name = "AppendProductButton";
            this.AppendProductButton.Size = new System.Drawing.Size(381, 60);
            this.AppendProductButton.TabIndex = 0;
            this.AppendProductButton.Text = "Добавить товар";
            this.AppendProductButton.UseVisualStyleBackColor = true;
            this.AppendProductButton.Click += new System.EventHandler(this.AppendProductButton_Click);
            // 
            // ClearTextBoxButton
            // 
            this.ClearTextBoxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearTextBoxButton.Location = new System.Drawing.Point(391, 156);
            this.ClearTextBoxButton.Name = "ClearTextBoxButton";
            this.ClearTextBoxButton.Size = new System.Drawing.Size(382, 60);
            this.ClearTextBoxButton.TabIndex = 1;
            this.ClearTextBoxButton.Text = " Очистить поля";
            this.ClearTextBoxButton.UseVisualStyleBackColor = true;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(3, 0);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(382, 38);
            this.ProductNameLabel.TabIndex = 2;
            this.ProductNameLabel.Text = "Наименование товара";
            this.ProductNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceLabel
            // 
            this.PriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(3, 38);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(382, 38);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Цена";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(3, 76);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(382, 25);
            this.AmountLabel.TabIndex = 4;
            this.AmountLabel.Text = "Количество";
            this.AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(3, 101);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(382, 52);
            this.CategoryLabel.TabIndex = 5;
            this.CategoryLabel.Text = "Категория";
            this.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductNameTextBox.Location = new System.Drawing.Point(391, 3);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(382, 20);
            this.ProductNameTextBox.TabIndex = 6;
            // 
            // ProductPriceTextBox
            // 
            this.ProductPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPriceTextBox.Location = new System.Drawing.Point(391, 41);
            this.ProductPriceTextBox.Name = "ProductPriceTextBox";
            this.ProductPriceTextBox.Size = new System.Drawing.Size(382, 20);
            this.ProductPriceTextBox.TabIndex = 7;
            // 
            // ProductAmountTextBox
            // 
            this.ProductAmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductAmountTextBox.Location = new System.Drawing.Point(391, 79);
            this.ProductAmountTextBox.Name = "ProductAmountTextBox";
            this.ProductAmountTextBox.Size = new System.Drawing.Size(382, 20);
            this.ProductAmountTextBox.TabIndex = 8;
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.Location = new System.Drawing.Point(391, 104);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(382, 43);
            this.CategoryListBox.TabIndex = 9;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 255);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AppendProductButton;
        private System.Windows.Forms.Button ClearTextBoxButton;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.TextBox ProductPriceTextBox;
        private System.Windows.Forms.TextBox ProductAmountTextBox;
        private System.Windows.Forms.ListBox CategoryListBox;
    }
}