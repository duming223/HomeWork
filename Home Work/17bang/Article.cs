using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._17bang
{
    public class Article : IPublish, IThink
    {
        public Author Author { get; set; }
        public string Tile { get; set; }
        public string Body { get; set; }
        public  int Agree { get; set; }
        public int Disagree { get; set; }
        public DateTime PublishDate { get; set; }

        public Article(Author author, string tile, string body)
        {
            Author = author;
            Tile = tile;
            Body = body;
        }

        public void GetAgree()
        {
            Agree++;
        }

        public void GetDisagree()
        {
            Disagree++;
        }

        public void Publish()
        {
            Console.WriteLine("{0}\n 来自：{1}的文章\n 文章标题：{2}\n 文章内容： {3}",
                PublishDate = DateTime.Now, Author.Name, Tile, Body);
        }
    }
}


