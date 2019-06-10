using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work
{
    interface IArithmetc
    {
        int Add(int a, int b);
        double Sub(double a, double b);
    }

    class Number : IArithmetc //接口调用 number类 时 都可以调用  number 的实例也可以调用 add sub。
    {
        public int Add(int a, int b)
        {
            return a +b;
        }

        public double Sub(double a, double b)
        {
            return a-b;
        }
    }

    class Add : IArithmetc//接口调用时 只能调用 add方法  sub没有实现
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public double Sub(double a, double b)
        {
            throw new NotImplementedException();
        }

        int IArithmetc.Add(int a, int b)
        {
            return a + b;
        }
    }

    class Sub : IArithmetc// 借口调用时 只能调用 sub方法 add没有实现
    {
        public double sub(double a, double b)
        {
            return a - b;
        }

        public int Add(int a, int b)
        {
            throw new NotImplementedException();
        }

        double IArithmetc.Sub(double a, double b)
        {
            return a - b;
        }
    }
}
