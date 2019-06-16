using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkPaint.CAPTCHA
{
   public class ExceptionLog:Exception
    {
        public ExceptionLog(string message)
        {
        }
        public ExceptionLog(Exception e)
        {
            File.AppendAllText("C:\\Users\\meing\\Desktop\\error.log", e.ToString() + Environment.NewLine);
        }
    }
}
