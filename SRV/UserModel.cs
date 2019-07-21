using BLL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV
{
    public class UserModel
    {
        private UserReporsitory userReporsitory;
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Md5PassWord { get; set; }

        public UserModel()
        {
            userReporsitory = new UserReporsitory();
        }


    }
}
