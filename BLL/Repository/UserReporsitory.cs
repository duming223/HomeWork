using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class UserReporsitory : Reporsitory<User>
    { 
        public UserReporsitory(DbContext context):base(context)
        {

        }

        public User GetByName(string name)
        {
            return Entities.Where(u => u.UserName == name).SingleOrDefault();
        }
    }
}
 