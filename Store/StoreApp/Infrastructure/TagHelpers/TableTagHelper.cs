using Microsoft.AspNetCore.Razor.TagHelpers;

namespace StoreApp.Infrastructure.TagHelpers
{
    [HtmlTargetElement("table")]//target ismini vermek gerekir 
    public class TableTagHelper:TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class","table table-hover");
        }
    }
}