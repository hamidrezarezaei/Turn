#pragma checksum "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Expert\Details_partial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3ee717554fc70253c9477696fa1b10cf6138771"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Expert_Details_partial), @"mvc.1.0.view", @"/Areas/Admin/Views/Expert/Details_partial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Expert/Details_partial.cshtml", typeof(AspNetCore.Areas_Admin_Views_Expert_Details_partial))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\_ViewImports.cshtml"
using Nobatgir.Model;

#line default
#line hidden
#line 2 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\_ViewImports.cshtml"
using Nobatgir.Data;

#line default
#line hidden
#line 3 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3ee717554fc70253c9477696fa1b10cf6138771", @"/Areas/Admin/Views/Expert/Details_partial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6af81e192758d2bfde91ed6c14e671b122ee7e13", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Expert_Details_partial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Expert>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 128, true);
            WriteLiteral("\r\n<div class=\"admin-data-box\">\r\n    <table class=\"table detail table-striped\">\r\n        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(144, 44, false);
#line 7 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Expert\Details_partial.cshtml"
           Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(188, 22, true);
            WriteLiteral(":\r\n            </td>\r\n");
            EndContext();
#line 9 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Expert\Details_partial.cshtml"
             if (ViewBag.ActionType == "create" || ViewBag.ActionType == "edit")
            {

#line default
#line hidden
            BeginContext(307, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(327, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8c462961c19e4523878dd6596ae5a8ce", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 11 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Expert\Details_partial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IsActive);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(355, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 12 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Expert\Details_partial.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(410, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(453, 40, false);
#line 16 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Expert\Details_partial.cshtml"
               Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(493, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 18 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Expert\Details_partial.cshtml"
            }

#line default
#line hidden
            BeginContext(533, 63, true);
            WriteLiteral("        </tr>\r\n        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(597, 40, false);
#line 22 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Expert\Details_partial.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(637, 22, true);
            WriteLiteral(":\r\n            </td>\r\n");
            EndContext();
#line 24 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Expert\Details_partial.cshtml"
             if (ViewBag.ActionType == "create" || ViewBag.ActionType == "edit")
            {

#line default
#line hidden
            BeginContext(756, 32, true);
            WriteLiteral("                <td class=\"ltr\">");
            EndContext();
            BeginContext(788, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "622922c80de24300959604ea14e76af9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 26 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Expert\Details_partial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(833, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 27 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Expert\Details_partial.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(888, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(931, 36, false);
#line 31 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Expert\Details_partial.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(967, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 33 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Expert\Details_partial.cshtml"
            }

#line default
#line hidden
            BeginContext(1007, 63, true);
            WriteLiteral("        </tr>\r\n        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1071, 41, false);
#line 37 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Expert\Details_partial.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1112, 22, true);
            WriteLiteral(":\r\n            </td>\r\n");
            EndContext();
#line 39 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Expert\Details_partial.cshtml"
             if (ViewBag.ActionType == "create" || ViewBag.ActionType == "edit")
            {

#line default
#line hidden
            BeginContext(1231, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(1251, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "561ca48af53b49a3856e1b2a21cc77e2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 41 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Expert\Details_partial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Title);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1297, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 42 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Expert\Details_partial.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1352, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(1395, 37, false);
#line 46 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Expert\Details_partial.cshtml"
               Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1432, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 48 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Expert\Details_partial.cshtml"
            }

#line default
#line hidden
            BeginContext(1472, 52, true);
            WriteLiteral("        </tr>\r\n     \r\n\r\n    </table>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Expert> Html { get; private set; }
    }
}
#pragma warning restore 1591
