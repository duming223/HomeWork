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
            Random random = new Random();

            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input >= 10 && input <= 50)
                {
                    for (int i = 0; i < input; i++)
                    {
                        Graphics g = Graphics.FromImage(bitmap);
                        g.DrawLine(
                            new Pen(Color.FromArgb(random.Next(200, 255), random.Next(100, 150), random.Next(100, 200), random.Next(100, 150))),
                            new Point(random.Next(bitmap.Width), random.Next( bitmap.Height)),
                            new Point(random.Next( bitmap.Width), random.Next( bitmap.Height))
                            );
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("输入错误请重新输入！");
                }
            }

            return bitmap;
        }
    }
}

