using BLL;
using BLL.Repository;
using System;

namespace SRV
{
    public class UserService
    {
        private User _user;
        private UserReporsitory _userReporsitory;

        public UserService()
        {
            _user = new User();
            _userReporsitory = new UserReporsitory();
        }

        public void Register(string name,string password) 
        {
            _user.UserName = name;
            _user.PassWord = password;
            _userReporsitory.Save(_user);
        }

        public bool HasExist(string name)
        {
            return  _userReporsitory.GetByName(name) != null;
        }
    }
}
