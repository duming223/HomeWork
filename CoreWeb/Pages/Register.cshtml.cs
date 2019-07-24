using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWeb.Pages
{
    [BindProperties]
    public class RegisterModel :_LayoutModel
    {
        private UserService _userService;
        public Register _register { get; set; }

        public RegisterModel(UserService userService)
        { 
            _userService = userService;
        }

        public override void OnGet()
        {
            ViewData["Title"] = "一起帮 😀 注册";
            base.OnGet();
        }

        public void OnPost()
        {
            ViewData["Title"] = "一起帮 😀 注册";

            if (!ModelState.IsValid)
            {
                return;
            }
            
            if (_userService.HasExist(_register.UserName))
            {
                ModelState.AddModelError("_register.UserName", "用户名已存在！");
                return;
            }

            if (_register.UserName.Contains(" ")| _register.PassWord.Contains(" "))
            {
                ModelState.AddModelError("_register.UserName", "用户名和密码不能包含空格！");
                return;
            }

            if (_register.PassWord!= _register.ConfirmPassWord)
            {
                ModelState.AddModelError("_register.ConfirmPassWord", "*确认密码和密码不一致");
                return;
            }

            if (ModelState.IsValid)
            {
                _userService.Register(_register.UserName, _register.PassWord);
            }

            Response.Redirect("Login");
        }
    }


    public class Register
    {
        [Required(ErrorMessage = "*用户名不能为空")]
        public  string UserName { get; set; }

        [Required(ErrorMessage = "*密码不能为空")]
        [MinLength(4, ErrorMessage = "密码不能少于4个字符")]
        public  string PassWord { get; set; }

        [Required(ErrorMessage = "*确认密码不能为空")]
        [MinLength(4, ErrorMessage = "密码不能少于4个字符")]
        [Compare("PassWord", ErrorMessage = "*确认密码和密码不一致")]
        public  string ConfirmPassWord { get; set; }

    }
}
