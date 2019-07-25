using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Email:Entity
    {
        public bool IsActivate { get; set; }
        public int Code { get; set; }

        public void CreateCode()
        {
            Code = new Random(1000).Next(2000);
        }
    }
}
