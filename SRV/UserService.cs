using BLL;
using BLL.Repository;
using System;
using System.Security.Cryptography;

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

        public void Register(string name, string password)
        {
            _user.UserName = name;
            _user.PassWord = password;
            _user.Register();
            _userReporsitory.Save(_user);
        }

        public bool HasExist(string name)
        {
            return _userReporsitory.GetByName(name) != null;
        }

        public bool PasswordIsTrue(string name, string password)
        {
            string mD5Coed;
            using (MD5 mD5 = MD5.Create())
            {
                mD5Coed = User.GetMd5Hash(mD5, password+User._salt);
            }
            return mD5Coed == _userReporsitory.GetByName(name).PassWord;
        }

    }
}
