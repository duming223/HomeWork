using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork._17bang
{
    class SuggestReporsitory:IReporsitory
    {
        public static IList<Suggest> Reporsitory=new List<Suggest>();

        public void GetBy(User  author)
        {
            var result = from x in Reporsitory
                         where x.Author.Name.ToLower().Contains(author.Name)
                         select x;
            foreach (var item in result)
            {
                Console.WriteLine(item.Tile);
            }
        }
    }
}
