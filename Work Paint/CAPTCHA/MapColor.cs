using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace WorkPaint.CAPTCHA
{
    class MapColor
    {
        public Bitmap CreateMapColor(Bitmap bitmap)
        {
            Graphics g = Graphics.FromImage(bitmap);
            Console.WriteLine("提示：请输入验证码的背景颜色！\n      红色：r  绿色：g 蓝色：b");

            do
            {
                string input = Console.ReadLine().ToLower();
                Graphics graphics = Graphics.FromImage(bitmap);
                if (input == "r")
                {
                    graphics.Clear(Color.LightPink);
                    Console.WriteLine("OK RED!");
                    break;
                }
                else if (input == "g")
                {
                    Console.WriteLine("OK GREE!");
                    graphics.Clear(Color.LightGreen);
                    break;
                }
                else if (input == "b")
                {
                    Console.WriteLine("OK BLUE!");
                    graphics.Clear(Color.LightBlue);
                    break;
                }
                else
                {
                    Console.WriteLine("输入错误请重新输入!");
                }
            } while (true);
            return bitmap;
        }

    }
}

