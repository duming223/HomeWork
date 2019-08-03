using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repository
{
    public class SuggestReporsitory :Reporsitory<Suggest>
    {
        public SuggestReporsitory(DbContext context):base(context)
        {

        }
        public Suggest GetByName(string name)
        {
            return Entities.Where(s => s.Author.UserName == name).SingleOrDefault();
        }

        public IQueryable<Suggest> GetListByAuthorId(int authorid,int pageindex ,int pagesize)
        {
          return  Entities.Where(s=>s.Author.Id==authorid).Skip((pageindex-1)*pagesize).Take(pagesize);
        }
    }
}
