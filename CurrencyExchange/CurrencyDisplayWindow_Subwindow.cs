using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CurrencyExchange
{
    public partial class CurrencyDisplayWindow_Subwindow : Form
    {
        string imagesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"images\");
        public CurrencyDisplayWindow_Subwindow()
        {
            InitializeComponent();
        }

        private void CurrencyDisplayWindow_Subwindow_Load(object sender, EventArgs e)
        {
            string[] imagesArray = Directory.GetFiles(imagesPath, "*.png");

            foreach (string image in imagesArray)
            {
                string imageFilename = Path.GetFileName(image);
                listBoxCurrency.Items.Add(imageFilename.Replace(".png",""));
            }
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            try
            {
                string currencyImgPath = $"{imagesPath}{listBoxCurrency.SelectedItem.ToString()}.png";
                CurrencyDisplayWindow currencyWindow = new CurrencyDisplayWindow(currencyImgPath);

                this.Close();
                currencyWindow.Show();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
