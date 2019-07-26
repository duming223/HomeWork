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
    public class SuggestSingleModel : _LayoutModel
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DTOSuggestModel suggestModel;
        public DTOUserModel userModel;

        [BindProperty(SupportsGet = true)]
        public int suggestid { get; set; }
        //[BindProperty(SupportsGet = true)]
        //public int userid { get; set; }

        private SuggestService _suggestService;
        private UserService _userService;

        public SuggestSingleModel(SuggestService suggestService, UserService userService)
        {
            _suggestService = suggestService;
            _userService = userService;
        }

        public override void OnGet()
        {
            base.OnGet();

            ViewData["Title"] = "一起帮 😀 当前建议";
            suggestModel = _suggestService.GetBy(suggestid);
            userModel = _userService.GetInfoById(suggestModel.Author.Id);
        }
    }
}