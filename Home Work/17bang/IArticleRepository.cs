using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work._17bang
{
    interface IArticleRepository
    {
        IList<Article> Get();
        void Add(Article article);
        void GetBy(string name);
    }
}
