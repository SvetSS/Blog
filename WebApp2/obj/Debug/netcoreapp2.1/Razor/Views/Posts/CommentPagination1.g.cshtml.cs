#pragma checksum "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\CommentPagination1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e66b677a9871c26e3ceccca94d969f84344d1d41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_CommentPagination1), @"mvc.1.0.view", @"/Views/Posts/CommentPagination1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Posts/CommentPagination1.cshtml", typeof(AspNetCore.Views_Posts_CommentPagination1))]
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
#line 1 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\_ViewImports.cshtml"
using WebApp2;

#line default
#line hidden
#line 2 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\_ViewImports.cshtml"
using WebApp2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e66b677a9871c26e3ceccca94d969f84344d1d41", @"/Views/Posts/CommentPagination1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17a3e8230cdadded111162f1ff1bad1f7b3ff492", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_CommentPagination1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp2.ViewModels.CommentsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 111, true);
            WriteLiteral("\r\n<div>\r\n    <h4>CommentsViewModel</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(157, 42, false);
#line 8 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\CommentPagination1.cshtml"
       Write(Html.DisplayNameFor(model => model.PostId));

#line default
#line hidden
            EndContext();
            BeginContext(199, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(243, 38, false);
#line 11 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\CommentPagination1.cshtml"
       Write(Html.DisplayFor(model => model.PostId));

#line default
#line hidden
            EndContext();
            BeginContext(281, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp2.ViewModels.CommentsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
