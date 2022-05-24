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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            /*
            Currency krw = new Currency();
            krw.Name = "Won Poludniowokoreanski";
            krw.Symbol = "KRW";
            krw.Price = 0.3454;
            krw.AddToDB();
            */
        }

        // buttonCheckPrice
        private void buttonCheckPrice_MouseEnter(object sender, EventArgs e)
        {
            buttonCheckPrice.BackColor = Color.LightGreen;
        }

        private void buttonCheckPrice_MouseLeave(object sender, EventArgs e)
        {
            buttonCheckPrice.BackColor = Color.Transparent;
        }

        private void buttonCheckPrice_Click(object sender, EventArgs e)
        {
            CheckPricesWindow checkPricesWindow = new CheckPricesWindow();
            checkPricesWindow.Show();
        }

        // buttonCorrectPrice
        private void buttonEditData_MouseEnter(object sender, EventArgs e)
        {
            buttonEditData.BackColor = Color.IndianRed;
        }

        private void buttonEditData_MouseLeave(object sender, EventArgs e)
        {
            buttonEditData.BackColor = Color.Transparent;
        }

        private void buttonEditData_Click(object sender, EventArgs e)
        {
            CurrencyAddWindow currencyAddWindow = new CurrencyAddWindow();
            currencyAddWindow.Show();
        }

        // buttonShowCurrency
        private void buttonShowCurrency_MouseEnter(object sender, EventArgs e)
        {
            buttonShowCurrency.BackColor = Color.Gold;
        }

        private void buttonShowCurrency_MouseLeave(object sender, EventArgs e)
        {
            buttonShowCurrency.BackColor = Color.Transparent;
        }

        private void buttonShowCurrency_Click(object sender, EventArgs e)
        {
            CurrencyDisplayWindow_Subwindow currencyChoiceWindow = new CurrencyDisplayWindow_Subwindow();
            currencyChoiceWindow.Show();
        }
    }
}
