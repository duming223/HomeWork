using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._17bang
{
    public class Comment : IPublish, IThink
    {
        public User Author { get; set; }
        public string Body { get; set; }
        public int Agree { get; set; }
        public int Disagree { get; set; }
        public DateTime PublishDate { get; set; }

        public Comment(User author, string body)
        {
            Author = author;
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
            Console.WriteLine("{0}\n 来自{1}的评论：\n 评论内容是:\n {2}",
                PublishDate = DateTime.Now, Author.Name, Body);
        }
    }
}
