namespace VaporStoreClubNamespace
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлДляЭкспортаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьТаблицуЭкспортаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокТоваровToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главноеМенюToolStripMenuItem,
            this.файлДляЭкспортаToolStripMenuItem,
            this.списокТоваровToolStripMenuItem,
            this.аккаунтToolStripMenuItem,
            this.учётToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главноеМенюToolStripMenuItem
            // 
            this.главноеМенюToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.главноеМенюToolStripMenuItem.Checked = true;
            this.главноеМенюToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.главноеМенюToolStripMenuItem.Name = "главноеМенюToolStripMenuItem";
            this.главноеМенюToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.главноеМенюToolStripMenuItem.Text = "Главное меню";
            this.главноеМенюToolStripMenuItem.Click += new System.EventHandler(this.главноеМенюToolStripMenuItem_Click);
            // 
            // файлДляЭкспортаToolStripMenuItem
            // 
            this.файлДляЭкспортаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.посмотретьТаблицуЭкспортаToolStripMenuItem});
            this.файлДляЭкспортаToolStripMenuItem.Name = "файлДляЭкспортаToolStripMenuItem";
            this.файлДляЭкспортаToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.файлДляЭкспортаToolStripMenuItem.Text = "Экспорт";
            // 
            // посмотретьТаблицуЭкспортаToolStripMenuItem
            // 
            this.посмотретьТаблицуЭкспортаToolStripMenuItem.Name = "посмотретьТаблицуЭкспортаToolStripMenuItem";
            this.посмотретьТаблицуЭкспортаToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.посмотретьТаблицуЭкспортаToolStripMenuItem.Text = "Таблица экспорта";
            this.посмотретьТаблицуЭкспортаToolStripMenuItem.Click += new System.EventHandler(this.посмотретьТаблицуЭкспортаToolStripMenuItem_Click);
            // 
            // списокТоваровToolStripMenuItem
            // 
            this.списокТоваровToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокТоваровToolStripMenuItem1,
            this.добавитьТоварToolStripMenuItem});
            this.списокТоваровToolStripMenuItem.Name = "списокТоваровToolStripMenuItem";
            this.списокТоваровToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.списокТоваровToolStripMenuItem.Text = "Товары";
            // 
            // списокТоваровToolStripMenuItem1
            // 
            this.списокТоваровToolStripMenuItem1.Name = "списокТоваровToolStripMenuItem1";
            this.списокТоваровToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.списокТоваровToolStripMenuItem1.Text = "Список товаров";
            this.списокТоваровToolStripMenuItem1.Click += new System.EventHandler(this.списокТоваровToolStripMenuItem1_Click);
            // 
            // добавитьТоварToolStripMenuItem
            // 
            this.добавитьТоварToolStripMenuItem.Name = "добавитьТоварToolStripMenuItem";
            this.добавитьТоварToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.добавитьТоварToolStripMenuItem.Text = "Добавить товар";
            this.добавитьТоварToolStripMenuItem.Click += new System.EventHandler(this.добавитьТоварToolStripMenuItem_Click);
            // 
            // аккаунтToolStripMenuItem
            // 
            this.аккаунтToolStripMenuItem.Name = "аккаунтToolStripMenuItem";
            this.аккаунтToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.аккаунтToolStripMenuItem.Text = "Аккаунт";
            this.аккаунтToolStripMenuItem.Click += new System.EventHandler(this.аккаунтToolStripMenuItem_Click);
            // 
            // учётToolStripMenuItem
            // 
            this.учётToolStripMenuItem.Name = "учётToolStripMenuItem";
            this.учётToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.учётToolStripMenuItem.Text = "Учёт";
            this.учётToolStripMenuItem.Click += new System.EventHandler(this.учётToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлДляЭкспортаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокТоваровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аккаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьТаблицуЭкспортаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокТоваровToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem учётToolStripMenuItem;
    }
}

