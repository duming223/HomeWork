using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._17bang
{
    public class User
    {
        public int ID { get; }
        public int Password;
        public string Name { get; set; }
        public TokenManager TokenManager { get; set; }

        public User(int id, int password, string name)
        {
            ID = id;
            Password = password;
            Name = name;
        }
    }
}
