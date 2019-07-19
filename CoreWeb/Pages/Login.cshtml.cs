using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreWeb.Pages
{
    [BindProperties]
    public class LoginModel :_LayoutModel
    {
     
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
                ModelState.AddModelError("UserName", "不能使用空格！");
                return;
            }
        }
    }
}