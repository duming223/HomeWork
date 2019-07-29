using BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBFactory
{
    class Box
    {
        private static  string _passWord = "3861409";

        public static User Xr = new User
        {
            //有影子属性不能赋值 id由数据库赋值！
            //Id = 1,
            UserName = "行人",
            PassWord = User.GetMd5Hash(_passWord),
        };
        public static User Dm = new User
        {
            //Id=2,
            UserName = "都明",
            PassWord = User.GetMd5Hash(_passWord),
        };
    }
}
