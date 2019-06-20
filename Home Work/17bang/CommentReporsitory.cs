using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork._17bang 
{
    class CommentReporsitory:IReporsitory
    {
        public static IList<Comment> Reporsitory=new List<Comment>();

        public void GetBy(Author author)
        {
            var result = from x in Reporsitory
                         where x.Author.Name.ToLower().Contains(author.Name)
                         select x;
            foreach (var item in result)
            {
                Console.WriteLine(item.Body);
            }
        }
    }
}
