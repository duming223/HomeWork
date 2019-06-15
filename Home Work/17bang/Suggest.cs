using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._17bang
{
    class Suggest : IPublish<Suggest>,IThink<Suggest>
    {
        public Author Name { get; set; }
        public string Tile { get; set; }
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

        public void Publish(Suggest suggest)
        {
            Console.WriteLine("{0}\n来自{1}的建议：\n建议内容{2}是:\n{3}",PublishDate,Name.Name,Tile,Boyd );
        }
    }
}
