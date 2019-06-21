using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._17bang
{
    public class Author
    {
        public User User { get;}
        public string Name { get;}
        
        public Author(User user )
        {
            User = user;
            Name = user.Name;
        }
    }
}
