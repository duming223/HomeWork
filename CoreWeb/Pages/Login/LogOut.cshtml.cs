using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreWeb.Pages
{
    public class LogOutModel : PageModel
    {
        private const string _userNameKey = "UserName";
        private const string _userPassWordKey = "UserPassWord";

        public void OnGet()
        {
            HttpContext.Response.Cookies.Delete(_userNameKey);
            HttpContext.Response.Cookies.Delete(_userPassWordKey);
            Response.Redirect("/index");
        }
    }
}