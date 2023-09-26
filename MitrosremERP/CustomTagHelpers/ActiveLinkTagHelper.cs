using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.Encodings.Web;

namespace MitrosremERP.CustomTagHelpers
{
    [HtmlTargetElement(Attributes = "asp-active")]

    public class ActiveLinkTagHelper:TagHelper
    {
        private readonly IUrlHelperFactory _urlHelperFactory;

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        [HtmlAttributeName("asp-action")]
        public string Action { get; set; }

        [HtmlAttributeName("asp-controller")]
        public string Controller { get; set; }

        [HtmlAttributeName("asp-active")]
        public bool IsActive { get; set; }

        public ActiveLinkTagHelper(IUrlHelperFactory urlHelperFactory)
        {
            _urlHelperFactory = urlHelperFactory;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (IsActive && ViewContext.RouteData.Values.ContainsKey("controller") && ViewContext.RouteData.Values.ContainsKey("action"))
            {
                var urlHelper = _urlHelperFactory.GetUrlHelper(ViewContext);
                var currentController = ViewContext.RouteData.Values["controller"].ToString();
                var currentAction = ViewContext.RouteData.Values["action"].ToString();

                if (currentController == Controller && currentAction == Action)
                {
                    output.AddClass("active-link", HtmlEncoder.Default);
                }
            }
        }

    }
}
