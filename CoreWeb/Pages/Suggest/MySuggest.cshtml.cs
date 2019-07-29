using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using static SRV.UserService;

namespace CoreWeb.Pages.Suggest
{
    [BindProperties]
    public class MySuggestModel : _LayoutModel
    {
        [BindProperty(SupportsGet = true)]
        public int PageIndex { get; set; }

        [BindProperty(SupportsGet = true)]
        public int PageAction { get; set; }

        public int PageSize = 3;
        public int PageUp { get; set; }
        public int PageDown { get; set; }
        public IList<DTOSuggestModel> suggests;

        public SuggestService _suggestService;
        public MySuggestModel(SuggestService suggestService)
        {
            _suggestService = suggestService;
        }

        public override void OnGet()
        {
            ViewData["Title"] = "一起帮 😀 我的建议";
            base.OnGet();

            PageUp = PageIndex + 7;
            PageDown = PageIndex - 7;

            if (PageDown < 1)
            {
                PageDown = 1;
            }

            PageAction = 7 * (PageIndex / 7);
            if (PageAction == 0)
            {
                PageAction = 1;
            }

            //if (ViewData["UserStatus"] == null)
            //{
            //    Response.Redirect("/LogIn/LogIn");
            //}
            //if (_suggestService.currentuser!=null)
            //{
            //    suggests = _suggestService.GetListByAuthorId(_suggestService.currentuser.Id);
            //}
            //else
            //{
            //    Response.Redirect("/LogIn/LogIn");
            //}
        }
    }
}