using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class Reporsitory<T> where T : class
    {
        public DbContext _context { get; set; }
        protected DbSet<T> Entities { get; set; }

        public Reporsitory(DbContext context)
        {
            _context = context;
            Entities= _context.Set<T>();
        }

        //public void SetEntities(SQLContext sQLContext)
        //{
        //    _context = sQLContext;
        //    Entities = sQLContext.Set<T>();
        //}

        public void Flush()
        {
            _context.SaveChanges();
        }

        public T Save(T entity)
        {
            Entities.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        //public T GetByName(string userName)
        //{
        //    return Entities.Where(s => s.Author.UserName == name).SingleOrDefault();
        //}
    }
}
