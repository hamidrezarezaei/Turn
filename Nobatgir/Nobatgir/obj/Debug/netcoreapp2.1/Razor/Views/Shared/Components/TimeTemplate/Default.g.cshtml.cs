#pragma checksum "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9592cfa4b7cb56b27ad9497444d8da518cb7e945"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TimeTemplate_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TimeTemplate/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TimeTemplate/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_TimeTemplate_Default))]
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
#line 1 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\_ViewImports.cshtml"
using Nobatgir.Model;

#line default
#line hidden
#line 2 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\_ViewImports.cshtml"
using Nobatgir.Data;

#line default
#line hidden
#line 3 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\_ViewImports.cshtml"
using Nobatgir.ViewModel;

#line default
#line hidden
#line 4 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\_ViewImports.cshtml"
using Nobatgir.Util;

#line default
#line hidden
#line 5 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\_ViewImports.cshtml"
using Nobatgir.Services;

#line default
#line hidden
#line 7 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\_ViewImports.cshtml"
using Nobatgir.Areas.Admin.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9592cfa4b7cb56b27ad9497444d8da518cb7e945", @"/Views/Shared/Components/TimeTemplate/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6070da3a106ce176a3725f683aab549e20ce4c3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TimeTemplate_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TimeTemplateViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddTurn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Expert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
  
    int index = 1;

#line default
#line hidden
            BeginContext(65, 89, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n    <ul class=\"nav nav-tabs col-12\" id=\"myTab\" role=\"tablist\">\r\n\r\n");
            EndContext();
#line 11 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
         foreach (var item in Model)
        {
            string c = "";
            if (index == 1)
            {
                c = "active";
            }


#line default
#line hidden
            BeginContext(323, 53, true);
            WriteLiteral("            <li class=\"nav-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 376, "\"", 395, 2);
            WriteAttributeValue("", 384, "nav-link", 384, 8, true);
#line 20 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
WriteAttributeValue(" ", 392, c, 393, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(396, 32, true);
            WriteLiteral(" id=\"home-tab\" data-toggle=\"tab\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 428, "\"", 446, 2);
            WriteAttributeValue("", 435, "#tab_", 435, 5, true);
#line 20 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
WriteAttributeValue("", 440, index, 440, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(447, 54, true);
            WriteLiteral(" role=\"tab\" aria-controls=\"home\" aria-selected=\"true\">");
            EndContext();
            BeginContext(502, 12, false);
#line 20 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
                                                                                                                                          Write(item.FullDay);

#line default
#line hidden
            EndContext();
            BeginContext(514, 25, true);
            WriteLiteral("</a>\r\n            </li>\r\n");
            EndContext();
#line 22 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"

            index++;
        }

#line default
#line hidden
            BeginContext(574, 71, true);
            WriteLiteral("\r\n    </ul>\r\n    <div class=\"tab-content col-12\" id=\"myTabContent\">\r\n\r\n");
            EndContext();
#line 29 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
           index = 1; 

#line default
#line hidden
            BeginContext(670, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 31 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
         foreach (var item in Model)
        {
            string c = "";
            if (index == 1)
            {
                c = "active";
            }


#line default
#line hidden
            BeginContext(841, 16, true);
            WriteLiteral("            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 857, "\"", 886, 4);
            WriteAttributeValue("", 865, "tab-pane", 865, 8, true);
            WriteAttributeValue(" ", 873, "fade", 874, 5, true);
            WriteAttributeValue(" ", 878, "show", 879, 5, true);
#line 39 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
WriteAttributeValue(" ", 883, c, 884, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 887, "\"", 902, 2);
            WriteAttributeValue("", 892, "tab_", 892, 4, true);
#line 39 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
WriteAttributeValue("", 896, index, 896, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(903, 87, true);
            WriteLiteral(" role=\"tabpanel\" aria-labelledby=\"home-tab\">\r\n\r\n                <div class=\"row p-2\">\r\n");
            EndContext();
#line 42 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
                     foreach (var turn in item.Turns)
                    {

#line default
#line hidden
            BeginContext(1068, 58, true);
            WriteLiteral("                        <div class=\"col-4 col-md-2 p-1\">\r\n");
            EndContext();
#line 45 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
                             if (turn.Status == TurnStatuses.Free)
                            {

#line default
#line hidden
            BeginContext(1225, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1257, 404, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17e0884989194849bdeffed4e7bb9d72", async() => {
                BeginContext(1322, 74, true);
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"turndate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1396, "\"", 1413, 1);
#line 48 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
WriteAttributeValue("", 1404, item.Day, 1404, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1414, 71, true);
                WriteLiteral(">\r\n                                    <input type=\"hidden\" name=\"time\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1485, "\"", 1503, 1);
#line 49 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
WriteAttributeValue("", 1493, turn.Time, 1493, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1504, 97, true);
                WriteLiteral(">\r\n\r\n                                    <button type=\"submit\" class=\"btn btn-success btn-block\">");
                EndContext();
                BeginContext(1602, 9, false);
#line 51 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
                                                                                       Write(turn.Time);

#line default
#line hidden
                EndContext();
                BeginContext(1611, 43, true);
                WriteLiteral("</button>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1661, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 53 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
                            }
                            else if (turn.Status == TurnStatuses.Completed)
                            {

#line default
#line hidden
            BeginContext(1802, 82, true);
            WriteLiteral("                                <button class=\"btn btn-danger btn-block\" disabled>");
            EndContext();
            BeginContext(1885, 9, false);
#line 56 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
                                                                             Write(turn.Time);

#line default
#line hidden
            EndContext();
            BeginContext(1894, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 57 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
                            }
                            else if (turn.Status == TurnStatuses.Reserve)
                            {

#line default
#line hidden
            BeginContext(2042, 83, true);
            WriteLiteral("                                <button class=\"btn btn-warning btn-block\" disabled>");
            EndContext();
            BeginContext(2126, 9, false);
#line 60 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
                                                                              Write(turn.Time);

#line default
#line hidden
            EndContext();
            BeginContext(2135, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 61 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
                            }

#line default
#line hidden
            BeginContext(2177, 32, true);
            WriteLiteral("                        </div>\r\n");
            EndContext();
#line 63 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
                    }

#line default
#line hidden
            BeginContext(2232, 44, true);
            WriteLiteral("                </div>\r\n            </div>\r\n");
            EndContext();
#line 66 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"

            index++;
        }

#line default
#line hidden
            BeginContext(2311, 18, true);
            WriteLiteral("    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Repository Repository { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TimeTemplateViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
