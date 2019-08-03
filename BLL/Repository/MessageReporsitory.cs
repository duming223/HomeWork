using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repository
{
    public class MessageReporsitory : Reporsitory<Message>
    {

        public MessageReporsitory(DbContext dbContext):base(dbContext)
        {

        }

    }
}
