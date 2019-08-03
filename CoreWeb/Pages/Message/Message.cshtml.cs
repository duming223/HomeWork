using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using BLL.Repository;
using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreWeb.Pages.Message
{
    public class MessageModel : _LayoutModel
    {
        [BindProperty(SupportsGet = true)]
        public int PageIndex { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PageSize { get; set; }
        public int PageAction { get; set; }
        public int PageUp { get; set; }
        public int PageDown { get; set; }

        public IList<BLL.Message> Messages { get; set; }

        private MessageReporsitory _messageReporsitory;
        public MessageModel(MessageReporsitory message)
        {
            _messageReporsitory = message;
        }


        public override void OnGet()
        {
            ViewData["Title"] = "一起帮 😀 系统消息";
            base.OnGet();
            PageSize = 3;
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
            Messages = _messageReporsitory.GetList(PageIndex, PageSize).ToList();
            BLL.Message message = new BLL.Message();
        }
    }
}