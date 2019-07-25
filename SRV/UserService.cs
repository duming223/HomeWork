using BLL;
using BLL.Repository;
using System;
using System.Security.Cryptography;

namespace SRV
{
    public class UserService
    {
        private User _user;
        private DTOUserModel _userModel;
        private UserReporsitory _userReporsitory;

        public UserService(UserReporsitory userReporsitory)
        {
            _userModel = new DTOUserModel();
            _userReporsitory = userReporsitory;
        }

        public void Register(string name, string password)
        {
            _user = new User();
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
            string mD5Coed = User.GetMd5Hash(password);

            return mD5Coed == _userReporsitory.GetByName(name).PassWord;
        }

        public DTOUserModel GetInfoByCookie(string userIdValue, string userMd5PassWordValue)
        {
            User user = _userReporsitory.GetByName(userIdValue);

            if (user == null)
            {
                return null;
            }
            else if (user.PassWord == userMd5PassWordValue)
            {
                //_userModel = new UserModel();
                _userModel.UserName = user.UserName;
                _userModel.Md5PassWord = user.PassWord;

                return _userModel;
            }
            else
            {
                return null;
            }
        }

        public DTOUserModel GetLoginInfo(string userName, string password)
        {
            User user = _userReporsitory.GetByName(userName);
            string Md5PassWord = User.GetMd5Hash(password);
            if (user == null)
            {
                return null;
            }
            else if (user.PassWord == Md5PassWord)
            {
                //_userModel = new UserModel();
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

        public class DTOUserModel
        {
            public string UserName { get; set; }
            public string PassWord { get; set; }
            public string Md5PassWord { get; set; }
            public int Integral { get; set; }
            public Email Email { get; set; }
        }
    }
}
