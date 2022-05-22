using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange
{
    class CurrencyPic
    {
        Image image;
        float direction;
        float x, y;
        string symbol;

        public float Direction { get => direction; set => direction = value; }
        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public string Symbol { get => symbol; set => symbol = value; }

        public CurrencyPic(string imagePath)
        {
            //string imagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"images\{Symbol}.png");
            image = Image.FromFile(imagePath);
        }

        public void Draw(Graphics grph)
        {
            grph.TranslateTransform(X, Y);
            grph.RotateTransform(direction);
            grph.ScaleTransform(0.4f, 0.4f);
            grph.DrawImage(image, -image.Width / 2, -image.Height / 2);
        }
    }
}
