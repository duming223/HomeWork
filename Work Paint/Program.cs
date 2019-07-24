using System;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;




namespace WorkPaint
{
    class Program
    {
        static void Main(string[] args)
        {
            //逻辑
            //生成一个验证码 首先需要一个 画板 和 一张画布  需要在画板上添加干扰点   画布依赖于画板
            //画布上需要添加 干扰线条   和  生成的随机字符  这些都需要在同一个画布上进行
            //先生成画板 再生成画布 

            Captcah captcah = new Captcah();

            captcah.CreateCaptcha(300, 200);
            //创建一个新的前台线程（Thread），在这个线程上运行生成随机字符串的代码
            //Thread current = Thread.CurrentThread;
            //Thread current = new Thread(new ThreadStart(captcah.CreateCaptcha(300, 200));

            //在一个任务（Task）中生成画布

            //在画布上添加干扰线条 

            //在画板上添加干扰点

            //将生成的验证码图片异步的存入文件

        }
    }
    #region 随机生成验证码！

    class Captcah
    {
        private Bitmap _bitmap;
        private Graphics _graphics;
        private Random _random = new Random();
        private string _code;

        //生成一个画板 宽不超过 300 高不超过 200
        private void CreateBitmap(int width, int height)
        {
            if (width > 300 || height > 200)
            {
                throw new Exception("超出最大尺寸！");
            }

            _bitmap = new Bitmap(width, height);
            Console.WriteLine($"①生成画板时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
             $" TaskID:{Task.CurrentId}");
        }

        //创建一个画布
        private void CreateGraphics()
        {
            if (_bitmap == null)
            {
                throw new Exception("还没有画板！");
            }

            _graphics = Graphics.FromImage(_bitmap);
            _graphics.Clear(Color.AliceBlue);

            Console.WriteLine($"②生成画布时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
            $" TaskID:{Task.CurrentId}");
        }

        //在画布上创建线条
        private void CreateLine()
        {
            if (_graphics == null)
            {
                throw new Exception("还没有画布！");
            }

            Console.WriteLine($"③生成线条时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
            $" TaskID:{Task.CurrentId}");

            for (int i = 0; i < 30; i++)
            {
                _graphics.DrawLine(
                    new Pen(Color.FromArgb(_random.Next(50, 200), _random.Next(100, 150),
                                     _random.Next(100, 200), _random.Next(100, 150))),
                    new Point(_random.Next(_bitmap.Width), _random.Next(_bitmap.Height)),
                    new Point(_random.Next(_bitmap.Width), _random.Next(_bitmap.Width))
                    );
            }
        }

        //在画板上添加干扰点
        private void CreatePixel()
        {
            if (_bitmap == null)
            {
                throw new Exception("还没有画板!");
            }

            Console.WriteLine($"④生成干扰点时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
            $" TaskID:{Task.CurrentId}");

            for (int i = 0; i < 300; i++)
            {
                _bitmap.SetPixel(_random.Next(_bitmap.Width), _random.Next(_bitmap.Height), Color.Red);
                _bitmap.SetPixel(_random.Next(_bitmap.Width), _random.Next(_bitmap.Height), Color.Blue);
            }
        }

        //将生成的字符添加到画布上
        private void CreateString()
        {
            if (_graphics == null)
            {
                throw new Exception("还没有画布!");
            }

            Console.WriteLine($"⑥将字符添加到画布时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
            $" TaskID:{Task.CurrentId}");
            //将_code转换为char数组
            char[] ccode = _code.ToCharArray();

            _graphics.DrawString(ccode[0].ToString(),
                 new Font("宋体", _random.Next(50, 70)),
                 new SolidBrush(Color.FromArgb(_random.Next(200, 255),
                 _random.Next(2, 255), _random.Next(2, 255),
                 _random.Next(2, 255))), new PointF(40, 40));
            _graphics.DrawString(ccode[1].ToString(),
                new Font("宋体", _random.Next(40, 50)),
                new SolidBrush(Color.FromArgb(_random.Next(200, 255),
                _random.Next(2, 255), _random.Next(2, 255),
                _random.Next(2, 255))), new PointF(80, 30));
            _graphics.DrawString(ccode[2].ToString(),
                 new Font("宋体", _random.Next(30, 60)),
                 new SolidBrush(Color.FromArgb(_random.Next(200, 255),
                 _random.Next(2, 255), _random.Next(2, 255),
                 _random.Next(2, 255))), new PointF(120, 40));
            _graphics.DrawString(ccode[3].ToString(),
                new Font("宋体", _random.Next(30, 50)),
                new SolidBrush(Color.FromArgb(_random.Next(200, 255),
                _random.Next(2, 255), _random.Next(2, 255),
                _random.Next(2, 255))), new PointF(160, 30));
        }

        //将验证码保存在本地
        private void Save()
        {
            //        Console.WriteLine($"准备保存验证码时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
            //$" TaskID:{Task.CurrentId}");
            _bitmap.Save(@"C:\Users\meing\Desktop\验证码.jpg", ImageFormat.Jpeg);
            Console.WriteLine($"保存验证码时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
            $" TaskID:{Task.CurrentId}");
        }

        //获得验证码中的字符
        public string GetCode()
        {
            //如果还没有生成验证码 就抛出异常~
            if (_code == null)
            {
                throw new Exception("还没有生成字符！");
            }
            else
            {
                return _code;
            }
        }

        //创建一个验证码的字符
        private void CreateRandomCode()
        {
            Console.WriteLine($"⑤生成字符时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
            $" TaskID:{Task.CurrentId}");

            string[] x = new string[15] { "x", "y", "z", "w", "s", "h", "l", "d", "m", "a", "i", "k", "o", "n", "c" };
            for (int i = 0; i < 4; i++)
            {
                _code+=x[_random.Next(0, 14)];
            }
        }

        //生成验证码
        public void CreateCaptcha(int width, int height)
        {
            //确保画板生成以后 再生成画布
            Task map =Task.Run(() => CreateBitmap(width, height));
            map.ContinueWith((x) => CreateGraphics());
             
            //等待画布和画板都生成完毕以后再进行后续操作
            Thread.Sleep(1000);

            //在画布上添加线条
            Task line = Task.Run(() => CreateLine());
            
            //在画板上添加干扰点
            Task pixel = Task.Run(() => CreatePixel());

            //先生成随机字符 然后等待画布线条操作完毕以后 再把字符添加到画布上
            Task code = Task.Run(() => CreateRandomCode());
            line.ContinueWith((x) => CreateString());

        }

    }

    //class Caprcha
    //{
    //    private Bitmap _bitmap;
    //    private Graphics _graphics;
    //    private Random random;

    //    public void CreateGraphics()
    //    {
    //        Graphics graphics = Graphics.FromImage(_bitmap);
    //        _graphics.Clear(Color.AliceBlue);
    //        Console.WriteLine($"生成画布时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
    //        $" TaskID:{Task.CurrentId}");
    //    }

    //    public void CreateLine()
    //    {
    //        for (int i = 0; i < 30; i++)
    //        {
    //            _graphics.DrawLine(
    //                new Pen(Color.FromArgb(random.Next(50, 200), random.Next(100, 150),
    //                                 random.Next(100, 200), random.Next(100, 150))),
    //                new Point(random.Next(_bitmap.Width), random.Next(_bitmap.Height)),
    //                new Point(random.Next(_bitmap.Width), random.Next(_bitmap.Width))
    //                );
    //            Console.WriteLine($"生成线条时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
    //            $" TaskID:{Task.CurrentId}");
    //        }
    //    }

    //    public void CreatePixel()
    //    {
    //        for (int i = 0; i < 300; i++)
    //        {
    //            _bitmap.SetPixel(random.Next(_bitmap.Width), random.Next(_bitmap.Height), Color.Red);
    //            _bitmap.SetPixel(random.Next(_bitmap.Width), random.Next(_bitmap.Height), Color.Blue);
    //        }
    //        Console.WriteLine($"生成干扰点时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
    //        $" TaskID:{Task.CurrentId}");
    //    }

    //    public void CreateString()
    //    {
    //        string[] x = new string[5] { "x", "y", "z", "w", "s" };
    //        string[] y = new string[5] { "h", "l", "d", "m", "a" };
    //        string[] z = new string[5] { "i", "k", "o", "n", "c" };
    //        _graphics.DrawString(x[random.Next(5)],
    //             new Font("宋体", random.Next(50, 70)),
    //             new SolidBrush(Color.FromArgb(random.Next(200, 255),
    //             random.Next(2, 255), random.Next(2, 255),
    //             random.Next(2, 255))), new PointF(40, 40));
    //        _graphics.DrawString(y[random.Next(5)],
    //            new Font("宋体", random.Next(40, 50)),
    //            new SolidBrush(Color.FromArgb(random.Next(200, 255),
    //            random.Next(2, 255), random.Next(2, 255),
    //            random.Next(2, 255))), new PointF(80, 30));
    //        _graphics.DrawString(z[random.Next(5)],
    //             new Font("宋体", random.Next(30, 60)),
    //             new SolidBrush(Color.FromArgb(random.Next(200, 255),
    //             random.Next(2, 255), random.Next(2, 255),
    //             random.Next(2, 255))), new PointF(120, 40));
    //        _graphics.DrawString(x[random.Next(5)],
    //            new Font("宋体", random.Next(30, 50)),
    //            new SolidBrush(Color.FromArgb(random.Next(200, 255),
    //            random.Next(2, 255), random.Next(2, 255),
    //            random.Next(2, 255))), new PointF(160, 30));
    //    }

    //    public void SaveCAPTCHA()
    //    {
    //        //        Console.WriteLine($"准备保存验证码时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
    //        //$" TaskID:{Task.CurrentId}");
    //        _bitmap.Save(@"C:\Users\meing\Desktop\验证码.jpg", ImageFormat.Jpeg);
    //        Console.WriteLine($"保存验证码时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
    //        $" TaskID:{Task.CurrentId}");
    //    }
    //}

    //    class SFactory
    //    {
    //        private Factory _factory;

    //        public SFactory(Factory factory)
    //        {
    //            _factory = factory;
    //        }

    //        //创建一个新的前台线程（Thread），在这个线程上运行生成随机字符串的代码
    //        public void SAction()
    //        {

    //        }

    //        //在一个任务（Task）中生成画布
    //        public void SGraphics()
    //        {
    //            Console.WriteLine($"准备生成画布时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
    //$" TaskID:{Task.CurrentId}");
    //            Action graphics = new Action(_factory.CreateGraphics);
    //            Task t1 = new Task(graphics);
    //            t1.Start();
    //        }

    //        //使用生成的画布，用两个任务完成： 在画布上添加干扰线条 
    //        public void SLine()
    //        {
    //            Task t2 = Task.Run(() => _factory.CreateLine());
    //            Console.WriteLine($"准备添加线条时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
    //$" TaskID:{Task.CurrentId}");
    //        }

    //        //在画布上添加干扰点
    //        public void SPixe()
    //        {
    //            Console.WriteLine($"准备添加干扰点时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
    //            $" TaskID:{Task.CurrentId}");
    //            Task t3 = Task.Run(() => _factory.CreatePixel());
    //        }

    //        //将生成的验证码图片异步的存入文件
    //        public async void Save()
    //        {
    //            Console.WriteLine($"准备将生成的验证码图片异步的存入文件时的\n ThreadID:{Thread.CurrentThread.ManagedThreadId}\n" +
    //   $" TaskID:{Task.CurrentId}");
    //            await Task.Run(() => { _factory.SaveCAPTCHA(); });
    //        }

    //    }
}

#endregion
