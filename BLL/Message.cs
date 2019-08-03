using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    class Message
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public User Sender { get; set; }
        public User Owner { get; set; }
        public DateTime PublishTime { get; set; }
    }
}
