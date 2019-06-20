using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace WorkPaint.CAPTCHA
{
    public class Map
    {
        public Bitmap CreateMap()
        {
            int x = 0;
            int y = 0;

            Console.WriteLine("提示：请输入验证码的长(200-600)！");
            while (true)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a >=200 && a <=600)
                {
                    x = a;
                    break;
                }
                else
                {
                    Console.WriteLine("输入错误请重新输入验证码的长！");
                }
            }

            Console.WriteLine("提示：请输入验证码的宽(100-300)！");
            while (true)
            {
                int b = Convert.ToInt32(Console.ReadLine());
                if (b >= 100 && b <= 300)
                {
                    y = b;
                    break;
                }
                else
                {
                    Console.WriteLine("输入错误请重新输入验证码的宽！");
                }
            }
          
            Bitmap bitmap = new Bitmap(x, y);
            return bitmap;

        }
    }
}
