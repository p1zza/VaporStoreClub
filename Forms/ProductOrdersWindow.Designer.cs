namespace VaporStoreClubNamespace.Forms
{
    partial class ProductOrdersWindow
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
            this.OrdersListBox = new System.Windows.Forms.ListBox();
            this.OrdersDateTime = new System.Windows.Forms.DateTimePicker();
            this.OrderCompanyTextBox = new System.Windows.Forms.TextBox();
            this.OrderCommentsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrdersListBox
            // 
            this.OrdersListBox.FormattingEnabled = true;
            this.OrdersListBox.HorizontalScrollbar = true;
            this.OrdersListBox.Location = new System.Drawing.Point(616, 37);
            this.OrdersListBox.Name = "OrdersListBox";
            this.OrdersListBox.Size = new System.Drawing.Size(378, 277);
            this.OrdersListBox.TabIndex = 3;
            // 
            // OrdersDateTime
            // 
            this.OrdersDateTime.Location = new System.Drawing.Point(370, 56);
            this.OrdersDateTime.Name = "OrdersDateTime";
            this.OrdersDateTime.Size = new System.Drawing.Size(200, 20);
            this.OrdersDateTime.TabIndex = 6;
            // 
            // OrderCompanyTextBox
            // 
            this.OrderCompanyTextBox.Location = new System.Drawing.Point(40, 56);
            this.OrderCompanyTextBox.Name = "OrderCompanyTextBox";
            this.OrderCompanyTextBox.Size = new System.Drawing.Size(265, 20);
            this.OrderCompanyTextBox.TabIndex = 7;
            // 
            // OrderCommentsTextBox
            // 
            this.OrderCommentsTextBox.Location = new System.Drawing.Point(40, 96);
            this.OrderCommentsTextBox.Multiline = true;
            this.OrderCommentsTextBox.Name = "OrderCommentsTextBox";
            this.OrderCommentsTextBox.Size = new System.Drawing.Size(265, 218);
            this.OrderCommentsTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Кто поставляет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Комментарии";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Когда поставка";
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(370, 263);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(200, 50);
            this.AddOrderButton.TabIndex = 12;
            this.AddOrderButton.Text = "Сохранить";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // ProductOrdersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 329);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderCommentsTextBox);
            this.Controls.Add(this.OrderCompanyTextBox);
            this.Controls.Add(this.OrdersDateTime);
            this.Controls.Add(this.OrdersListBox);
            this.Name = "ProductOrdersWindow";
            this.Text = "ProductOrdersWindow";
            this.Controls.SetChildIndex(this.OrdersListBox, 0);
            this.Controls.SetChildIndex(this.OrdersDateTime, 0);
            this.Controls.SetChildIndex(this.OrderCompanyTextBox, 0);
            this.Controls.SetChildIndex(this.OrderCommentsTextBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.AddOrderButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OrdersListBox;
        private System.Windows.Forms.DateTimePicker OrdersDateTime;
        private System.Windows.Forms.TextBox OrderCompanyTextBox;
        private System.Windows.Forms.TextBox OrderCommentsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddOrderButton;
    }
}