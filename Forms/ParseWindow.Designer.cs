namespace WindowsFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Number_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Columnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number_Column,
            this.Name_Column,
            this.Price_Columnt,
            this.Amount_Column,
            this.Category_Column});
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 384);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Найдено товаров:";
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
            // ParseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ParseWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parser";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Columnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Column;
    }
}