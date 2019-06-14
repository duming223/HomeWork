using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Home_Work._17bang
{
    public class ArticleReporsitory : IArticleRepository
    {
        private static IList<Article> _article=new List<Article>();

        public IList<Article> Get()
        {
            return _article;
        }

        public void Add(Article article)
        {
            _article.Add(article);
        }

        public void GetBy(string name)
        {
            var listarticle = from a in _article
                              where a.author.Name.ToLower().Contains(name.ToLower())
                              select a;
            foreach (var item in listarticle)
            {
                Console.WriteLine(item.Tile);
            }
        }
    }
}
