namespace CurrencyExchange
{
    partial class DollarWindow
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
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.resetPositionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(618, 359);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(82, 37);
            this.leftButton.TabIndex = 0;
            this.leftButton.Text = "Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(706, 359);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(82, 37);
            this.rightButton.TabIndex = 1;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // resetPositionButton
            // 
            this.resetPositionButton.Location = new System.Drawing.Point(618, 402);
            this.resetPositionButton.Name = "resetPositionButton";
            this.resetPositionButton.Size = new System.Drawing.Size(170, 37);
            this.resetPositionButton.TabIndex = 2;
            this.resetPositionButton.Text = "Reset Position";
            this.resetPositionButton.UseVisualStyleBackColor = true;
            this.resetPositionButton.Click += new System.EventHandler(this.resetPositionButton_Click);
            // 
            // DollarWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetPositionButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Name = "DollarWindow";
            this.Text = "Dollar2D";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DollarWindow_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button resetPositionButton;
    }
}