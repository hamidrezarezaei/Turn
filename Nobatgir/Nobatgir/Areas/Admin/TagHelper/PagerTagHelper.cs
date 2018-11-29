using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Nobatgir.Model;
using Nobatgir.ViewModel;

namespace Nobatgir.Areas.Admin
{
    [HtmlTargetElement("nav", Attributes = "page-model")]
    public class PagerTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;

        public PagerTagHelper(IUrlHelperFactory helperFactory)
        {
            urlHelperFactory = helperFactory;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public PagingData PageModel { get; set; }
        public string PageAction { get; set; }
        //            public string PageContoller { get; set; }
        public string ItemId { get; set; }
        public string searchString { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            var result = new TagBuilder("ul");

            result.Attributes["class"] = "pagination";

            if (PageModel.TotalPages == 1)
                return;

            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder litag = new TagBuilder("li");
                TagBuilder tag = new TagBuilder("a");

                litag.Attributes["class"] = "page-item";
                tag.Attributes["class"] = "page-link";

                //tag.Attributes["href"] = urlHelper.Action(PageAction, new { id = ItemId, pageNumber = i, searchString = searchString });

                var uriBuilder = new UriBuilder("http://" + ViewContext.HttpContext.Request.Host + ViewContext.HttpContext.Request.Path);
                var query = HttpUtility.ParseQueryString(uriBuilder.Query);
                query["pageNumber"] = i.ToString();

                if (searchString != "")
                    query["searchString"] = searchString;

                uriBuilder.Query = query.ToString();

                tag.Attributes["href"] = uriBuilder.ToString();

                tag.InnerHtml.Append(i.ToString());
                litag.InnerHtml.AppendHtml(tag);
                result.InnerHtml.AppendHtml(litag);
            }
            output.Content.AppendHtml(result);
        }
    }
}
