using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
namespace Admin_User_Login_Portal.CustomHelpers
{
    [HtmlTargetElement(Attributes ="asp-active-link")]
    public class ActiveRouteTagHelper: TagHelper
    {
        
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var currentcontroller = ViewContext.RouteData.Values["Controller"].ToString();
            var currentaction = ViewContext.RouteData.Values["Action"].ToString();
            var tagcontroller = context.AllAttributes.FirstOrDefault(a => a.Name == "asp-controller").Value.ToString();
            var tagaction = context.AllAttributes.FirstOrDefault(a => a.Name == "asp-action").Value.ToString();
            if(currentcontroller== tagcontroller && currentaction==tagaction)
            { var existingcss = context.AllAttributes.FirstOrDefault(a => a.Name == "class").Value.ToString();
                var cssclass = context.AllAttributes.FirstOrDefault(a => a.Name == "asp-active-link").Value.ToString();
                output.Attributes.SetAttribute("class", $"{existingcss} {cssclass}");
            }
        }
    }
}
