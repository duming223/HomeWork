using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace HomeWork._17bang
{
    class ArticleReporsitory : IReporsitory,IXReporsitry
    {
        public static IList<Article> Reporsitory = new List<Article>();
        
        public void GetBy(Author author)
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
