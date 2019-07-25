using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;

namespace CoreWeb.Pages.Suggest
{
    [BindProperties]
    public class SuggestSingleModel : _LayoutModel
    {
        public string Author{ get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DTOSuggestModel suggestModel { get; set; }

        [BindProperty(SupportsGet =true)]
        public int userid { get; set; }
        [BindProperty(SupportsGet = true)]
        public int suggestid { get; set; }

        private SuggestService _suggestService;

        public SuggestSingleModel(SuggestService suggestService)
        {
            _suggestService = suggestService;
        }

        public override void OnGet()
        {
            ViewData["Title"] = "一起帮 😀 当前建议";
            suggestModel = _suggestService.GetBy(suggestid);
            base.OnGet();
        }
    }
}