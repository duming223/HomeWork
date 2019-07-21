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
            string mD5Coed=User.GetMd5Hash(password);
   
            return mD5Coed == _userReporsitory.GetByName(name).PassWord;
        }

        public UserModel GetInfoByCookie(string userIdValue, string userPassWordValue)
        {
            User user = _userReporsitory.GetByName(userIdValue);

            if (user == null)
            {
                return null;
            }
            else if (user.PassWord == userPassWordValue)
            {
                UserModel userModel = new UserModel();
                userModel.UserName = user.UserName;
                userModel.Md5PassWord = user.PassWord;

                return userModel;
            }
            else
            {
                return null;
            }
        }

        public UserModel GetLoginInfo(string userName, string password)
        {
           User  user=  _userReporsitory.GetByName(userName);
            string Md5PassWord = User.GetMd5Hash(password);
            if (user==null)
            {
                return null;
            }
            else if (user.PassWord==Md5PassWord)
            {
                UserModel userModel = new UserModel();
                userModel.UserName = user.UserName;
                userModel.PassWord = password;
                userModel.Md5PassWord =Md5PassWord ;

                return userModel;
            }
            else
            {
                return null;
            }
        }
    }
}
