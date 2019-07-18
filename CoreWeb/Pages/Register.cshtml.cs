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
    public class RegisterModel : PageModel
    {
        private UserService _userService;
        public Register Register { get; set; }

        public RegisterModel()
        {
            _userService = new UserService();
        }

        public void OnGet()
        {
            ViewData["Title"] = "一起帮 😀 注册";
        }

        public void OnPost()
        {

            if (!ModelState.IsValid)
            {
                return;
            }

            if (_userService.HasExist(Register.UserName))
            {
                ModelState.AddModelError("Register.UserName", "用户名已存在！");
                return;
            }

            _userService.Register(Register.UserName, Register.PassWord);
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
