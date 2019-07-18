using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class UserReporsitory : DbContext
    {

        public DbSet<User> users { get; set; }

        public void Save(User user)
        {
            users.Add(user);
            SaveChanges();

        }

        public User GetByName(string name)
        {
            return users.Where(u => u.UserName == name).SingleOrDefault();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bang;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
