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
    public partial class CurrencyAddWindow : Form
    {
        public CurrencyAddWindow()
        {
            InitializeComponent();
        }

        private void buttonAddCurrency_Click(object sender, EventArgs e)
        {
            try
            {
                Currency newCurr = new Currency();

                string currName = textBoxCurrencyName.Text;
                string currSymbol = textBoxCurrencySymbol.Text;
                double currPrice = double.Parse(textBoxCurrencyPrice.Text);

                newCurr.Name = currName;
                newCurr.Symbol = currSymbol;
                newCurr.Price = currPrice;
                newCurr.Updated = DateTime.Now;

                newCurr.AddToDB();
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
