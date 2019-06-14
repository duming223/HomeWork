using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work._17bang
{
    class Comment : IPublish<Comment>, IThink<Comment>
    {
        public Author Name { get; set; }
        public string Boyd { get; set; }
        public int Agree { get; set; }
        public int Disagree { get; set; }
        public DateTime PublishDate { get; set; }

        public void GetAgree()
        {
            Agree++;
        }

        public void GetDisagree()
        {
            Disagree++;
        }

        public void Publish(Comment author)
        { 
            Console.WriteLine("{0}\n 来自{1}的评论：\n 评论内容是:\n {2}", PublishDate, Name.Name, Boyd);
        }
    }
}
