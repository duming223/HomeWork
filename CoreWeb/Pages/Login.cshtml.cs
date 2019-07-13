using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreWeb.Pages
{
    [BindProperties]
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string UserName { get; set; }
        public void OnGet()
        {

        }
    }
}