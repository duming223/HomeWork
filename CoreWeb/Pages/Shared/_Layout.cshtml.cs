using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWeb.Pages.Shared
{
    [BindProperties]
    public class _LayoutModel:PageModel
    {
        public string Title { get; set; }
    }
}
