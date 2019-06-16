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
        public MapPixel(Bitmap bitmap)
        {
            Random random = new Random();
            Console.WriteLine("请输入像素点个数（300-500）！");
            try
            {
                Console.WriteLine("请输入像素点个数（300-500）！");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input > 300 && input < 500)
                {

                    for (int i = 0; i < input / 3; i++)
                    {
                        bitmap.SetPixel(random.Next(200), random.Next(100), Color.Red);
                        bitmap.SetPixel(random.Next(200), random.Next(100), Color.Green);
                        bitmap.SetPixel(random.Next(200), random.Next(100), Color.Blue);
                    }
                }
                else
                {
                    throw new Exception("非法输入！");
                }
            }
            catch (Exception e)
            {
                throw new ExceptionLog(e);
            }



        }

    }
}
