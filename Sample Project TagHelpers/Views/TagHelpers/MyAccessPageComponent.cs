namespace Sample_Project_TagHelpers.Views.TagHelpers;

using Microsoft.AspNetCore.Razor.TagHelpers;
using TechGems.RazorComponentTagHelpers;

[HtmlTargetElement("myaccess-page")]
public class MyAccessPageComponent : RazorComponentTagHelper
{
    public static readonly string PageFooterSlot = "PageFooter";

    public MyAccessPageComponent()
        : base("~/Views/TagHelpers/MyAccessPageComponent.cshtml")
    {
    }

    [HtmlAttributeName("heading")]
    public string Heading { get; set; } = "Default Page Heading";
}
