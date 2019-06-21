using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._17bang
{
    class User
    {
        public int ID { get; set; }
        public int Password { get; set; }
        public string Name { get; set; }

        public User(int id, int password, string name)
        {
            ID = id;
            Password = password;
            Name = name;
        }

    }
}
