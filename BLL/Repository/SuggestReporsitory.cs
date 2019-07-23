using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BLL.Repository
{
    public class SuggestReporsitory :Reporsitory<Suggest>
    {

        //public void Save(Suggest suggest)
        //{
        //    Entities.Add(suggest);
        //    CurrentContext.SaveChanges();
        //}

        public Suggest GetByName(string name)
        {
            return Entities.Where(s => s.Author.UserName == name).SingleOrDefault();
        }
    }
}
