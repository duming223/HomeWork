using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreWeb.Pages.Message
{
    public class NewMessageModel : _LayoutModel
    {
        public string Title { get; set; }
        public string body { get; set; }

        public override void OnGet()
        {
            ViewData["Title"] = "MyMessage";
            base.OnGet();
        }
    }
}