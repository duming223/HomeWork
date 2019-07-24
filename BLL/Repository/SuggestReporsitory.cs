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
    }
}
