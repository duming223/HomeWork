using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using SRV;
using static SRV.UserService;

namespace CoreWeb.Pages
{
    [BindProperties]
    public class LoginModel : _LayoutModel
    {
        private const string _userName = "UserName";
        private const string _userPassWord = "UserPassWord";
        private const string _userId= "Id";
        private UserService _userService;

        public LoginModel(UserService  userService)
        {
            _userService = userService;
        }

        [Required(ErrorMessage = "必须填写！")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "必须填写！")]
        public string Password { get; set; }

        public override void OnGet()
        {
            ViewData["Title"] = "一起帮 😀 登录";
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

            if (!_userService.HasExist(UserName))
            {
                ModelState.AddModelError("UserName", "用户名不存在！");
                return;
            }

            if (!_userService.PasswordIsTrue(UserName, Password))
            {
                ModelState.AddModelError("PassWord", "密码错误！");
                return;
            }
            //else
            //{
            //    ModelState.AddModelError("UserName", "登录成功！");
            //}

            DTOUserModel userModel = _userService.GetLoginInfo(UserName, Password);

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
                Response.Redirect("/index");
            }
            else
            {

                Response.Cookies.Append(_userName, userModel.UserName);
                Response.Cookies.Append(_userPassWord, userModel.Md5PassWord);
                Response.Cookies.Append(_userId, userModel.Id.ToString ());

                //  添加session
                //HttpContext.Session.SetString(_sessionId, JsonConvert.SerializeObject(userModel));

                Response.Redirect("/index");
            }
        }
    }
}