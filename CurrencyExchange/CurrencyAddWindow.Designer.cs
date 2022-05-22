namespace CurrencyExchange
{
    partial class CurrencyAddWindow
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
            this.labelCurrencyName = new System.Windows.Forms.Label();
            this.textBoxCurrencyName = new System.Windows.Forms.TextBox();
            this.textBoxCurrencySymbol = new System.Windows.Forms.TextBox();
            this.labelCurrencySymbol = new System.Windows.Forms.Label();
            this.textBoxCurrencyPrice = new System.Windows.Forms.TextBox();
            this.labelCurrencyPrice = new System.Windows.Forms.Label();
            this.buttonAddCurrency = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCurrencyName
            // 
            this.labelCurrencyName.AutoSize = true;
            this.labelCurrencyName.Location = new System.Drawing.Point(22, 19);
            this.labelCurrencyName.Name = "labelCurrencyName";
            this.labelCurrencyName.Size = new System.Drawing.Size(106, 17);
            this.labelCurrencyName.TabIndex = 0;
            this.labelCurrencyName.Text = "Currency Name";
            // 
            // textBoxCurrencyName
            // 
            this.textBoxCurrencyName.Location = new System.Drawing.Point(25, 49);
            this.textBoxCurrencyName.Name = "textBoxCurrencyName";
            this.textBoxCurrencyName.Size = new System.Drawing.Size(338, 22);
            this.textBoxCurrencyName.TabIndex = 1;
            // 
            // textBoxCurrencySymbol
            // 
            this.textBoxCurrencySymbol.Location = new System.Drawing.Point(25, 130);
            this.textBoxCurrencySymbol.Name = "textBoxCurrencySymbol";
            this.textBoxCurrencySymbol.Size = new System.Drawing.Size(338, 22);
            this.textBoxCurrencySymbol.TabIndex = 3;
            // 
            // labelCurrencySymbol
            // 
            this.labelCurrencySymbol.AutoSize = true;
            this.labelCurrencySymbol.Location = new System.Drawing.Point(22, 100);
            this.labelCurrencySymbol.Name = "labelCurrencySymbol";
            this.labelCurrencySymbol.Size = new System.Drawing.Size(115, 17);
            this.labelCurrencySymbol.TabIndex = 2;
            this.labelCurrencySymbol.Text = "Currency Symbol";
            // 
            // textBoxCurrencyPrice
            // 
            this.textBoxCurrencyPrice.Location = new System.Drawing.Point(25, 212);
            this.textBoxCurrencyPrice.Name = "textBoxCurrencyPrice";
            this.textBoxCurrencyPrice.Size = new System.Drawing.Size(338, 22);
            this.textBoxCurrencyPrice.TabIndex = 5;
            // 
            // labelCurrencyPrice
            // 
            this.labelCurrencyPrice.AutoSize = true;
            this.labelCurrencyPrice.Location = new System.Drawing.Point(22, 182);
            this.labelCurrencyPrice.Name = "labelCurrencyPrice";
            this.labelCurrencyPrice.Size = new System.Drawing.Size(157, 17);
            this.labelCurrencyPrice.TabIndex = 4;
            this.labelCurrencyPrice.Text = "Currency Price (in PLN)";
            // 
            // buttonAddCurrency
            // 
            this.buttonAddCurrency.Location = new System.Drawing.Point(254, 273);
            this.buttonAddCurrency.Name = "buttonAddCurrency";
            this.buttonAddCurrency.Size = new System.Drawing.Size(108, 43);
            this.buttonAddCurrency.TabIndex = 6;
            this.buttonAddCurrency.Text = "Add";
            this.buttonAddCurrency.UseVisualStyleBackColor = true;
            this.buttonAddCurrency.Click += new System.EventHandler(this.buttonAddCurrency_Click);
            // 
            // CurrencyAddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 359);
            this.Controls.Add(this.buttonAddCurrency);
            this.Controls.Add(this.textBoxCurrencyPrice);
            this.Controls.Add(this.labelCurrencyPrice);
            this.Controls.Add(this.textBoxCurrencySymbol);
            this.Controls.Add(this.labelCurrencySymbol);
            this.Controls.Add(this.textBoxCurrencyName);
            this.Controls.Add(this.labelCurrencyName);
            this.Name = "CurrencyAddWindow";
            this.Text = "CurrencyAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrencyName;
        private System.Windows.Forms.TextBox textBoxCurrencyName;
        private System.Windows.Forms.TextBox textBoxCurrencySymbol;
        private System.Windows.Forms.Label labelCurrencySymbol;
        private System.Windows.Forms.TextBox textBoxCurrencyPrice;
        private System.Windows.Forms.Label labelCurrencyPrice;
        private System.Windows.Forms.Button buttonAddCurrency;
    }
}