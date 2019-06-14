using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Work_Paint
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap bitmap = new Bitmap(200, 100);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.AliceBlue);

            Random random = new Random();
            Random random1 = new Random();
            Random random2 = new Random();

            for (int i = 0; i < 30; i++)
            {
                g.DrawLine(
                    new Pen(Color.FromArgb(random.Next(50, 200), random.Next(100, 150), random1.Next(100, 200), random2.Next(100, 150))),
                    new Point(random.Next(200), random1.Next(random.Next(25, 75))),
                    new Point(random.Next(100, 200), random2.Next(random1.Next(200)))
                    );
                bitmap.SetPixel(random1.Next(200), random2.Next(100), Color.Black);
            }
            for (int i = 0; i < 300; i++)
            {
                bitmap.SetPixel(random1.Next(200), random2.Next(100), Color.Red);
                for (int j = 0; j < 2; j++)
                {
                    bitmap.SetPixel(random1.Next(200), random2.Next(100), Color.Blue);
                }
            }
            string[] x = new string[5] { "x", "y", "z", "w", "s" };
            string[] y = new string[5] { "h", "l", "d", "m", "a" };
            string[] z = new string[5] { "i", "k", "o", "n", "c" };
            g.DrawString(x[random.Next(5)], new Font("宋体", random.Next(50, 70)), new SolidBrush(Color.FromArgb(random.Next(150, 255), random.Next(100, 255), random1.Next(100, 255), random2.Next(100, 255))), new PointF(30, 20));
            g.DrawString(y[random1.Next(5)], new Font("宋体", random.Next(40, 50)), new SolidBrush(Color.FromArgb(random.Next(100, 255), random.Next(100, 255), random1.Next(200, 255), random2.Next(100, 255))), new PointF(70, 30));
            g.DrawString(z[random2.Next(5)], new Font("宋体", random.Next(30, 60)), new SolidBrush(Color.FromArgb(random.Next(180, 255), random.Next(100, 255), random1.Next(100, 255), random2.Next(100, 255))), new PointF(100, 20));
            g.DrawString(x[random1.Next(5)], new Font("宋体", random.Next(30, 50)), new SolidBrush(Color.FromArgb(random.Next(200, 255), random.Next(100, 255), random1.Next(200, 255), random2.Next(100, 255))), new PointF(130, 30));

            bitmap.Save(@"C:\Users\meing\repository\one.jpg", ImageFormat.Jpeg);

        }
    }
}
