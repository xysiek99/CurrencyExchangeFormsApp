namespace CurrencyExchange
{
    partial class CheckPricesWindow
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
            this.components = new System.ComponentModel.Container();
            this.seacrhSymbolLabel = new System.Windows.Forms.Label();
            this.searchSymbolBox = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbolDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // seacrhSymbolLabel
            // 
            this.seacrhSymbolLabel.AutoSize = true;
            this.seacrhSymbolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seacrhSymbolLabel.Location = new System.Drawing.Point(50, 16);
            this.seacrhSymbolLabel.Name = "seacrhSymbolLabel";
            this.seacrhSymbolLabel.Size = new System.Drawing.Size(286, 20);
            this.seacrhSymbolLabel.TabIndex = 1;
            this.seacrhSymbolLabel.Text = "Search by Symbol or Currency Name";
            // 
            // searchSymbolBox
            // 
            this.searchSymbolBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchSymbolBox.Location = new System.Drawing.Point(412, 9);
            this.searchSymbolBox.Name = "searchSymbolBox";
            this.searchSymbolBox.Size = new System.Drawing.Size(212, 27);
            this.searchSymbolBox.TabIndex = 2;
            this.searchSymbolBox.TextChanged += new System.EventHandler(this.searchSymbolBox_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.symbolDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.updatedDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.currencyBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(12, 45);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(656, 560);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // symbolDataGridViewTextBoxColumn1
            // 
            this.symbolDataGridViewTextBoxColumn1.DataPropertyName = "Symbol";
            this.symbolDataGridViewTextBoxColumn1.HeaderText = "Symbol";
            this.symbolDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.symbolDataGridViewTextBoxColumn1.Name = "symbolDataGridViewTextBoxColumn1";
            this.symbolDataGridViewTextBoxColumn1.ReadOnly = true;
            this.symbolDataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn1.HeaderText = "Price (PLN)";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // updatedDataGridViewTextBoxColumn
            // 
            this.updatedDataGridViewTextBoxColumn.DataPropertyName = "Updated";
            this.updatedDataGridViewTextBoxColumn.HeaderText = "Updated";
            this.updatedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.updatedDataGridViewTextBoxColumn.Name = "updatedDataGridViewTextBoxColumn";
            this.updatedDataGridViewTextBoxColumn.Width = 125;
            // 
            // currencyBindingSource1
            // 
            this.currencyBindingSource1.DataSource = typeof(CurrencyExchange.Currency);
            // 
            // CheckPricesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 614);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.searchSymbolBox);
            this.Controls.Add(this.seacrhSymbolLabel);
            this.Name = "CheckPricesWindow";
            this.Text = "CheckPrices";
            this.Load += new System.EventHandler(this.CheckPrices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label seacrhSymbolLabel;
        private System.Windows.Forms.TextBox searchSymbolBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource currencyBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedDataGridViewTextBoxColumn;
    }
}