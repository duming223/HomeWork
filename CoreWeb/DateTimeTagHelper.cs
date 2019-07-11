using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWeb
{
    [HtmlTargetElement("datetime")]
    public class DateTimeTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "small";

            output.Content.SetHtmlContent(DateTime.Now.ToString("yyyy年MM月dd HH:mm:ss"));

        }
    }
}
