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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cURRENCYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kASETY_407_02DataSet = new CurrencyExchange.KASETY_407_02DataSet();
            this.___CURRENCYTableAdapter = new CurrencyExchange.KASETY_407_02DataSetTableAdapters.@__CURRENCYTableAdapter();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seacrhSymbolLabel = new System.Windows.Forms.Label();
            this.searchSymbolBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURRENCYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kASETY_407_02DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currencyDataGridViewTextBoxColumn,
            this.symbolDataGridViewTextBoxColumn,
            this.Price});
            this.dataGridView1.DataSource = this.cURRENCYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(454, 690);
            this.dataGridView1.TabIndex = 0;
            // 
            // cURRENCYBindingSource
            // 
            this.cURRENCYBindingSource.DataMember = "__CURRENCY";
            this.cURRENCYBindingSource.DataSource = this.kASETY_407_02DataSet;
            // 
            // kASETY_407_02DataSet
            // 
            this.kASETY_407_02DataSet.DataSetName = "KASETY_407_02DataSet";
            this.kASETY_407_02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ___CURRENCYTableAdapter
            // 
            this.___CURRENCYTableAdapter.ClearBeforeFill = true;
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "Currency";
            this.currencyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            this.currencyDataGridViewTextBoxColumn.ReadOnly = true;
            this.currencyDataGridViewTextBoxColumn.Width = 125;
            // 
            // symbolDataGridViewTextBoxColumn
            // 
            this.symbolDataGridViewTextBoxColumn.DataPropertyName = "Symbol";
            this.symbolDataGridViewTextBoxColumn.HeaderText = "Symbol";
            this.symbolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.symbolDataGridViewTextBoxColumn.Name = "symbolDataGridViewTextBoxColumn";
            this.symbolDataGridViewTextBoxColumn.ReadOnly = true;
            this.symbolDataGridViewTextBoxColumn.Width = 75;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price (in PLN)";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // seacrhSymbolLabel
            // 
            this.seacrhSymbolLabel.AutoSize = true;
            this.seacrhSymbolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seacrhSymbolLabel.Location = new System.Drawing.Point(12, 9);
            this.seacrhSymbolLabel.Name = "seacrhSymbolLabel";
            this.seacrhSymbolLabel.Size = new System.Drawing.Size(144, 20);
            this.seacrhSymbolLabel.TabIndex = 1;
            this.seacrhSymbolLabel.Text = "Search by Symbol";
            // 
            // searchSymbolBox
            // 
            this.searchSymbolBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchSymbolBox.Location = new System.Drawing.Point(16, 40);
            this.searchSymbolBox.Name = "searchSymbolBox";
            this.searchSymbolBox.Size = new System.Drawing.Size(174, 34);
            this.searchSymbolBox.TabIndex = 2;
            this.searchSymbolBox.TextChanged += new System.EventHandler(this.searchSymbolBox_TextChanged);
            // 
            // CheckPricesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 794);
            this.Controls.Add(this.searchSymbolBox);
            this.Controls.Add(this.seacrhSymbolLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CheckPricesWindow";
            this.Text = "CheckPrices";
            this.Load += new System.EventHandler(this.CheckPrices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURRENCYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kASETY_407_02DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KASETY_407_02DataSet kASETY_407_02DataSet;
        private System.Windows.Forms.BindingSource cURRENCYBindingSource;
        private KASETY_407_02DataSetTableAdapters.__CURRENCYTableAdapter ___CURRENCYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label seacrhSymbolLabel;
        private System.Windows.Forms.TextBox searchSymbolBox;
    }
}