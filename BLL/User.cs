﻿using BLL.Repository;
using System;

namespace BLL
{
    public class User
    {
        private UserReporsitory _userReporsitory;

        public User()
        {
            _userReporsitory = new UserReporsitory();
        }

        public int ID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int Integral { get; set; }

        public void Register()
        {

        }
    }
}