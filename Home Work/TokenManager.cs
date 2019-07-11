using HomeWork._17bang;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class TokenManager
    {
        private Token _token;

        public void Add(Token token)
        {
            _token = _token | token;
        }

        public void Remove(Token token)
        {
            _token = _token ^ token;
        }

        public bool Has(Token token)
        {
            return (_token & token) == token;
        }

    }

    [Flags]
    public enum Token
    {
        SuperAdmin = 1,
        Admin = 2,
        Blogger = 4,
        Newbie = 8,
        Registered = 16,
    }
}

