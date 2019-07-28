using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;

namespace CoreWeb.Pages.Suggest
{
    public class SuggestListModel : _LayoutModel
    {
        [BindProperty(SupportsGet = true)]
        public int PageIndex { get; set; } 
        public int PageSize = 3;
        public int PageUp { get; set; }
        public int PageDown { get; set; }
        public IList<DTOSuggestModel> suggests;

        private SuggestService _suggestService;
        public SuggestListModel(SuggestService suggestService)
        {
            _suggestService = suggestService;
        }

        public override void OnGet()
        {
            ViewData["Title"] = "一起帮 😀 建议列表";
            base.OnGet();

            //PageIndex = 1;
            //PageSize = 3;
            PageUp = PageIndex - 1;
            if (PageUp<1)
            {
                PageUp = 1;
            }
            PageDown = PageIndex + 1;
            suggests = _suggestService.GetList(PageIndex, PageSize);
        }

        public void OnPost()
        {

        }
    }
}