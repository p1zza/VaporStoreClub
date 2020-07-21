namespace WindowsFormsApp1.Forms
{
    partial class AccountInfo
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
            this.SecretKeyTextBox = new System.Windows.Forms.TextBox();
            this.OpenKeyTextBox = new System.Windows.Forms.TextBox();
            this.OpenKeyLabel = new System.Windows.Forms.Label();
            this.SecretKeyLabel = new System.Windows.Forms.Label();
            this.RestApiTextBox = new System.Windows.Forms.TextBox();
            this.RestApiLabel = new System.Windows.Forms.Label();
            this.AddDataToRegistry = new System.Windows.Forms.Button();
            this.UpdateDataToRegistryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SecretKeyTextBox
            // 
            this.SecretKeyTextBox.Location = new System.Drawing.Point(245, 144);
            this.SecretKeyTextBox.Name = "SecretKeyTextBox";
            this.SecretKeyTextBox.Size = new System.Drawing.Size(406, 20);
            this.SecretKeyTextBox.TabIndex = 3;
            this.SecretKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OpenKeyTextBox
            // 
            this.OpenKeyTextBox.Location = new System.Drawing.Point(245, 118);
            this.OpenKeyTextBox.Name = "OpenKeyTextBox";
            this.OpenKeyTextBox.Size = new System.Drawing.Size(406, 20);
            this.OpenKeyTextBox.TabIndex = 4;
            this.OpenKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OpenKeyLabel
            // 
            this.OpenKeyLabel.AutoSize = true;
            this.OpenKeyLabel.Location = new System.Drawing.Point(92, 125);
            this.OpenKeyLabel.Name = "OpenKeyLabel";
            this.OpenKeyLabel.Size = new System.Drawing.Size(87, 13);
            this.OpenKeyLabel.TabIndex = 5;
            this.OpenKeyLabel.Text = "Открытый ключ";
            // 
            // SecretKeyLabel
            // 
            this.SecretKeyLabel.AutoSize = true;
            this.SecretKeyLabel.Location = new System.Drawing.Point(92, 151);
            this.SecretKeyLabel.Name = "SecretKeyLabel";
            this.SecretKeyLabel.Size = new System.Drawing.Size(87, 13);
            this.SecretKeyLabel.TabIndex = 6;
            this.SecretKeyLabel.Text = "Закрытый ключ";
            // 
            // RestApiTextBox
            // 
            this.RestApiTextBox.Location = new System.Drawing.Point(245, 92);
            this.RestApiTextBox.Name = "RestApiTextBox";
            this.RestApiTextBox.Size = new System.Drawing.Size(406, 20);
            this.RestApiTextBox.TabIndex = 7;
            // 
            // RestApiLabel
            // 
            this.RestApiLabel.AutoSize = true;
            this.RestApiLabel.Location = new System.Drawing.Point(92, 95);
            this.RestApiLabel.Name = "RestApiLabel";
            this.RestApiLabel.Size = new System.Drawing.Size(113, 13);
            this.RestApiLabel.TabIndex = 8;
            this.RestApiLabel.Text = "Ссылка на REST API";
            // 
            // AddDataToRegistry
            // 
            this.AddDataToRegistry.Location = new System.Drawing.Point(387, 206);
            this.AddDataToRegistry.Name = "AddDataToRegistry";
            this.AddDataToRegistry.Size = new System.Drawing.Size(264, 23);
            this.AddDataToRegistry.TabIndex = 9;
            this.AddDataToRegistry.Text = "Добавить запись в реестр";
            this.AddDataToRegistry.UseVisualStyleBackColor = true;
            this.AddDataToRegistry.Click += new System.EventHandler(this.AddDataToRegistry_Click);
            // 
            // UpdateDataToRegistryButton
            // 
            this.UpdateDataToRegistryButton.Location = new System.Drawing.Point(95, 205);
            this.UpdateDataToRegistryButton.Name = "UpdateDataToRegistryButton";
            this.UpdateDataToRegistryButton.Size = new System.Drawing.Size(264, 23);
            this.UpdateDataToRegistryButton.TabIndex = 10;
            this.UpdateDataToRegistryButton.Text = "Обноить данные в реестре";
            this.UpdateDataToRegistryButton.UseVisualStyleBackColor = true;
            this.UpdateDataToRegistryButton.Click += new System.EventHandler(this.UpdateDataFromRegistryButton_Click);
            // 
            // AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateDataToRegistryButton);
            this.Controls.Add(this.AddDataToRegistry);
            this.Controls.Add(this.RestApiLabel);
            this.Controls.Add(this.RestApiTextBox);
            this.Controls.Add(this.SecretKeyLabel);
            this.Controls.Add(this.OpenKeyLabel);
            this.Controls.Add(this.OpenKeyTextBox);
            this.Controls.Add(this.SecretKeyTextBox);
            this.Name = "AccountInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AccountInfo";
            this.Controls.SetChildIndex(this.SecretKeyTextBox, 0);
            this.Controls.SetChildIndex(this.OpenKeyTextBox, 0);
            this.Controls.SetChildIndex(this.OpenKeyLabel, 0);
            this.Controls.SetChildIndex(this.SecretKeyLabel, 0);
            this.Controls.SetChildIndex(this.RestApiTextBox, 0);
            this.Controls.SetChildIndex(this.RestApiLabel, 0);
            this.Controls.SetChildIndex(this.AddDataToRegistry, 0);
            this.Controls.SetChildIndex(this.UpdateDataToRegistryButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SecretKeyTextBox;
        private System.Windows.Forms.TextBox OpenKeyTextBox;
        private System.Windows.Forms.Label OpenKeyLabel;
        private System.Windows.Forms.Label SecretKeyLabel;
        private System.Windows.Forms.TextBox RestApiTextBox;
        private System.Windows.Forms.Label RestApiLabel;
        private System.Windows.Forms.Button AddDataToRegistry;
        private System.Windows.Forms.Button UpdateDataToRegistryButton;
    }
}