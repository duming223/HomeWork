using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWeb
{
    [HtmlTargetElement("datetime", Attributes = "showicon,date")]
    public class DateTimeTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "small";

            string showicon = context.AllAttributes["showicon"].Value.ToString().ToLower();
            string only = context.AllAttributes["only"].Value.ToString().ToLower();

            if (showicon == "true")
            {
                output.Content.SetContent("2019年7月8日 14点59分");
            }
            else
            {
                //不进行处理！
            }

            if (only == "date")
            {
                output.Content.SetContent(DateTime.Now.ToString("yyyy年MM月dd日"));
            }
            else
            {
                //不进行处理！
            }
        }
    }
}
