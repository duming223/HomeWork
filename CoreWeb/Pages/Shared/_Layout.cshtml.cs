using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWeb.Pages.Shared
{
    [BindProperties]
    public class _LayoutModel : PageModel
    {
        private const string _userIDKry = "UserID";
        private const string _userPassWordKey = "UserPassWord";
        private string _userIdValue;
        private string _userMd5PassWordValue;
        public UserModel UserModel { get; set; }

        public virtual void OnGet()
        {

            if (HttpContext.Request.Cookies.TryGetValue(_userIDKry, out _userIdValue))
            {
                if (HttpContext.Request.Cookies.TryGetValue(_userPassWordKey, out _userMd5PassWordValue))
                {
                    UserModel userModel = new UserService().GetInfoByCookie(_userIdValue, _userMd5PassWordValue);
                    if (userModel != null)
                    {
                        ViewData["UserStatus"] = userModel.UserName;
                        UserModel.UserName = _userIdValue;
                        UserModel.Md5PassWord = _userMd5PassWordValue;
                    }
                }
            }
            else
            {
                ViewData["UserStatus"] = null;
            }
        }
    }
}
