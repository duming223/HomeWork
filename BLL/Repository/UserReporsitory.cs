using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class UserReporsitory
    {
        public static int _id;
        private static IList<User> _userReporsitory;

        public void Save(User user)
        {
            _userReporsitory = _userReporsitory ?? new List<User>();
            _id++;
            user.ID = _id;
            _userReporsitory.Add(user);
        }

        public User GetByName(string name)
        {
            return _userReporsitory == null ? null
                       : _userReporsitory.Where(u => u.UserName == name).SingleOrDefault();
        }
    }
}
