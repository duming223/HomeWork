using BLL.Repository;
using System;
using System.Security.Cryptography;
using System.Text;

namespace BLL
{
    public class User
    {
        private const string _salt = "$*%";
        public int ID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int Integral { get; set; }

        private UserReporsitory _userReporsitory;

        public User()
        {
            _userReporsitory = new UserReporsitory();
        }

        public void Register()
        {
            using (MD5 mD5 = MD5.Create())
            {
                PassWord = GetMd5Hash(mD5, PassWord + _salt);
            }
        }

       private static string GetMd5Hash(MD5 mD5, string input)
        {
            byte[] data = mD5.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }
}
