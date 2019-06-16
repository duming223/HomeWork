using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace WorkPaint.CAPTCHA
{
    class MapLine
    {
        public Bitmap Createline(Bitmap bitmap)
        {
            Console.WriteLine("请输入验证码线条数(10-50)！");
            int input = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            if (input > 10 && input < 50)
            {
                for (int i = 0; i < input; i++)
                {
                    Graphics g = Graphics.FromImage(bitmap);
                    g.DrawLine(
                        new Pen(Color.FromArgb(random.Next(255))),
                        new Point(random.Next(100, bitmap.Width), random.Next(50, bitmap.Height)),
                        new Point(random.Next(50, bitmap.Width), random.Next(100, bitmap.Height))
                        );
                }
            }
            else
            {
                throw new 
                //throw new Exception("非法输入！");
            }
            return bitmap;
        }

    }
}
