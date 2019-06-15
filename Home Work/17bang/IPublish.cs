using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._17bang
{
    interface IPublish<T>
    {
        void Publish(T author);
    }
}
