using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;

namespace CoreWeb.Pages
{
    [BindProperties]
    public class LoginModel : _LayoutModel
    {
        private UserService userService;

        public LoginModel()
        {
            userService = new UserService();
        }

        [Required(ErrorMessage = "必须填写！")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "必须填写！")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public void OnGet()
        {
            Title = "一起帮😀登陆";
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
            Response.Redirect("index");
           }
    }
}