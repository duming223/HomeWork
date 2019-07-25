using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreWeb.Pages
{
    public class ArticlelistsModel :_LayoutModel
    {
        public override void OnGet()
        {
            ViewData["Title"] = "一起帮 😀 文章列表";
            base.OnGet();
        }
    }
}