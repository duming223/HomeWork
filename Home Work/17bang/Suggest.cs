using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._17bang
{
    public class Suggest : IPublish, IThink
    {
        public Author Author { get; set; }
        public string Tile { get; set; }
        public string Body { get; set; }
        public int Agree { get; set; }
        public int Disagree { get; set; }
        public DateTime PublishDate { get; set; }

        public Suggest(Author author, string tile, string body)
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
            Console.WriteLine("{0}\n来自{1}的建议：\n建议内容{2}是:\n{3}",
                PublishDate = DateTime.Now, Author.Name, Tile, Body);
        }
    }
}
