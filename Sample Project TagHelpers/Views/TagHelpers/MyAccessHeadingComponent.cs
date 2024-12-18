namespace Sample_Project_TagHelpers.Views.TagHelpers;

using Microsoft.AspNetCore.Razor.TagHelpers;
using TechGems.RazorComponentTagHelpers;

[HtmlTargetElement("myaccess-heading")]
public class MyAccessHeadingComponent : RazorComponentTagHelper
{
    public MyAccessHeadingComponent()
        : base("~/Views/TagHelpers/MyAccessHeadingComponent.cshtml")
    {
    }

    [HtmlAttributeName("heading")]
    public string Heading { get; set; } = "Default Component Heading";
}
