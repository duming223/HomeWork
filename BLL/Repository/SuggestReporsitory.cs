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

        public IList<Suggest> GetListByAuthorId(int authorid ,int pageIndex, int pageSize)
        {
          return  Entities.Where(s=>s.Author.Id==authorid).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}
