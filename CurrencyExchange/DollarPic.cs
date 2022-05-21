using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange
{
    class DollarPic
    {
        Image image;
        float direction;
        float x, y;

        public DollarPic()
        {
            string imagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"images\dollar.png");
            image = Image.FromFile(imagePath);
        }

        public float Direction { get => direction; set => direction = value; }
        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }

        public void Draw(Graphics grph)
        {
            grph.TranslateTransform(X, Y);
            grph.RotateTransform(direction);
            grph.ScaleTransform(0.4f, 0.4f);
            grph.DrawImage(image, -image.Width / 2, -image.Height / 2);
        }
    }
}
