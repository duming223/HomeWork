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
using static SRV.UserService;

namespace CoreWeb.Pages
{
    [BindProperties]
    public class SuggestModel : _LayoutModel
    {
        //[Required(ErrorMessage = "必须填写！")]
        //[MaxLength(15, ErrorMessage = "标题不能超过15字")]
        //public string Title { get; set; }


        //[Required(ErrorMessage = "必须填写！")]
        //[MaxLength(200, ErrorMessage = "内容不能超过200字")]
        //public string Body { get; set; }

        //private DTOUserModel _author;
        private SuggestService _suggestService;
        //使用suggestservice 里的dto来传递ui层的值
        public DTOSuggestModel suggestModel { get; set; }

        public SuggestModel(SuggestService suggestModel)
        {
            _suggestService = suggestModel;
        }

        public override void OnGet()
        {
            ViewData["Title"] = "一起帮 😀 建议";
            base.OnGet();
        }

        public IActionResult OnPost()
        {
            base.OnGet();
            ViewData["Title"] = "一起帮 😀 建议";
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (ViewData["UserStatus"] == null)
            {
                ModelState.AddModelError("Title", "请先登录！");
                return Page();
            }

            //else
            //{
            //    suggestModel = new DTOSuggestModel()
            //    {
            //        Author = _suggestService.currentuser,
            //        Title = Title,
            //        Body = Body
            //    };
            //}

            //Understand  运算符
            suggestModel.Author = _suggestService.currentuser;
            int suggestid = _suggestService.Publish(suggestModel).Id;

            return Redirect("/Suggest/SuggestSingle?suggestid=" + suggestid);
        }
    }
}