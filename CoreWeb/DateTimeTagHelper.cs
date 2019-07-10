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

            output.Content.SetHtmlContent($"{DateTime.Now.Year}年{DateTime.Now.Month}月{DateTime.Now.Day}日   {DateTime.Now.Hour}点{DateTime.Now.Minute}分");
        }
    }
}
