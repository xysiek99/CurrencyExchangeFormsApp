﻿namespace CurrencyExchange
{
    partial class MainForm
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
            this.buttonCheckPrice = new System.Windows.Forms.Button();
            this.buttonEditData = new System.Windows.Forms.Button();
            this.buttonShowCurrency = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCheckPrice
            // 
            this.buttonCheckPrice.Location = new System.Drawing.Point(43, 111);
            this.buttonCheckPrice.Name = "buttonCheckPrice";
            this.buttonCheckPrice.Size = new System.Drawing.Size(267, 60);
            this.buttonCheckPrice.TabIndex = 0;
            this.buttonCheckPrice.Text = "Check Prices";
            this.buttonCheckPrice.UseVisualStyleBackColor = true;
            this.buttonCheckPrice.Click += new System.EventHandler(this.buttonCheckPrice_Click);
            this.buttonCheckPrice.MouseEnter += new System.EventHandler(this.buttonCheckPrice_MouseEnter);
            this.buttonCheckPrice.MouseLeave += new System.EventHandler(this.buttonCheckPrice_MouseLeave);
            // 
            // buttonEditData
            // 
            this.buttonEditData.Location = new System.Drawing.Point(43, 217);
            this.buttonEditData.Name = "buttonEditData";
            this.buttonEditData.Size = new System.Drawing.Size(267, 60);
            this.buttonEditData.TabIndex = 1;
            this.buttonEditData.Text = "Edit Data";
            this.buttonEditData.UseVisualStyleBackColor = true;
            this.buttonEditData.Click += new System.EventHandler(this.buttonEditData_Click);
            this.buttonEditData.MouseEnter += new System.EventHandler(this.buttonEditData_MouseEnter);
            this.buttonEditData.MouseLeave += new System.EventHandler(this.buttonEditData_MouseLeave);
            // 
            // buttonShowCurrency
            // 
            this.buttonShowCurrency.Location = new System.Drawing.Point(43, 321);
            this.buttonShowCurrency.Name = "buttonShowCurrency";
            this.buttonShowCurrency.Size = new System.Drawing.Size(267, 60);
            this.buttonShowCurrency.TabIndex = 2;
            this.buttonShowCurrency.Text = "Show 2D Currency";
            this.buttonShowCurrency.UseVisualStyleBackColor = true;
            this.buttonShowCurrency.Click += new System.EventHandler(this.buttonShowCurrency_Click);
            this.buttonShowCurrency.MouseEnter += new System.EventHandler(this.buttonShowCurrency_MouseEnter);
            this.buttonShowCurrency.MouseLeave += new System.EventHandler(this.buttonShowCurrency_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 564);
            this.Controls.Add(this.buttonShowCurrency);
            this.Controls.Add(this.buttonEditData);
            this.Controls.Add(this.buttonCheckPrice);
            this.Name = "MainForm";
            this.Text = "Currency Exchange";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckPrice;
        private System.Windows.Forms.Button buttonEditData;
        private System.Windows.Forms.Button buttonShowCurrency;
    }
}

