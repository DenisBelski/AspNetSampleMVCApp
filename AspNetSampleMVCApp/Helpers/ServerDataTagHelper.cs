using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspNetSampleMvcApp.Helpers
{
    public class ServerDataTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagMode = TagMode.StartTagAndEndTag;
            output.TagName = "div";
            var processorId = Thread.GetCurrentProcessorId();
            output.Content.SetContent($"Your application processor id: {processorId}");
        }
    }
}
