#pragma checksum "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Shared\DisplayTemplates\PopularAnimeSeriesDisplayTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bbca10e4735d198ab529fff19687976a0764790"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Animes_Views_Shared_DisplayTemplates_PopularAnimeSeriesDisplayTemplate), @"mvc.1.0.view", @"/Areas/Animes/Views/Shared/DisplayTemplates/PopularAnimeSeriesDisplayTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Animes/Views/Shared/DisplayTemplates/PopularAnimeSeriesDisplayTemplate.cshtml", typeof(AspNetCore.Areas_Animes_Views_Shared_DisplayTemplates_PopularAnimeSeriesDisplayTemplate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bbca10e4735d198ab529fff19687976a0764790", @"/Areas/Animes/Views/Shared/DisplayTemplates/PopularAnimeSeriesDisplayTemplate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aab2b34897de31b98882045b9b5334c85c7bff4", @"/Areas/Animes/Views/_ViewImports.cshtml")]
    public class Areas_Animes_Views_Shared_DisplayTemplates_PopularAnimeSeriesDisplayTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PopularAnimeSeriesViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "animes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "anime", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 40, true);
            WriteLiteral("\r\n<div class=\"container-fluid col-12\">\r\n");
            EndContext();
#line 4 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Shared\DisplayTemplates\PopularAnimeSeriesDisplayTemplate.cshtml"
     foreach (var result in this.Model)
    {

#line default
#line hidden
            BeginContext(137, 73, true);
            WriteLiteral("        <div class=\"card d-inline-block\" style=\"width:24%\">\r\n            ");
            EndContext();
            BeginContext(210, 272, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcef22941869475db3b5f82dff62cdfb", async() => {
                BeginContext(312, 107, true);
                WriteLiteral("\r\n                <img class=\"card-img-top img-thumbnail\" style=\"width:300px;height:360px\" itemprop=\"image\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 419, "\"", 441, 1);
#line 8 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Shared\DisplayTemplates\PopularAnimeSeriesDisplayTemplate.cshtml"
WriteAttributeValue("", 425, result.ImageUrl, 425, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(442, 36, true);
                WriteLiteral(" alt=\"Card image cap\">\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 7 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Shared\DisplayTemplates\PopularAnimeSeriesDisplayTemplate.cshtml"
                                                                               WriteLiteral(result.AnimeSeriesId);

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
            BeginContext(482, 65, true);
            WriteLiteral("\r\n            <div class=\"text-center\">\r\n                Rating: ");
            EndContext();
            BeginContext(548, 28, false);
#line 11 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Shared\DisplayTemplates\PopularAnimeSeriesDisplayTemplate.cshtml"
                   Write(result.Rating.ToString("f1"));

#line default
#line hidden
            EndContext();
            BeginContext(576, 34, true);
            WriteLiteral("\r\n            </div>\r\n            ");
            EndContext();
            BeginContext(610, 324, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac7ce959fbaa4640ab9cc3a0855f9de0", async() => {
                BeginContext(712, 161, true);
                WriteLiteral("\r\n                <div class=\"card-body justify-content-center text-center\" style=\"display:flex\">\r\n                    <p style=\"height:80px\" class=\"card-title\">");
                EndContext();
                BeginContext(875, 12, false);
#line 15 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Shared\DisplayTemplates\PopularAnimeSeriesDisplayTemplate.cshtml"
                                                          Write(result.Title);

#line default
#line hidden
                EndContext();
                BeginContext(888, 42, true);
                WriteLiteral("</p>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Shared\DisplayTemplates\PopularAnimeSeriesDisplayTemplate.cshtml"
                                                                               WriteLiteral(result.AnimeSeriesId);

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
            BeginContext(934, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 19 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Animes\Views\Shared\DisplayTemplates\PopularAnimeSeriesDisplayTemplate.cshtml"
    }

#line default
#line hidden
            BeginContext(959, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PopularAnimeSeriesViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591