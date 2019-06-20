using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace WorkPaint.CAPTCHA
{
    class MapString
    {
        public Bitmap CreateString(Bitmap bitmap)
        {
            Random random = new Random();
            Graphics g = Graphics.FromImage(bitmap);

            string[] x = new string[5] { "x", "y", "z", "w", "s" };
            string[] y = new string[5] { "h", "l", "d", "m", "a" };
            string[] z = new string[5] { "i", "k", "o", "n", "c" };

            g.DrawString(x[random.Next(5)],
                new Font("宋体",bitmap.Height/2),
                new SolidBrush(Color.FromArgb(random.Next(200, 255),
                random.Next(2, 255), random.Next(2, 255),
                random.Next(2, 255))), new PointF(bitmap.Width/10,bitmap.Height/3));
            g.DrawString(y[random.Next(5)],
                new Font("宋体", bitmap.Height / 3),
                new SolidBrush(Color.FromArgb(random.Next(200, 255),
                random.Next(2, 255), random.Next(2, 255),
                random.Next(2, 255))), new PointF(bitmap.Width / 7, bitmap.Height / 2));
            g.DrawString(z[random.Next(5)],
                new Font("宋体", bitmap.Height / 2),
                new SolidBrush(Color.FromArgb(random.Next(200, 255),
                random.Next(2, 255), random.Next(2, 255),
                random.Next(2, 255))), new PointF(bitmap.Width / 4, bitmap.Height / 3));
            g.DrawString(x[random.Next(5)],
                new Font("宋体", bitmap.Height / 3),
                new SolidBrush(Color.FromArgb(random.Next(200, 255),
                random.Next(2, 255), random.Next(2, 255),
                random.Next(2, 255))), new PointF(bitmap.Width / 2, bitmap.Height / 2));

            return bitmap;
        }
    }
}
