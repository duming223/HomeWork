using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._17bang
{
    public class Problem : IPublish
    {
        public User Author { get; set; }
        public string Tile { get; set; }
        public string Body{ get; set; }
        public int Reward { get; set; }
        public DateTime PublishDate { get; set; }

        public Problem(User  author, string tile, string body,int reward)
        {
            Author = author;
            Tile = tile;
            Body = body;
            Reward = reward;
        }

        public void Publish()
        {
            Console.WriteLine("{0}\n来自{1}的求助：\n{2}:\n{3}", PublishDate = DateTime.Now, Author.Name, Tile, Body);
        }
    }
}
