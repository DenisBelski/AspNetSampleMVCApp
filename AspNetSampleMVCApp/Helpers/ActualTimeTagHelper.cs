using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspNetSampleMvcApp.Helpers
{
    public class TimeTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagMode = TagMode.StartTagAndEndTag;
            output.TagName = "div";
            output.Content.SetContent($"Actual server date: {DateTime.Now:R}");
        }
    }
}
