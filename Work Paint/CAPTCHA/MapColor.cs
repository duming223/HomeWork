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
        public Bitmap CaeateMapColor(Bitmap bitmap)
        {
            Graphics g = Graphics.FromImage(bitmap);
            Console.WriteLine("提示：请输入验证码的背景颜色！\n      红色：r  绿色：g 蓝色：b");
            try
            {
                do
                {
                    string input = Console.ReadLine().ToLower();
                    Graphics graphics = Graphics.FromImage(bitmap);
                    if (input == "r")
                    {
                        graphics.Clear(Color.Red);
                        Console.WriteLine("OK RED!");
                        break;
                    }
                    else if (input == "g")
                    {
                        Console.WriteLine("2");
                        graphics.Clear(Color.Green);
                        break;
                    }
                    else if (input == "OK GREEN!")
                    {
                        Console.WriteLine("OK BLUE!");
                        graphics.Clear(Color.Blue);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("输入错误请重新输入!");
                    }
                } while (true);
            }
            catch (Exception e)
            {
                throw new ExceptionLog(e);
            }
            return bitmap;
        }
    }
}
