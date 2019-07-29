using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repository
{
    public class SQLContext : DbContext 
    {
        public static readonly LoggerFactory MyLoggerFactory
            = /*new LoggerFactory(new[] { new ConsoleLoggerProvider((_, __) => true, true) });*/
            //对log信息进行筛选
        new LoggerFactory(
                new[]
                {
                    new ConsoleLoggerProvider((category, level) =>
                        category == DbLoggerCategory.Database.Command.Name &&
                        level == LogLevel.Information
                      , true)
                });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bang;Integrated Security=True;";
            //optionsBuilder.UseSqlServer(connectionString);

            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = 17bangtext; Integrated Security = True; ";
            optionsBuilder.UseSqlServer(connectionString);

            //在控制台中输出log
            optionsBuilder
                .UseLoggerFactory(MyLoggerFactory)
                .UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Entity>();
            modelBuilder.Entity<User>();
            modelBuilder.Entity<Email>();
            modelBuilder.Entity<Suggest>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
