#pragma checksum "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Anime\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c60fe844d8a1b482a77aeb2c3cf6d3aea1a0c1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Animes_Views_Anime_Details), @"mvc.1.0.view", @"/Areas/Animes/Views/Anime/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Animes/Views/Anime/Details.cshtml", typeof(AspNetCore.Areas_Animes_Views_Anime_Details))]
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
#line 1 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\_ViewImports.cshtml"
using MyAnimeWorld.Models;

#line default
#line hidden
#line 2 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\_ViewImports.cshtml"
using MyAnimeWorld.Common.Animes.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\_ViewImports.cshtml"
using MyAnimeWorld.App.Areas.Animes;

#line default
#line hidden
#line 4 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\_ViewImports.cshtml"
using MyAnimeWorld.Common.Main.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\_ViewImports.cshtml"
using MyAnimeWorld.Common.Utilities.Constants;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c60fe844d8a1b482a77aeb2c3cf6d3aea1a0c1b", @"/Areas/Animes/Views/Anime/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aab2b34897de31b98882045b9b5334c85c7bff4", @"/Areas/Animes/Views/_ViewImports.cshtml")]
    public class Areas_Animes_Views_Anime_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnimeDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Rating.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Animes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Anime", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 12, true);
            WriteLiteral("\r\n<br />\r\n\r\n");
            EndContext();
            BeginContext(42, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c772c4da300a4ab58641cd2c7450d8d6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(91, 68, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-9\"></div>\r\n    <div>\r\n");
            EndContext();
#line 10 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Anime\Details.cshtml"
         if (this.User.IsInRole(DbConstants.Admin_Role))
        {

#line default
#line hidden
            BeginContext(228, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 242, "\"", 281, 2);
            WriteAttributeValue("", 249, "/admin/addepisode/", 249, 18, true);
#line 12 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Anime\Details.cshtml"
WriteAttributeValue("", 267, this.Model.Id, 267, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(282, 60, true);
            WriteLiteral(" class=\"btn btn-success\">Add new episode</a>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 342, "\"", 383, 2);
            WriteAttributeValue("", 349, "/admin/deleteseries/", 349, 20, true);
#line 13 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Anime\Details.cshtml"
WriteAttributeValue("", 369, this.Model.Id, 369, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(384, 42, true);
            WriteLiteral(" class=\"btn btn-danger\">Delete anime</a>\r\n");
            EndContext();
#line 14 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Anime\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(437, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(459, 814, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0fdadfd71fd479c8634d7c4b0c5ac12", async() => {
                BeginContext(557, 114, true);
                WriteLiteral("\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n            <div class=\"rating\">\r\n                ");
                EndContext();
                BeginContext(672, 55, false);
#line 22 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Anime\Details.cshtml"
           Write(Html.DisplayFor(p => p.Rating, "RatingDisplayTemplate"));

#line default
#line hidden
                EndContext();
                BeginContext(727, 64, true);
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"rating\" id=\"rating\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 791, "\"", 817, 1);
#line 23 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Anime\Details.cshtml"
WriteAttributeValue("", 799, this.Model.Rating, 799, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(818, 168, true);
                WriteLiteral(" />\r\n            </div>\r\n            <input type=\"submit\" name=\"submitType\" class=\"btn btn-success\" value=\"Submit Rating\" />\r\n        </div>\r\n    </div>\r\n\r\n    <br />\r\n");
                EndContext();
#line 30 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Anime\Details.cshtml"
     if (this.Model.IsFavourite)
    {

#line default
#line hidden
                BeginContext(1027, 105, true);
                WriteLiteral("        <input type=\"submit\" name=\"submitType\" class=\"btn btn-danger\" value=\"Remove from Favourites\" />\r\n");
                EndContext();
#line 33 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Anime\Details.cshtml"
    }
    else
    {

#line default
#line hidden
                BeginContext(1156, 101, true);
                WriteLiteral("        <input type=\"submit\" name=\"submitType\" class=\"btn btn-success\" value=\"Add to Favourites\" />\r\n");
                EndContext();
#line 37 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Anime\Details.cshtml"
    }

#line default
#line hidden
                BeginContext(1264, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 18 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Anime\Details.cshtml"
                                                                      WriteLiteral(this.Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1273, 90, true);
            WriteLiteral("\r\n\r\n<table>\r\n    <tr>\r\n        <td style=\"width:25%;vertical-align:top\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1363, "\"", 1389, 1);
#line 44 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Anime\Details.cshtml"
WriteAttributeValue("", 1369, this.Model.ImageUrl, 1369, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1390, 33, true);
            WriteLiteral(" style=\"width:300px;height:360px\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 1423, "\"", 1465, 4);
            WriteAttributeValue("", 1429, "Front", 1429, 5, true);
            WriteAttributeValue(" ", 1434, "image", 1435, 6, true);
            WriteAttributeValue(" ", 1440, "for", 1441, 4, true);
#line 44 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Anime\Details.cshtml"
WriteAttributeValue(" ", 1444, this.Model.ImageUrl, 1445, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1466, 68, true);
            WriteLiteral(" />\r\n        </td>\r\n        <td style=\"width:60%\">\r\n            <h4>");
            EndContext();
            BeginContext(1535, 16, false);
#line 47 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Anime\Details.cshtml"
           Write(this.Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1551, 22, true);
            WriteLiteral("</h4>\r\n            <p>");
            EndContext();
            BeginContext(1574, 22, false);
#line 48 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Anime\Details.cshtml"
          Write(this.Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1596, 18, true);
            WriteLiteral("</p>\r\n            ");
            EndContext();
            BeginContext(1615, 70, false);
#line 49 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Anime\Details.cshtml"
       Write(Html.DisplayFor(p => p.Categories, "DetailsCategoriesDisplayTemplate"));

#line default
#line hidden
            EndContext();
            BeginContext(1685, 54, true);
            WriteLiteral("\r\n            <br />\r\n            <br />\r\n            ");
            EndContext();
            BeginContext(1740, 66, false);
#line 52 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Anime\Details.cshtml"
       Write(Html.DisplayFor(p => p.Episodes, "DetailsEpisodesDisplayTemplate"));

#line default
#line hidden
            EndContext();
            BeginContext(1806, 36, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnimeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
