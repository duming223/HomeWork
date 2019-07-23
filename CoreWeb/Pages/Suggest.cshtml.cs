using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Identity.UI.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;

namespace CoreWeb.Pages
{
    [BindProperties]
    public class SuggestModel :_LayoutModel
    {
        [Required(ErrorMessage = "必须填写！")]
        [MaxLength(15, ErrorMessage = "标题不能超过15字")]
        public string Title { get; set; }


        [Required(ErrorMessage = "必须填写！")]
        [MaxLength(200, ErrorMessage = "内容不能超过200字")]
        public string Body { get; set; }

        public UserModel Author { get; set; }
        private SuggestService _suggestService;

        public SuggestModel()
        {
            _suggestService = new SuggestService();
        }

        public  override void OnGet()
        {
            ViewData["Title"] = "一起帮 😀 建议";
            base.OnGet();
        }

        public void OnPost()
        {
            ViewData["Title"] = "一起帮 😀 建议";
            if (!ModelState.IsValid)
            {
                return;
            }

            if (ViewData["UserStatus"] == null)
            {
                ModelState.AddModelError("Title", "请先登录！");
                return;
            }
            else
            {
                Author = new UserModel();
                Author.UserName =
            }

            _suggestService.Publish(Title, Body, Author);
        }
    }
}