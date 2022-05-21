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
        private void buttonCorrectPrice_MouseEnter(object sender, EventArgs e)
        {
            buttonCorrectPrice.BackColor = Color.IndianRed;
        }

        private void buttonCorrectPrice_MouseLeave(object sender, EventArgs e)
        {
            buttonCorrectPrice.BackColor = Color.Transparent;
        }

        // buttonDollar
        private void buttonDollar_MouseEnter(object sender, EventArgs e)
        {
            buttonDollar.BackColor = Color.Gold;
        }

        private void buttonDollar_MouseLeave(object sender, EventArgs e)
        {
            buttonDollar.BackColor = Color.Transparent;
        }

        private void buttonDollar_Click(object sender, EventArgs e)
        {
            DollarWindow dollarWindow = new DollarWindow();
            dollarWindow.Show(); // Moze dodac jakis warunek zeby nie mozna bylo otworzyc okienka jak juz jest otwarte? [NIEKONIECZNE]
        }
    }
}
