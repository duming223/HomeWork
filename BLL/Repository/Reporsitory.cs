using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class Reporsitory<T> where T : class
    {
        public SQLContext CurrentContext { get; set; }
        protected DbSet<T> Entities { get; set; }

        public Reporsitory()
        {
            CurrentContext = new SQLContext();
            Entities = CurrentContext.Set<T>();
        }

        public void flush()
        {
            CurrentContext.SaveChanges();
        }

        public T Save( T entity)
        {
            Entities.Add(entity);
            CurrentContext.SaveChanges();

            return entity;
        }

        //public T GetByName(string userName)
        //{
        //    return Entities.Where(s => s.Author.UserName == name).SingleOrDefault();
        //}
    }
}
