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
    public partial class CurrencyDisplayWindow : Form
    {
        CurrencyPic currencyPic;

        public CurrencyDisplayWindow(string currencyPicPath)
        {
            int windowWidth = this.Size.Width;
            int windowHeight = this.Size.Height;

            currencyPic = new CurrencyPic(currencyPicPath);
            currencyPic.X = windowWidth;
            currencyPic.Y = windowHeight / 2;

            InitializeComponent();
        }

        private void DollarWindow_Paint(object sender, PaintEventArgs e)
        {
            currencyPic.Draw(e.Graphics);
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            currencyPic.Direction -= 5;
            Refresh();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            currencyPic.Direction += 5;
            Refresh();
        }

        private void resetPositionButton_Click(object sender, EventArgs e)
        {
            currencyPic.Direction = 0;
            Refresh();
        }
    }
}
