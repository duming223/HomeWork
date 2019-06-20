using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WorkPaint.CAPTCHA
{
    class MapPixel
    {
        public Bitmap CreatePixel(Bitmap bitmap)
        {
            Random random = new Random();
            Console.WriteLine("请输入像素点个数（300-500）！");
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input >=300 && input <=500)
                {
                    for (int i = 0; i < input / 3; i++)
                    {
                        bitmap.SetPixel(random.Next(bitmap.Width), random.Next(bitmap.Height), Color.Red);
                        bitmap.SetPixel(random.Next(bitmap.Width), random.Next(bitmap.Height), Color.Green);
                        bitmap.SetPixel(random.Next(bitmap.Width), random.Next(bitmap.Height), Color.Blue);
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
