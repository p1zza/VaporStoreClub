﻿namespace WindowsFormsApp1.Forms
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
            this.SuspendLayout();
            // 
            // SecretKeyTextBox
            // 
            this.SecretKeyTextBox.Location = new System.Drawing.Point(245, 114);
            this.SecretKeyTextBox.Name = "SecretKeyTextBox";
            this.SecretKeyTextBox.Size = new System.Drawing.Size(406, 20);
            this.SecretKeyTextBox.TabIndex = 3;
            this.SecretKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OpenKeyTextBox
            // 
            this.OpenKeyTextBox.Location = new System.Drawing.Point(245, 88);
            this.OpenKeyTextBox.Name = "OpenKeyTextBox";
            this.OpenKeyTextBox.Size = new System.Drawing.Size(406, 20);
            this.OpenKeyTextBox.TabIndex = 4;
            this.OpenKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OpenKeyLabel
            // 
            this.OpenKeyLabel.AutoSize = true;
            this.OpenKeyLabel.Location = new System.Drawing.Point(92, 95);
            this.OpenKeyLabel.Name = "OpenKeyLabel";
            this.OpenKeyLabel.Size = new System.Drawing.Size(87, 13);
            this.OpenKeyLabel.TabIndex = 5;
            this.OpenKeyLabel.Text = "Открытый ключ";
            // 
            // SecretKeyLabel
            // 
            this.SecretKeyLabel.AutoSize = true;
            this.SecretKeyLabel.Location = new System.Drawing.Point(92, 121);
            this.SecretKeyLabel.Name = "SecretKeyLabel";
            this.SecretKeyLabel.Size = new System.Drawing.Size(87, 13);
            this.SecretKeyLabel.TabIndex = 6;
            this.SecretKeyLabel.Text = "Закрытый ключ";
            // 
            // AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SecretKeyTextBox;
        private System.Windows.Forms.TextBox OpenKeyTextBox;
        private System.Windows.Forms.Label OpenKeyLabel;
        private System.Windows.Forms.Label SecretKeyLabel;
    }
}