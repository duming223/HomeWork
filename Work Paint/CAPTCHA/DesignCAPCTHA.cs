using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace WorkPaint.CAPTCHA
{
    class DesignCAPCTHA
    {

        public void CreateCAPCTHA()
        {
            Map captcha = new Map();
            MapColor mapColor = new MapColor();
            MapLine mapLine = new MapLine();
            MapPixel mapPixel = new MapPixel();
            MapString mapString = new MapString();
            Bitmap bitmap = captcha.CreateMap();
            mapColor.CreateMapColor(bitmap);
            mapLine.Createline(bitmap);
            mapPixel.CreatePixel(bitmap);
            mapString.CreateString(bitmap);
            bitmap.Save(@"C:\Users\meing\Desktop\验证码.jpg", ImageFormat.Jpeg);
            Console.WriteLine("验证码已在桌面生成成功！");
        }
        public DesignCAPCTHA()
        {

        }

    }
}
