using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreWeb.Pages
{
    public class BindEmeailModel :_LayoutModel
    {
        public string EmailAddress { get; set; }

        public override void OnGet()
        {
            ViewData["Title"] = " 一起帮 😀 绑定邮箱";
            base.OnGet();
        }

        public void OnPost()
        {

        }
    }
}