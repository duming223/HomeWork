using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class Reporsitory<T> where T : Entity
    {
        public DbContext _context { get; set; }
        protected DbSet<T> Entities { get; set; }

        public Reporsitory(DbContext context)
        {
            _context = context;
            Entities = _context.Set<T>();
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
            Flush();

            return entity;
        }
        /// <summary>
        /// 通过 id查找 entity 
        /// </summary>
        /// <param name="id">
        /// 用户的id
        /// </param>
        /// <returns>对应的entity </returns>
        public T GetBy(int id)
        {
            return Entities.Where(e => e.Id == id).Single();
        }

        public IList<T> GetList(int pageIndex, int pageSize)
        {
            IList<T> Result = Entities.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return Result;
        }

        //public T GetByName(string userName)
        //{
        //    return Entities.Where(s => s.Author.UserName == name).SingleOrDefault();
        //}
    }
}
