namespace CurrencyExchange
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
            this.buttonCorrectPrice = new System.Windows.Forms.Button();
            this.buttonDollar = new System.Windows.Forms.Button();
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
            // buttonCorrectPrice
            // 
            this.buttonCorrectPrice.Location = new System.Drawing.Point(43, 217);
            this.buttonCorrectPrice.Name = "buttonCorrectPrice";
            this.buttonCorrectPrice.Size = new System.Drawing.Size(267, 60);
            this.buttonCorrectPrice.TabIndex = 1;
            this.buttonCorrectPrice.Text = "Correct Price";
            this.buttonCorrectPrice.UseVisualStyleBackColor = true;
            this.buttonCorrectPrice.MouseEnter += new System.EventHandler(this.buttonCorrectPrice_MouseEnter);
            this.buttonCorrectPrice.MouseLeave += new System.EventHandler(this.buttonCorrectPrice_MouseLeave);
            // 
            // buttonDollar
            // 
            this.buttonDollar.Location = new System.Drawing.Point(43, 321);
            this.buttonDollar.Name = "buttonDollar";
            this.buttonDollar.Size = new System.Drawing.Size(267, 60);
            this.buttonDollar.TabIndex = 2;
            this.buttonDollar.Text = "Dollar 2D";
            this.buttonDollar.UseVisualStyleBackColor = true;
            this.buttonDollar.Click += new System.EventHandler(this.buttonDollar_Click);
            this.buttonDollar.MouseEnter += new System.EventHandler(this.buttonDollar_MouseEnter);
            this.buttonDollar.MouseLeave += new System.EventHandler(this.buttonDollar_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 564);
            this.Controls.Add(this.buttonDollar);
            this.Controls.Add(this.buttonCorrectPrice);
            this.Controls.Add(this.buttonCheckPrice);
            this.Name = "MainForm";
            this.Text = "Currency Exchange";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckPrice;
        private System.Windows.Forms.Button buttonCorrectPrice;
        private System.Windows.Forms.Button buttonDollar;
    }
}

