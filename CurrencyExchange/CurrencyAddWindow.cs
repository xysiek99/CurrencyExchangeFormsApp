﻿using System;
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
                string currName = textBoxCurrencyName.Text;
                string currSymbol = textBoxCurrencySymbol.Text;
                double currPrice = double.Parse(textBoxCurrencyPrice.Text);
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
