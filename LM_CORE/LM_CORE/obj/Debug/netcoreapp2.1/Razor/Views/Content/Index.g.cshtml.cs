#pragma checksum "D:\2019\Project\kpsoft\LM\LM_CORE\LM_CORE\Views\Content\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f577d5906bf3da68a00282e0ca19956310ec831d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Content_Index), @"mvc.1.0.view", @"/Views/Content/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Content/Index.cshtml", typeof(AspNetCore.Views_Content_Index))]
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
#line 1 "D:\2019\Project\kpsoft\LM\LM_CORE\LM_CORE\Views\_ViewImports.cshtml"
using LM_CORE;

#line default
#line hidden
#line 2 "D:\2019\Project\kpsoft\LM\LM_CORE\LM_CORE\Views\_ViewImports.cshtml"
using LM_CORE.Models;

#line default
#line hidden
#line 2 "D:\2019\Project\kpsoft\LM\LM_CORE\LM_CORE\Views\Content\Index.cshtml"
using Humanizer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f577d5906bf3da68a00282e0ca19956310ec831d", @"/Views/Content/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bde768883039bad6784a595a40199d8f13b8251", @"/Views/_ViewImports.cshtml")]
    public class Views_Content_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LM_CORE.Models.ContentViewMode>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\2019\Project\kpsoft\LM\LM_CORE\LM_CORE\Views\Content\Index.cshtml"
  
    ViewData["Title"] = "内容列表";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(145, 79, true);
            WriteLiteral("\r\n<div class=\"panel panel-default todo-panel\">\r\n    <div class=\"panel-heading\">");
            EndContext();
            BeginContext(225, 17, false);
#line 9 "D:\2019\Project\kpsoft\LM\LM_CORE\LM_CORE\Views\Content\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(242, 314, true);
            WriteLiteral(@"</div>

    <table class=""table table-hover"">
        <thead>
            <tr>
                <td> <input type=""checkbox"" class=""done-checkbox""></td>
                <td>序号</td>
                <td>标题</td>
                <td>内容</td>
                <td>添加时间</td>
            </tr>
        </thead>

");
            EndContext();
#line 22 "D:\2019\Project\kpsoft\LM\LM_CORE\LM_CORE\Views\Content\Index.cshtml"
         foreach (var item in Model.Contents)
        {

#line default
#line hidden
            BeginContext(614, 150, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <input type=\"checkbox\" class=\"done-checkbox\">\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(765, 7, false);
#line 28 "D:\2019\Project\kpsoft\LM\LM_CORE\LM_CORE\Views\Content\Index.cshtml"
               Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(772, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(800, 10, false);
#line 29 "D:\2019\Project\kpsoft\LM\LM_CORE\LM_CORE\Views\Content\Index.cshtml"
               Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(810, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(838, 12, false);
#line 30 "D:\2019\Project\kpsoft\LM\LM_CORE\LM_CORE\Views\Content\Index.cshtml"
               Write(item.content);

#line default
#line hidden
            EndContext();
            BeginContext(850, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(878, 24, false);
#line 31 "D:\2019\Project\kpsoft\LM\LM_CORE\LM_CORE\Views\Content\Index.cshtml"
               Write(item.add_time.Humanize());

#line default
#line hidden
            EndContext();
            BeginContext(902, 28, true);
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 34 "D:\2019\Project\kpsoft\LM\LM_CORE\LM_CORE\Views\Content\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(941, 24, true);
            WriteLiteral("    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LM_CORE.Models.ContentViewMode> Html { get; private set; }
    }
}
#pragma warning restore 1591