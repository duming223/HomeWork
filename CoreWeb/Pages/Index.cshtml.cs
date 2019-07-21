using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreWeb.Pages
{
    [BindProperties]
    public class IndexModel : _LayoutModel
    {
        public override void OnGet()
        {
            Title = "一起帮😀首页";
            base.OnGet();
        }

        public void OnPost()
        {

        }
       
    }
}
