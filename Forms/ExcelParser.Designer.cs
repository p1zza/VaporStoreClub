namespace WindowsFormsApp1.Forms
{
    partial class ExcelParser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.First_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Second_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Third_Columnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fourth_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fifth_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sixth_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seventh_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eighth_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExcelPatternTextBox = new System.Windows.Forms.TextBox();
            this.ExcelPatternLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FirstComboBox = new System.Windows.Forms.ComboBox();
            this.SecondComboBox = new System.Windows.Forms.ComboBox();
            this.ThirdComboBox = new System.Windows.Forms.ComboBox();
            this.FourthComboBox = new System.Windows.Forms.ComboBox();
            this.FifthComboBox = new System.Windows.Forms.ComboBox();
            this.SixthComboBox = new System.Windows.Forms.ComboBox();
            this.SeventhComboBox = new System.Windows.Forms.ComboBox();
            this.EighthComboBox = new System.Windows.Forms.ComboBox();
            this.FirstColumnLabel = new System.Windows.Forms.Label();
            this.SecondColumnLabel = new System.Windows.Forms.Label();
            this.ThirdColumnLabel = new System.Windows.Forms.Label();
            this.FourthColumnLabel = new System.Windows.Forms.Label();
            this.FifthColumnLabel = new System.Windows.Forms.Label();
            this.SixthColumnLabel = new System.Windows.Forms.Label();
            this.SeventhColumnLabel = new System.Windows.Forms.Label();
            this.EighthColumnLabel = new System.Windows.Forms.Label();
            this.ExportAmountLabel = new System.Windows.Forms.Label();
            this.ExportAmountTextbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ExportProgressBar = new System.Windows.Forms.ProgressBar();
            this.BeginExportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "\"Excel files (*.xlsx;*.xlsm)|*.xlsx;*.xlsm|All files (*.*)|*.*\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Путь до файла Excel:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Выбрать файл Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.First_Column,
            this.Second_Column,
            this.Third_Columnt,
            this.Fourth_Column,
            this.Fifth_Column,
            this.Sixth_Column,
            this.Seventh_Column,
            this.Eighth_Column});
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(924, 496);
            this.dataGridView1.TabIndex = 5;
            // 
            // First_Column
            // 
            this.First_Column.HeaderText = "Первый столбец";
            this.First_Column.Name = "First_Column";
            this.First_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.First_Column.Width = 87;
            // 
            // Second_Column
            // 
            this.Second_Column.HeaderText = "Второй столбец";
            this.Second_Column.Name = "Second_Column";
            this.Second_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Second_Column.Width = 84;
            // 
            // Third_Columnt
            // 
            this.Third_Columnt.HeaderText = "Третий столбец";
            this.Third_Columnt.Name = "Third_Columnt";
            this.Third_Columnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Third_Columnt.Width = 84;
            // 
            // Fourth_Column
            // 
            this.Fourth_Column.HeaderText = "Четвертый столбец";
            this.Fourth_Column.Name = "Fourth_Column";
            this.Fourth_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Fourth_Column.Width = 102;
            // 
            // Fifth_Column
            // 
            this.Fifth_Column.HeaderText = "Пятый столбец";
            this.Fifth_Column.Name = "Fifth_Column";
            this.Fifth_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Fifth_Column.Width = 81;
            // 
            // Sixth_Column
            // 
            this.Sixth_Column.HeaderText = "Шестой столбец";
            this.Sixth_Column.Name = "Sixth_Column";
            this.Sixth_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Sixth_Column.Width = 86;
            // 
            // Seventh_Column
            // 
            this.Seventh_Column.HeaderText = "Седьмой столбец";
            this.Seventh_Column.Name = "Seventh_Column";
            this.Seventh_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Seventh_Column.Width = 92;
            // 
            // Eighth_Column
            // 
            this.Eighth_Column.HeaderText = "Восьмой столбец";
            this.Eighth_Column.Name = "Eighth_Column";
            this.Eighth_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Eighth_Column.Width = 92;
            // 
            // ExcelPatternTextBox
            // 
            this.ExcelPatternTextBox.Location = new System.Drawing.Point(1056, 35);
            this.ExcelPatternTextBox.Name = "ExcelPatternTextBox";
            this.ExcelPatternTextBox.Size = new System.Drawing.Size(100, 20);
            this.ExcelPatternTextBox.TabIndex = 6;
            this.ExcelPatternTextBox.Text = "A1:J";
            // 
            // ExcelPatternLabel
            // 
            this.ExcelPatternLabel.AutoSize = true;
            this.ExcelPatternLabel.Location = new System.Drawing.Point(798, 38);
            this.ExcelPatternLabel.Name = "ExcelPatternLabel";
            this.ExcelPatternLabel.Size = new System.Drawing.Size(252, 13);
            this.ExcelPatternLabel.TabIndex = 7;
            this.ExcelPatternLabel.Text = "Введите диапазон шапки таблицы для экспорта";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.FirstComboBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SecondComboBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ThirdComboBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.FourthComboBox, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.FifthComboBox, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.SixthComboBox, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.SeventhComboBox, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.EighthComboBox, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.FirstColumnLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SecondColumnLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ThirdColumnLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.FourthColumnLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.FifthColumnLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.SixthColumnLabel, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.SeventhColumnLabel, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.EighthColumnLabel, 0, 14);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(959, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 16;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 319);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // FirstComboBox
            // 
            this.FirstComboBox.FormattingEnabled = true;
            this.FirstComboBox.Items.AddRange(new object[] {
            "Порядковый номер",
            "Наименование",
            "Цена",
            "Кол-во",
            "Категория",
            "Пропустить"});
            this.FirstComboBox.Location = new System.Drawing.Point(3, 16);
            this.FirstComboBox.Name = "FirstComboBox";
            this.FirstComboBox.Size = new System.Drawing.Size(194, 21);
            this.FirstComboBox.TabIndex = 0;
            // 
            // SecondComboBox
            // 
            this.SecondComboBox.FormattingEnabled = true;
            this.SecondComboBox.Items.AddRange(new object[] {
            "Порядковый номер",
            "Наименование",
            "Цена",
            "Кол-во",
            "Категория",
            "Пропустить"});
            this.SecondComboBox.Location = new System.Drawing.Point(3, 56);
            this.SecondComboBox.Name = "SecondComboBox";
            this.SecondComboBox.Size = new System.Drawing.Size(194, 21);
            this.SecondComboBox.TabIndex = 1;
            // 
            // ThirdComboBox
            // 
            this.ThirdComboBox.FormattingEnabled = true;
            this.ThirdComboBox.Items.AddRange(new object[] {
            "Порядковый номер",
            "Наименование",
            "Цена",
            "Кол-во",
            "Категория",
            "Пропустить"});
            this.ThirdComboBox.Location = new System.Drawing.Point(3, 96);
            this.ThirdComboBox.Name = "ThirdComboBox";
            this.ThirdComboBox.Size = new System.Drawing.Size(194, 21);
            this.ThirdComboBox.TabIndex = 2;
            // 
            // FourthComboBox
            // 
            this.FourthComboBox.FormattingEnabled = true;
            this.FourthComboBox.Items.AddRange(new object[] {
            "Порядковый номер",
            "Наименование",
            "Цена",
            "Кол-во",
            "Категория",
            "Пропустить"});
            this.FourthComboBox.Location = new System.Drawing.Point(3, 136);
            this.FourthComboBox.Name = "FourthComboBox";
            this.FourthComboBox.Size = new System.Drawing.Size(194, 21);
            this.FourthComboBox.TabIndex = 3;
            // 
            // FifthComboBox
            // 
            this.FifthComboBox.FormattingEnabled = true;
            this.FifthComboBox.Items.AddRange(new object[] {
            "Порядковый номер",
            "Наименование",
            "Цена",
            "Кол-во",
            "Категория",
            "Пропустить"});
            this.FifthComboBox.Location = new System.Drawing.Point(3, 176);
            this.FifthComboBox.Name = "FifthComboBox";
            this.FifthComboBox.Size = new System.Drawing.Size(194, 21);
            this.FifthComboBox.TabIndex = 4;
            // 
            // SixthComboBox
            // 
            this.SixthComboBox.FormattingEnabled = true;
            this.SixthComboBox.Items.AddRange(new object[] {
            "Порядковый номер",
            "Наименование",
            "Цена",
            "Кол-во",
            "Категория",
            "Пропустить"});
            this.SixthComboBox.Location = new System.Drawing.Point(3, 216);
            this.SixthComboBox.Name = "SixthComboBox";
            this.SixthComboBox.Size = new System.Drawing.Size(194, 21);
            this.SixthComboBox.TabIndex = 5;
            // 
            // SeventhComboBox
            // 
            this.SeventhComboBox.FormattingEnabled = true;
            this.SeventhComboBox.Items.AddRange(new object[] {
            "Порядковый номер",
            "Наименование",
            "Цена",
            "Кол-во",
            "Категория",
            "Пропустить"});
            this.SeventhComboBox.Location = new System.Drawing.Point(3, 256);
            this.SeventhComboBox.Name = "SeventhComboBox";
            this.SeventhComboBox.Size = new System.Drawing.Size(194, 21);
            this.SeventhComboBox.TabIndex = 6;
            // 
            // EighthComboBox
            // 
            this.EighthComboBox.FormattingEnabled = true;
            this.EighthComboBox.Items.AddRange(new object[] {
            "Порядковый номер",
            "Наименование",
            "Цена",
            "Кол-во",
            "Категория",
            "Пропустить"});
            this.EighthComboBox.Location = new System.Drawing.Point(3, 296);
            this.EighthComboBox.Name = "EighthComboBox";
            this.EighthComboBox.Size = new System.Drawing.Size(194, 21);
            this.EighthComboBox.TabIndex = 7;
            // 
            // FirstColumnLabel
            // 
            this.FirstColumnLabel.AutoSize = true;
            this.FirstColumnLabel.Location = new System.Drawing.Point(3, 0);
            this.FirstColumnLabel.Name = "FirstColumnLabel";
            this.FirstColumnLabel.Size = new System.Drawing.Size(149, 13);
            this.FirstColumnLabel.TabIndex = 8;
            this.FirstColumnLabel.Text = "Понять первую колонку как";
            // 
            // SecondColumnLabel
            // 
            this.SecondColumnLabel.AutoSize = true;
            this.SecondColumnLabel.Location = new System.Drawing.Point(3, 40);
            this.SecondColumnLabel.Name = "SecondColumnLabel";
            this.SecondColumnLabel.Size = new System.Drawing.Size(148, 13);
            this.SecondColumnLabel.TabIndex = 9;
            this.SecondColumnLabel.Text = "Понять вторую колонку как";
            // 
            // ThirdColumnLabel
            // 
            this.ThirdColumnLabel.AutoSize = true;
            this.ThirdColumnLabel.Location = new System.Drawing.Point(3, 80);
            this.ThirdColumnLabel.Name = "ThirdColumnLabel";
            this.ThirdColumnLabel.Size = new System.Drawing.Size(148, 13);
            this.ThirdColumnLabel.TabIndex = 10;
            this.ThirdColumnLabel.Text = "Понять третью колонку как";
            // 
            // FourthColumnLabel
            // 
            this.FourthColumnLabel.AutoSize = true;
            this.FourthColumnLabel.Location = new System.Drawing.Point(3, 120);
            this.FourthColumnLabel.Name = "FourthColumnLabel";
            this.FourthColumnLabel.Size = new System.Drawing.Size(164, 13);
            this.FourthColumnLabel.TabIndex = 11;
            this.FourthColumnLabel.Text = "Понять четвертую колонку как";
            // 
            // FifthColumnLabel
            // 
            this.FifthColumnLabel.AutoSize = true;
            this.FifthColumnLabel.Location = new System.Drawing.Point(3, 160);
            this.FifthColumnLabel.Name = "FifthColumnLabel";
            this.FifthColumnLabel.Size = new System.Drawing.Size(142, 13);
            this.FifthColumnLabel.TabIndex = 12;
            this.FifthColumnLabel.Text = "Понять пятую колонку как";
            // 
            // SixthColumnLabel
            // 
            this.SixthColumnLabel.AutoSize = true;
            this.SixthColumnLabel.Location = new System.Drawing.Point(3, 200);
            this.SixthColumnLabel.Name = "SixthColumnLabel";
            this.SixthColumnLabel.Size = new System.Drawing.Size(150, 13);
            this.SixthColumnLabel.TabIndex = 13;
            this.SixthColumnLabel.Text = "Понять шестую колонку как";
            // 
            // SeventhColumnLabel
            // 
            this.SeventhColumnLabel.AutoSize = true;
            this.SeventhColumnLabel.Location = new System.Drawing.Point(3, 240);
            this.SeventhColumnLabel.Name = "SeventhColumnLabel";
            this.SeventhColumnLabel.Size = new System.Drawing.Size(157, 13);
            this.SeventhColumnLabel.TabIndex = 14;
            this.SeventhColumnLabel.Text = "Понять седьмую колонку как";
            // 
            // EighthColumnLabel
            // 
            this.EighthColumnLabel.AutoSize = true;
            this.EighthColumnLabel.Location = new System.Drawing.Point(3, 280);
            this.EighthColumnLabel.Name = "EighthColumnLabel";
            this.EighthColumnLabel.Size = new System.Drawing.Size(157, 13);
            this.EighthColumnLabel.TabIndex = 15;
            this.EighthColumnLabel.Text = "Понять восьмую колонку как";
            // 
            // ExportAmountLabel
            // 
            this.ExportAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportAmountLabel.AutoSize = true;
            this.ExportAmountLabel.Location = new System.Drawing.Point(3, 0);
            this.ExportAmountLabel.Name = "ExportAmountLabel";
            this.ExportAmountLabel.Size = new System.Drawing.Size(194, 16);
            this.ExportAmountLabel.TabIndex = 9;
            this.ExportAmountLabel.Text = "Сколько записей экспортировать?";
            // 
            // ExportAmountTextbox
            // 
            this.ExportAmountTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportAmountTextbox.Location = new System.Drawing.Point(3, 19);
            this.ExportAmountTextbox.MaxLength = 4;
            this.ExportAmountTextbox.Name = "ExportAmountTextbox";
            this.ExportAmountTextbox.Size = new System.Drawing.Size(194, 20);
            this.ExportAmountTextbox.TabIndex = 10;
            this.ExportAmountTextbox.Text = "0";
            this.ExportAmountTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ExportAmountTextbox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ExportAmountLabel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(959, 401);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.58333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.41667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 42);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // ExportProgressBar
            // 
            this.ExportProgressBar.Location = new System.Drawing.Point(12, 580);
            this.ExportProgressBar.Name = "ExportProgressBar";
            this.ExportProgressBar.Size = new System.Drawing.Size(924, 23);
            this.ExportProgressBar.TabIndex = 12;
            // 
            // BeginExportButton
            // 
            this.BeginExportButton.Location = new System.Drawing.Point(959, 449);
            this.BeginExportButton.Name = "BeginExportButton";
            this.BeginExportButton.Size = new System.Drawing.Size(200, 154);
            this.BeginExportButton.TabIndex = 13;
            this.BeginExportButton.Text = "Начать экспорт";
            this.BeginExportButton.UseVisualStyleBackColor = true;
            this.BeginExportButton.Click += new System.EventHandler(this.BeginExportButton_Click);
            // 
            // ExcelParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 615);
            this.Controls.Add(this.BeginExportButton);
            this.Controls.Add(this.ExportProgressBar);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ExcelPatternLabel);
            this.Controls.Add(this.ExcelPatternTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ExcelParser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExcelParser";
            this.Load += new System.EventHandler(this.ExcelParser_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.ExcelPatternTextBox, 0);
            this.Controls.SetChildIndex(this.ExcelPatternLabel, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.Controls.SetChildIndex(this.ExportProgressBar, 0);
            this.Controls.SetChildIndex(this.BeginExportButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ExcelPatternTextBox;
        private System.Windows.Forms.Label ExcelPatternLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox FirstComboBox;
        private System.Windows.Forms.ComboBox SecondComboBox;
        private System.Windows.Forms.ComboBox ThirdComboBox;
        private System.Windows.Forms.ComboBox FourthComboBox;
        private System.Windows.Forms.ComboBox FifthComboBox;
        private System.Windows.Forms.ComboBox SixthComboBox;
        private System.Windows.Forms.ComboBox SeventhComboBox;
        private System.Windows.Forms.ComboBox EighthComboBox;
        private System.Windows.Forms.Label FirstColumnLabel;
        private System.Windows.Forms.Label SecondColumnLabel;
        private System.Windows.Forms.Label ThirdColumnLabel;
        private System.Windows.Forms.Label FourthColumnLabel;
        private System.Windows.Forms.Label FifthColumnLabel;
        private System.Windows.Forms.Label SixthColumnLabel;
        private System.Windows.Forms.Label SeventhColumnLabel;
        private System.Windows.Forms.Label EighthColumnLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Second_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Third_Columnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fourth_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fifth_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sixth_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seventh_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eighth_Column;
        private System.Windows.Forms.Label ExportAmountLabel;
        private System.Windows.Forms.TextBox ExportAmountTextbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ProgressBar ExportProgressBar;
        private System.Windows.Forms.Button BeginExportButton;
    }
}