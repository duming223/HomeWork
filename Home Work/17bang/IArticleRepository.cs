using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._17bang
{
    interface IArticleRepository
    {
        IList<Article> Get();
        void Add(Article article);
        void GetBy(string name);
    }
}
