using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BLL.Repository
{
    public class SuggestReporsitory : SQLReporsitory
    {

        public void Save(Suggest suggest)
        {
            Suggest.Add(suggest);
            SaveChanges();

        }

        public Suggest GetByName(string name)
        {
            return Suggest.Where(s => s.Author.UserName == name).SingleOrDefault();
        }
    }
}
