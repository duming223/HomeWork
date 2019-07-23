using BLL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Suggest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }

        public void Publish()
        {

        }

    }
}
