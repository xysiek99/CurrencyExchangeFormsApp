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
    public partial class DollarWindow : Form
    {
        DollarPic dollarPic;

        public DollarWindow()
        {
            int windowWidth = this.Size.Width;
            int windowHeight = this.Size.Height;

            dollarPic = new DollarPic();
            dollarPic.X = windowWidth;
            dollarPic.Y = windowHeight / 2;

            InitializeComponent();
        }

        private void DollarWindow_Paint(object sender, PaintEventArgs e)
        {
            dollarPic.Draw(e.Graphics);
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            dollarPic.Direction -= 5;
            Refresh();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            dollarPic.Direction += 5;
            Refresh();
        }

        private void resetPositionButton_Click(object sender, EventArgs e)
        {
            dollarPic.Direction = 0;
            Refresh();
        }
    }
}
