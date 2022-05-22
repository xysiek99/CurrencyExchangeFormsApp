namespace CurrencyExchange
{
    partial class CurrencyDisplayWindow_Subwindow
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
            this.listBoxCurrency = new System.Windows.Forms.ListBox();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCurrency
            // 
            this.listBoxCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxCurrency.FormattingEnabled = true;
            this.listBoxCurrency.ItemHeight = 25;
            this.listBoxCurrency.Location = new System.Drawing.Point(0, 0);
            this.listBoxCurrency.Name = "listBoxCurrency";
            this.listBoxCurrency.Size = new System.Drawing.Size(210, 279);
            this.listBoxCurrency.TabIndex = 0;
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(216, 109);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(114, 47);
            this.buttonChoose.TabIndex = 1;
            this.buttonChoose.Text = "Choose";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // CurrencyDisplayWindow_Subwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 289);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.listBoxCurrency);
            this.Name = "CurrencyDisplayWindow_Subwindow";
            this.Text = "Choose Currency";
            this.Load += new System.EventHandler(this.CurrencyDisplayWindow_Subwindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCurrency;
        private System.Windows.Forms.Button buttonChoose;
    }
}