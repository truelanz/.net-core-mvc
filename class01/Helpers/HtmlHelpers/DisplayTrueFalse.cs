using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace class01.Helpers.HtmlHelpers
{
    public static class DisplayTrueFalse
    {
        public static IHtmlContent TrueFalse(this IHtmlHelper htmlHelper, bool boolValue)
        {
            var span = new TagBuilder("span");

            if (boolValue)
            {
                span.AddCssClass("badge badge-success");
                span.InnerHtml.Append("Verdadeiro");
                span.Attributes.Add("style", $"background-color: green; color: black;");
            }
            else
            {
                span.AddCssClass("badge badge-danger");
                span.InnerHtml.Append("Falso");
                span.Attributes.Add("style", $"background-color: red; color: black;");
            }
            return span;
        }
    }
}
