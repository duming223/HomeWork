using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Identity.UI.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreWeb.Pages
{
    public class SuggestModel :_LayoutModel
    {
        public string SuggestTitle { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }

        public override void OnGet()
        {
            Title = "一起帮 😀 建议";
            base.OnGet();
        }
    }
}