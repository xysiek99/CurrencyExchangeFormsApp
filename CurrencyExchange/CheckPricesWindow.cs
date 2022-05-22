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
            DBCurrency dbCurrency = new DBCurrency();
            var currencyData = dbCurrency.Currencies.ToList();

            currencyBindingSource1.DataSource = currencyData;
        }

        private void searchSymbolBox_TextChanged(object sender, EventArgs e)
        {
            DBCurrency dbCurrency = new DBCurrency();
            var currencyData = dbCurrency.Currencies
                .Where(curr => curr.Symbol.StartsWith(searchSymbolBox.Text) || curr.Name.StartsWith(searchSymbolBox.Text))
                .ToList();

            currencyBindingSource1.DataSource = currencyData;
        }
    }
}
