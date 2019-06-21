using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using WorkPaint.CAPTCHA;
using System.Xml.Linq;


namespace WorkPaint
{
    class Program
    {
        static void Main(string[] args)
        {
            DesignCAPCTHA designCAPCTHA = new DesignCAPCTHA();
            designCAPCTHA.CreateCAPCTHA();

            //CAPTCHA cAPTCHA = new CAPTCHA(200, 100);
            //Project project = new Project(cAPTCHA._bitmap);
            //project.CreateBottomColour();
            //project.CreateLine();
            //project.CreatePixel();
            //project.CreateString();
            //project.SaveCAPTCHA();
            //Console.WriteLine("生成成功！");

            //DesignCAPCTHA designCAPCTHA = new DesignCAPCTHA();
            //designCAPCTHA.CreateCAPCTHA();

            //////////////在桌面随机生成以个长 200 高 100 的随机生成验证码//////////////
        }

        #region 随机生成验证码！

        class CAPTCHA
        {
            internal Bitmap _bitmap { get; }
            public CAPTCHA(int x, int y)
            {
                _bitmap = new Bitmap(x, y);
            }
        }

        class Project
        {
            private Bitmap _bitmap { get; }

            private Graphics _graphics { get; }

            Random random = new Random();

            public Project(Bitmap bitmap)
            {
                _bitmap = bitmap;
                _graphics = Graphics.FromImage(bitmap);
            }

            public void CreateBottomColour()
            {
                _graphics.Clear(Color.AliceBlue);
            }

            public void CreateLine()
            {
                for (int i = 0; i < 30; i++)
                {
                    _graphics.DrawLine(
                        new Pen(Color.FromArgb(random.Next(50, 200), random.Next(100, 150),
                                         random.Next(100, 200), random.Next(100, 150))),
                        new Point(random.Next(200), random.Next(random.Next(25, 75))),
                        new Point(random.Next(100, 200), random.Next(random.Next(200)))
                        );
                }
            }

            public void CreatePixel()
            {
                for (int i = 0; i < 300; i++)
                {
                    _bitmap.SetPixel(random.Next(200), random.Next(100), Color.Red);
                    _bitmap.SetPixel(random.Next(200), random.Next(100), Color.Blue);
                }
            }

            public void CreateString()
            {
                string[] x = new string[5] { "x", "y", "z", "w", "s" };
                string[] y = new string[5] { "h", "l", "d", "m", "a" };
                string[] z = new string[5] { "i", "k", "o", "n", "c" };
                _graphics.DrawString(x[random.Next(5)],
                     new Font("宋体", random.Next(50, 70)),
                     new SolidBrush(Color.FromArgb(random.Next(200, 255),
                     random.Next(2, 255), random.Next(2, 255),
                     random.Next(2, 255))), new PointF(30, 20));
                _graphics.DrawString(y[random.Next(5)],
                    new Font("宋体", random.Next(40, 50)),
                    new SolidBrush(Color.FromArgb(random.Next(200, 255),
                    random.Next(2, 255), random.Next(2, 255),
                    random.Next(2, 255))), new PointF(70, 30));
                _graphics.DrawString(z[random.Next(5)],
                     new Font("宋体", random.Next(30, 60)),
                     new SolidBrush(Color.FromArgb(random.Next(200, 255),
                     random.Next(2, 255), random.Next(2, 255),
                     random.Next(2, 255))), new PointF(100, 20));
                _graphics.DrawString(x[random.Next(5)],
                    new Font("宋体", random.Next(30, 50)),
                    new SolidBrush(Color.FromArgb(random.Next(200, 255),
                    random.Next(2, 255), random.Next(2, 255),
                    random.Next(2, 255))), new PointF(130, 30));
            }
            public void SaveCAPTCHA()
            {
                _bitmap.Save(@"C:\Users\meing\Desktop\验证码.jpg", ImageFormat.Jpeg);
            }
        }
    }
} 
#endregion
