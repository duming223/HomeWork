using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using WorkPaint.CAPTCHA;
using System.Xml.Linq;
using System.Threading;
using System.Threading.Tasks;




namespace WorkPaint
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory(200, 100);
            SFactory sfactory = new SFactory(factory);

            sfactory.SAction();

            // Thread thread = Thread.CurrentThread;

            //Thread thread = new Thread(new ThreadStart(sfactory.SAction));
            

            //Console.WriteLine(thread.Name);
        }
    }
    #region 随机生成验证码！



    class Factory
    {
        private Bitmap _bitmap { get; set; }

        private Graphics _graphics { get; set; }

        Random random = new Random();

        public Factory(int x, int y)
        {
            //if (_bitmap.Height + _bitmap.Width > 500)
            //{
            //    throw new ParamaeterException();
            //}
            _bitmap = new Bitmap(x, y);
        }

        public void CreateGraphics()
        {
            //        Console.WriteLine($"准备生成画布时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
            //$" TaskID:{Task.CurrentId}");
            _graphics = Graphics.FromImage(_bitmap);
            _graphics.Clear(Color.AliceBlue);
                        Console.WriteLine($"生成画布时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
            $" TaskID:{Task.CurrentId}");
        }

        public void CreateLine()
        {
            //        Console.WriteLine($"准备生成线条时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
            //$" TaskID:{Task.CurrentId}");
            for (int i = 0; i < 30; i++)
            {
                _graphics.DrawLine(
                    new Pen(Color.FromArgb(random.Next(50, 200), random.Next(100, 150),
                                     random.Next(100, 200), random.Next(100, 150))),
                    new Point(random.Next(_bitmap.Width), random.Next(_bitmap.Height)),
                    new Point(random.Next(_bitmap.Width), random.Next(_bitmap.Width))
                    );
                                Console.WriteLine($"生成线条时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
                $" TaskID:{Task.CurrentId}");
            }
        }

        public void CreatePixel()
        {
            //     Console.WriteLine($"准备生成干扰点时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
            //$" TaskID:{Task.CurrentId}");
            for (int i = 0; i < 300; i++)
            {
                _bitmap.SetPixel(random.Next(_bitmap.Width), random.Next(_bitmap.Height), Color.Red);
                _bitmap.SetPixel(random.Next(_bitmap.Width), random.Next(_bitmap.Height), Color.Blue);
            }
            Console.WriteLine($"生成干扰点时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
            $" TaskID:{Task.CurrentId}");
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
                 random.Next(2, 255))), new PointF(40, 40));
            _graphics.DrawString(y[random.Next(5)],
                new Font("宋体", random.Next(40, 50)),
                new SolidBrush(Color.FromArgb(random.Next(200, 255),
                random.Next(2, 255), random.Next(2, 255),
                random.Next(2, 255))), new PointF(80, 30));
            _graphics.DrawString(z[random.Next(5)],
                 new Font("宋体", random.Next(30, 60)),
                 new SolidBrush(Color.FromArgb(random.Next(200, 255),
                 random.Next(2, 255), random.Next(2, 255),
                 random.Next(2, 255))), new PointF(120, 40));
            _graphics.DrawString(x[random.Next(5)],
                new Font("宋体", random.Next(30, 50)),
                new SolidBrush(Color.FromArgb(random.Next(200, 255),
                random.Next(2, 255), random.Next(2, 255),
                random.Next(2, 255))), new PointF(160, 30));
        }

        public void SaveCAPTCHA()
        {
            //        Console.WriteLine($"准备保存验证码时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
            //$" TaskID:{Task.CurrentId}");
            _bitmap.Save(@"C:\Users\meing\Desktop\验证码.jpg", ImageFormat.Jpeg);
                        Console.WriteLine($"保存验证码时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
            $" TaskID:{Task.CurrentId}");
        }

        public void Action()
        {
            this.CreateGraphics();
            this.CreateLine();
            this.CreatePixel();
            this.CreateString();
            this.SaveCAPTCHA();
        }
    }

    class SFactory
    {
        private Factory _factory;

        public SFactory(Factory factory)
        {
            this._factory = factory;
        }

        //创建一个新的前台线程（Thread），在这个线程上运行生成随机字符串的代码
        public void SAction()
        {
            Thread thread = new Thread(new ThreadStart(_factory.Action));
            thread.Start();
            this.SGraphics();
            this.SLine();
            this.SPixe();
            this.Save();
        }

        //在一个任务（Task）中生成画布
        public void SGraphics()
        {
            Console.WriteLine($"准备生成画布时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
$" TaskID:{Task.CurrentId}");
            Action graphics = new Action(_factory.CreateGraphics);
            Task t1 = new Task(graphics);
            t1.Start();
        }

        //使用生成的画布，用两个任务完成： 在画布上添加干扰线条 
        public void SLine()
        {
            Task t2 = Task.Run(() => _factory.CreateLine());
            Console.WriteLine($"准备添加线条时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
$" TaskID:{Task.CurrentId}");
        }

        //在画布上添加干扰点
        public void SPixe()
        {
            Console.WriteLine($"准备添加干扰点时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
            $" TaskID:{Task.CurrentId}");
            Task t3 = Task.Run(() => _factory.CreatePixel());
        }

        //将生成的验证码图片异步的存入文件
        public async void Save()
        {
            Console.WriteLine($"准备将生成的验证码图片异步的存入文件时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
   $" TaskID:{Task.CurrentId}");
            await Task.Run(() => { _factory.SaveCAPTCHA(); });
        }

    }

    class ParamaeterException : Exception
    {

    }
}

#endregion
