#pragma checksum "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b76b8251c090733864050e59f9761f38e6c67611"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Details), @"mvc.1.0.view", @"/Views/Posts/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Posts/Details.cshtml", typeof(AspNetCore.Views_Posts_Details))]
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
#line 1 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 3 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
using WebApp2.Options;

#line default
#line hidden
#line 5 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 6 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 8 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
using WebApp2.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b76b8251c090733864050e59f9761f38e6c67611", @"/Views/Posts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17a3e8230cdadded111162f1ff1bad1f7b3ff492", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp2.Models.Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("sendcomm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(96, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(181, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(238, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(522, 25, true);
            WriteLiteral("<h2 class=\"post_caption\">");
            EndContext();
            BeginContext(548, 13, false);
#line 19 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
                    Write(Model.Caption);

#line default
#line hidden
            EndContext();
            BeginContext(561, 39, true);
            WriteLiteral("</h2>\r\n<div class=\"post_img\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 600, "\"", 626, 1);
#line 21 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
WriteAttributeValue("", 606, Model.PostImagePath, 606, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(627, 139, true);
            WriteLiteral(" max-width=\"500\" max-height=\"auto\" class=\"images\" alt=\"\" & onerror=\"this.style.display = \'none\'\" />\r\n</div>\r\n\r\n<div class=\"post_txt\">\r\n    ");
            EndContext();
            BeginContext(767, 13, false);
#line 25 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
Write(Model.Content);

#line default
#line hidden
            EndContext();
            BeginContext(780, 177, true);
            WriteLiteral("\r\n</div>\r\n<div class=\"likes_date\">\r\n    <div id=\"postdiv\" class=\"likes\">\r\n        <input type=\"image\" value=\"\" max-width=\"7px\" height=\"auto\" alt=\"button\" src=\"/images/heart.png\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 957, "\"", 989, 3);
            WriteAttributeValue("", 967, "addLikePost(", 967, 12, true);
#line 29 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
WriteAttributeValue("", 979, Model.Id, 979, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 988, ")", 988, 1, true);
            EndWriteAttribute();
            BeginContext(990, 19, true);
            WriteLiteral(" />\r\n        (<span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1009, "\"", 1029, 2);
            WriteAttributeValue("", 1014, "likes-", 1014, 6, true);
#line 30 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
WriteAttributeValue("", 1020, Model.Id, 1020, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1030, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1032, 11, false);
#line 30 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
                               Write(Model.Likes);

#line default
#line hidden
            EndContext();
            BeginContext(1043, 54, true);
            WriteLiteral("</span>)\r\n    </div>\r\n    <div class=\"date\">\r\n        ");
            EndContext();
            BeginContext(1098, 17, false);
#line 33 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
   Write(Model.DateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(1115, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(1137, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d43d43b447154348b81707e970f0b621", async() => {
                BeginContext(1183, 18, true);
                WriteLiteral("Редактировать пост");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
                       WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1205, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1207, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5d74b17fb1d41c189648249e6de1669", async() => {
                BeginContext(1255, 12, true);
                WriteLiteral("Удалить пост");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
                         WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1271, 86, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"comments\">\r\n    <dl class=\"dl-horizontal\" id=\"comments_container\">\r\n");
            EndContext();
            BeginContext(1382, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1391, 56, false);
#line 45 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
   Write(await Html.PartialAsync("CommentsList", @Model.Comments));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 58, true);
            WriteLiteral(";\r\n\r\n    </dl>\r\n</div>\r\n<div id=\"commentsDiv\">\r\n\r\n    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1505, "\"", 1531, 2);
            WriteAttributeValue("", 1510, "sendComment-", 1510, 12, true);
#line 51 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
WriteAttributeValue("", 1522, Model.Id, 1522, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1532, 11, true);
            WriteLiteral(">\r\n        ");
            EndContext();
            BeginContext(1543, 651, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6320538c8c9943fba4efb9f9174514f2", async() => {
                BeginContext(1587, 194, true);
                WriteLiteral("\r\n            <textarea id=\"commentTextInput\" required></textarea>\r\n            <br />\r\n            <input type=\"email\" id=\"authCommentEmail\" placeholder=\"e-mail\" required>\r\n            <br />\r\n");
                EndContext();
                BeginContext(2066, 32, true);
                WriteLiteral("            <input type=\"submit\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 2098, "\"", 2155, 6);
                WriteAttributeValue("", 2108, "sendComment(\'", 2108, 13, true);
#line 62 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
WriteAttributeValue("", 2121, Model.Id, 2121, 9, false);

#line default
#line hidden
                WriteAttributeValue("", 2130, "\',", 2130, 2, true);
                WriteAttributeValue(" ", 2132, "\'", 2133, 2, true);
#line 62 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
WriteAttributeValue("", 2134, User.Identity.Name, 2134, 19, false);

#line default
#line hidden
                WriteAttributeValue("", 2153, "\')", 2153, 2, true);
                EndWriteAttribute();
                BeginContext(2156, 31, true);
                WriteLiteral(" value=\"Отправить\" />\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2194, 30, true);
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2247, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2776, 152, true);
                WriteLiteral("    \r\n    \r\n\r\n    <script>\r\n       \r\n    </script>\r\n    <script>\r\n        $( document ).ready(function() {\r\n            $.ajax({\r\n                url: \'");
                EndContext();
                BeginContext(2929, 35, false);
#line 94 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
                 Write(Url.Action("CommentsList", "Posts"));

#line default
#line hidden
                EndContext();
                BeginContext(2964, 69, true);
                WriteLiteral("\',\r\n                type: \'POST\',\r\n                data: { \'postId\': ");
                EndContext();
                BeginContext(3034, 8, false);
#line 96 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
                             Write(Model.Id);

#line default
#line hidden
                EndContext();
                BeginContext(3042, 777, true);
                WriteLiteral(@" },
                success: function(data) {

                    $('#comments_container').html('<div>' + data + '</div>');

                },
                error: function(data) {
                    console.log('Ошибка во время отправки комментария');
                }
            });
        });
        function sendComment(postId) {
            var authComEmail = $(""#authCommentEmail"").val();
            var commTextInput = $(""#commentTextInput"").val();
            if (commTextInput === """") {
                sendComment.preventDefault();
            }
            else  if (authComEmail === """") {
                sendComment.preventDefault();
                alert(""заполните поле"");
            }
            $.ajax({
                url: '");
                EndContext();
                BeginContext(3820, 34, false);
#line 118 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
                 Write(Url.Action("AjaxComment", "Posts"));

#line default
#line hidden
                EndContext();
                BeginContext(3854, 669, true);
                WriteLiteral(@"',
                type: 'POST',

                data: { 'postId': postId, 'login': $('#authCommentEmail').val(), 'content': $('#commentTextInput').val() },
                success: function(data) {
                    console.log('все ок');
                    console.log(data);
                    $('#comments_container').append('<div>' + data + '</div>');
                },
                error: function(data) {
                    console.log('Ошибка во время отправки комментария');
                }
            });
        }

    </script>

    <script>
        function addLikePost(postId) {
            $.ajax({
                url: '");
                EndContext();
                BeginContext(4524, 27, false);
#line 138 "E:\собеседование\джин\мих_дуд\WebApp2\WebApp2\Views\Posts\Details.cshtml"
                 Write(Url.Action("Like", "Posts"));

#line default
#line hidden
                EndContext();
                BeginContext(4551, 292, true);
                WriteLiteral(@"',
                type: 'POST',
                data: { 'postId': postId },
                success: function(data) {
                    $('#likes-' + postId).html(data);
                },
                error: console.log('Ошибка ')
            });
        }
    </script>


");
                EndContext();
            }
            );
            BeginContext(4846, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<ReCaptchaOptions> ReCaptchaOptions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<AppOptions> AppOptions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp2.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591