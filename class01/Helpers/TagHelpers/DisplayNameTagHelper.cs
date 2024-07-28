using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace class01.Helpers.TagHelpers
{
    [HtmlTargetElement("personTag")]
    public class DisplayNameTagHelper : TagHelper
    {
        public string Name { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var span = new TagBuilder("h2");
            span.InnerHtml.Append(Name);
            output.Content.AppendHtml(span);
        }
    }
}
