using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;

namespace CoreWeb.Pages
{
    [BindProperties]
    public class LoginModel : _LayoutModel
    {
        private const string _userName = "UserID";
        private const string _userPassWord = "UserPassWord";
        private UserService userService;

        public LoginModel()
        {
            userService = new UserService();
        }

        [Required(ErrorMessage = "必须填写！")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "必须填写！")]
        public string Password { get; set; }

        public override void OnGet()
        {
            Title = "一起帮😀登陆";
            base.OnGet();
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            if (UserName.Contains(' '))
            {
                ModelState.AddModelError("UserName", "不能包含空格！");
                return;
            }

            if (!userService.HasExist(UserName))
            {
                ModelState.AddModelError("UserName", "用户名不存在！");
                return;
            }

            if (!userService.PasswordIsTrue(UserName, Password))
            {
                ModelState.AddModelError("PassWord", "密码错误！");
                return;
            }
            else
            {
                ModelState.AddModelError("UserName", "登录成功！");
            }

            UserModel userModel = userService.GetLoginInfo(UserName, Password);
            if (Request.Form["sevendays"].Contains("true"))
            {
                Response.Cookies.Append(_userName, userModel.UserName,
                    new CookieOptions
                    {
                        Expires = DateTime.Now.AddDays(7)
                    });

                Response.Cookies.Append(_userPassWord, userModel.Md5PassWord,
                    new CookieOptions
                    {
                        Expires = DateTime.Now.AddDays(7)
                    });
            }
            else
            {
                Response.Cookies.Append(_userName, userModel.UserName,
                   new CookieOptions
                   {
                       //Domain = Request.Host.Value,
                       //Path = Request.Path,
                       //IsEssential = true,
                       //Expires = DateTime.Now.AddDays(7)
                   });

                Response.Cookies.Append(_userPassWord, userModel.Md5PassWord,
                    new CookieOptions
                    {
                        //Expires = DateTime.Now.AddDays(7)
                    });
            }
         
            Response.Redirect("index");
        }
    }
}