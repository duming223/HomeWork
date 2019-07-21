using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreWeb.Pages
{
    public class UserDataModel :_LayoutModel
    {
        public override void OnGet()
        {
            Title = Title = "一起帮😀个人资料";
            base.OnGet();
        }
    }
}