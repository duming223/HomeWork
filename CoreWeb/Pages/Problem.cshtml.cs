using CoreWeb.Pages.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWeb.Pages
{
    public class Problem : _LayoutModel
    {
        public override void OnGet()
        {
            Title= "一起帮 😀 求助";
            base.OnGet();
        }

    }
}
