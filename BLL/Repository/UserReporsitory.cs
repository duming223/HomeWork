using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class UserReporsitory : SQLReporsitory
    {

       

        public void Save(User user)
        {
            Uers.Add(user);
            SaveChanges();

        }

        public User GetByName(string name)
        {
            return Uers.Where(u => u.UserName == name).SingleOrDefault();
        }


    }
}
 