using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._17bang
{
    class Problem : IPublish<Problem>
    {
        public Author Name { get; set; }
        public string Tile { get; set; }
        public string Boyd { get; set; }
        public DateTime PublishDate { get; set; }

        public void Publish(Problem author)
        {
            Console.WriteLine("{0}\n来自{1}的求助：\n{2}:\n{3}", PublishDate, Name.Name, Tile, Boyd);
        }
    }
}
