using BLL;
using BLL.Repository;
using System;
using System.Security.Cryptography;

namespace SRV
{
    public class UserService
    {
        private User user;
        private UserModel _userModel;
        private UserReporsitory _userReporsitory;

        public UserService()
        {
            user = new User();
            _userReporsitory = new UserReporsitory();
        }

        public void Register(string name, string password)
        {
            user.UserName = name;
            user.PassWord = password;
            user.Register();
            _userReporsitory.Save(user);
        }

        public bool HasExist(string name)
        {
            return _userReporsitory.GetByName(name) != null;
        }

        public bool PasswordIsTrue(string name, string password)
        {
            string mD5Coed = User.GetMd5Hash(password);

            return mD5Coed == _userReporsitory.GetByName(name).PassWord;
        }

        public UserModel GetInfoByCookie(string userIdValue, string userMd5PassWordValue)
        {
            User user = _userReporsitory.GetByName(userIdValue);

            if (user == null)
            {
                return null;
            }
            else if (user.PassWord == userMd5PassWordValue)
            {
                _userModel = new UserModel();
                _userModel.UserName = user.UserName;
                _userModel.Md5PassWord = user.PassWord;

                return _userModel;
            }
            else
            {
                return null;
            }
        }

        public UserModel GetLoginInfo(string userName, string password)
        {
            User user = _userReporsitory.GetByName(userName);
            string Md5PassWord = User.GetMd5Hash(password);
            if (user == null)
            {
                return null;
            }
            else if (user.PassWord == Md5PassWord)
            {
                _userModel = new UserModel();
                _userModel.UserName = user.UserName;
                _userModel.PassWord = password;
                _userModel.Md5PassWord = Md5PassWord;

                return _userModel;
            }
            else
            {
                return null;
            }
        }
    }
}
