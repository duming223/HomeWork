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
            try
            {
                Console.WriteLine("提示：请输入验证码的长！");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("提示：请输入验证码的宽！");
                int y = Convert.ToInt32(Console.ReadLine());
                Bitmap bitmap = new Bitmap(x, y);
                return bitmap;
            }
            catch (Exception e)
            {
                throw
            }

        }
    }
}
