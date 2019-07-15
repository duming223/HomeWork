using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreWeb.Pages
{
    [BindProperties]
    public class IndexModel :_LayoutModel
    {
       
        public void OnGet()
        {
            
            Title = "首页！";
        }
    }
}
