using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CoreWeb
{
    //自定义一个TageHelper  
    [HtmlTargetElement("pager",Attributes="pageInde,path")]
    public class PagTagHelper:TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";

            object pageIndex = context.AllAttributes["pageIndex"].Value;
            object path = context.AllAttributes["path"].Value;
            output.Attributes.Add("href", $"{path}/page-{pageIndex}");

        }
    }
}
