using BLL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBFactory
{
    class Helper
    {
        public static SQLContext Context { get; set; } = new SQLContext();
    }
}
