﻿namespace VaporStoreClubNamespace
{
    partial class ParseWindow
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
            this.ParserGridView = new System.Windows.Forms.DataGridView();
            this.Number_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Columnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.GetDataFromMagazine_Button = new System.Windows.Forms.Button();
            this.GetDataFromSiteDB_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ParserGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ParserGridView
            // 
            this.ParserGridView.AllowUserToAddRows = false;
            this.ParserGridView.AllowUserToDeleteRows = false;
            this.ParserGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParserGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ParserGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ParserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParserGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number_Column,
            this.Name_Column,
            this.Price_Columnt,
            this.AmountStatus,
            this.Amount_Column,
            this.Category_Column,
            this.ActionButtonColumn});
            this.ParserGridView.Location = new System.Drawing.Point(12, 54);
            this.ParserGridView.Name = "ParserGridView";
            this.ParserGridView.Size = new System.Drawing.Size(1205, 637);
            this.ParserGridView.TabIndex = 0;
            this.ParserGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ParserGridView_CellMouseClick);
            // 
            // Number_Column
            // 
            this.Number_Column.HeaderText = "#";
            this.Number_Column.Name = "Number_Column";
            this.Number_Column.Width = 39;
            // 
            // Name_Column
            // 
            this.Name_Column.HeaderText = "Имя";
            this.Name_Column.Name = "Name_Column";
            this.Name_Column.Width = 54;
            // 
            // Price_Columnt
            // 
            this.Price_Columnt.HeaderText = "Цена";
            this.Price_Columnt.Name = "Price_Columnt";
            this.Price_Columnt.Width = 58;
            // 
            // AmountStatus
            // 
            this.AmountStatus.HeaderText = "На складе";
            this.AmountStatus.Name = "AmountStatus";
            this.AmountStatus.Width = 85;
            // 
            // Amount_Column
            // 
            this.Amount_Column.HeaderText = "Кол-во";
            this.Amount_Column.Name = "Amount_Column";
            this.Amount_Column.Width = 66;
            // 
            // Category_Column
            // 
            this.Category_Column.HeaderText = "Категория";
            this.Category_Column.Name = "Category_Column";
            this.Category_Column.Width = 85;
            // 
            // ActionButtonColumn
            // 
            this.ActionButtonColumn.HeaderText = "Действия";
            this.ActionButtonColumn.Name = "ActionButtonColumn";
            this.ActionButtonColumn.ReadOnly = true;
            this.ActionButtonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ActionButtonColumn.Text = "Обновить товар на сайте";
            this.ActionButtonColumn.UseColumnTextForButtonValue = true;
            this.ActionButtonColumn.Width = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Найдено товаров:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(937, 28);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(280, 20);
            this.SearchTextBox.TabIndex = 4;
            this.SearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextBox_KeyPress);
            // 
            // GetDataFromMagazine_Button
            // 
            this.GetDataFromMagazine_Button.Location = new System.Drawing.Point(588, 28);
            this.GetDataFromMagazine_Button.Name = "GetDataFromMagazine_Button";
            this.GetDataFromMagazine_Button.Size = new System.Drawing.Size(203, 23);
            this.GetDataFromMagazine_Button.TabIndex = 5;
            this.GetDataFromMagazine_Button.Text = "Загрузить из магазина";
            this.GetDataFromMagazine_Button.UseVisualStyleBackColor = true;
            this.GetDataFromMagazine_Button.Click += new System.EventHandler(this.GetDataFromMagazine_Button_Click);
            // 
            // GetDataFromSiteDB_Button
            // 
            this.GetDataFromSiteDB_Button.Location = new System.Drawing.Point(392, 28);
            this.GetDataFromSiteDB_Button.Name = "GetDataFromSiteDB_Button";
            this.GetDataFromSiteDB_Button.Size = new System.Drawing.Size(190, 23);
            this.GetDataFromSiteDB_Button.TabIndex = 6;
            this.GetDataFromSiteDB_Button.Text = "Загрузить из базы данных";
            this.GetDataFromSiteDB_Button.UseVisualStyleBackColor = true;
            this.GetDataFromSiteDB_Button.Click += new System.EventHandler(this.GetDataFromSiteDB_Button_Click);
            // 
            // ParseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 703);
            this.Controls.Add(this.GetDataFromSiteDB_Button);
            this.Controls.Add(this.GetDataFromMagazine_Button);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ParserGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ParseWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParseWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ParseWindow_FormClosed);
            this.Controls.SetChildIndex(this.ParserGridView, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.SearchTextBox, 0);
            this.Controls.SetChildIndex(this.GetDataFromMagazine_Button, 0);
            this.Controls.SetChildIndex(this.GetDataFromSiteDB_Button, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ParserGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ParserGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Columnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Column;
        private System.Windows.Forms.DataGridViewButtonColumn ActionButtonColumn;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button GetDataFromMagazine_Button;
        private System.Windows.Forms.Button GetDataFromSiteDB_Button;
    }
}