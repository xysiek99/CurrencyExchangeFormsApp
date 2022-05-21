using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchange
{
    public partial class CheckPricesWindow : Form
    {
        public CheckPricesWindow()
        {
            InitializeComponent();
        }

        private void CheckPrices_Load(object sender, EventArgs e)
        {
            this.___CURRENCYTableAdapter.Fill(this.kASETY_407_02DataSet.@__CURRENCY);
        }

        private void searchSymbolBox_TextChanged(object sender, EventArgs e)
        {
            // metoda Fill wykonuje zapytanie do bazy danych !!!!!!!!!!!!!!!! 
            ___CURRENCYTableAdapter.FillByCurrencySymbol(kASETY_407_02DataSet.@__CURRENCY, searchSymbolBox.Text);
        }
    }
}
