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
        private const string _userIDKry = "UserName";
        private const string _userPassWordKey = "UserPassWord";
        private string _userNameValue;
        private string _userMd5PassWordValue;
        //private UserModel _userModel;
        //UserService _userService;

        //public _LayoutModel(/*UserModel userModel,*/UserService userService)
        //{
        //    //_userModel = userModel;
        //    //_userService = userService;
        //    UserService _userService = (UserService)HttpContext.RequestServices.GetService(typeof(UserService));
        //}

        public virtual void OnGet()
        {
            UserService _userService = (UserService)HttpContext.RequestServices.GetService(typeof(UserService));

            if (HttpContext.Request.Cookies.TryGetValue(_userIDKry, out _userNameValue))
            {
                if (HttpContext.Request.Cookies.TryGetValue(_userPassWordKey, out _userMd5PassWordValue))
                {
                     UserModel _userModel = _userService.GetInfoByCookie(_userNameValue, _userMd5PassWordValue);
                    if (_userModel != null)
                    {
                        ViewData["UserStatus"] = _userModel.UserName;
                        _userModel.UserName = _userNameValue;
                        _userModel.Md5PassWord = _userMd5PassWordValue;
                    }
                }
            }
            else
            {
                ViewData["UserStatus"] = null;
            }
        }
         
        public string GetUserNameByCookie()
        {
            return _userNameValue;
        }
    }
}
