using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Admin_User_Login_Portal.CustomHelpers
{
    [HtmlTargetElement("command-button")]
    public class CommandButtonTagHelper:TagHelper
    {
        [HtmlAttributeName("value")]
        public string Value { get; set; }
        [HtmlAttributeName("class")]
        public string CssClass { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string strhtml = $"<button type='button' name='command' class='{CssClass}'>{Value}</button>";
            output.Content.SetHtmlContent(strhtml);
        }
    }
}
