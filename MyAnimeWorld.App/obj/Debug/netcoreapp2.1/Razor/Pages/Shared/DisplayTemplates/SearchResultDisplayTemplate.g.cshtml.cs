#pragma checksum "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Pages\Shared\DisplayTemplates\SearchResultDisplayTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "154b1440e0b96d111a0ce500d39c2c947508a159"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shared_DisplayTemplates_SearchResultDisplayTemplate), @"mvc.1.0.view", @"/Pages/Shared/DisplayTemplates/SearchResultDisplayTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/DisplayTemplates/SearchResultDisplayTemplate.cshtml", typeof(AspNetCore.Pages_Shared_DisplayTemplates_SearchResultDisplayTemplate))]
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
#line 1 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Pages\_ViewImports.cshtml"
using MyAnimeWorld.Models;

#line default
#line hidden
#line 2 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Pages\_ViewImports.cshtml"
using MyAnimeWorld.App.Pages;

#line default
#line hidden
#line 3 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Pages\_ViewImports.cshtml"
using MyAnimeWorld.Common.Main.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"154b1440e0b96d111a0ce500d39c2c947508a159", @"/Pages/Shared/DisplayTemplates/SearchResultDisplayTemplate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e46b6ae32d257851e781e557b595553329a8f28", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_DisplayTemplates_SearchResultDisplayTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AnimeSeriesViewModel>>
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
            BeginContext(42, 40, true);
            WriteLiteral("\r\n<div class=\"container-fluid col-12\">\r\n");
            EndContext();
#line 4 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Pages\Shared\DisplayTemplates\SearchResultDisplayTemplate.cshtml"
     foreach (var result in this.Model)
    {

#line default
#line hidden
            BeginContext(130, 73, true);
            WriteLiteral("        <div class=\"card d-inline-block\" style=\"width:24%\">\r\n            ");
            EndContext();
            BeginContext(203, 271, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebc878ade9474ee2a6eccbd32db736f5", async() => {
                BeginContext(305, 107, true);
                WriteLiteral("\r\n                <img class=\"card-img-top img-thumbnail\" style=\"width:300px;height:360px\" itemprop=\"image\"");
                EndContext();
                BeginWriteAttribute("src", "src=\"", 412, "\"", 433, 1);
#line 8 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Pages\Shared\DisplayTemplates\SearchResultDisplayTemplate.cshtml"
WriteAttributeValue("", 417, result.ImageUrl, 417, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(434, 36, true);
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
#line 7 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Pages\Shared\DisplayTemplates\SearchResultDisplayTemplate.cshtml"
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
            BeginContext(474, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(488, 324, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad94f052970946939131e5c50f2be543", async() => {
                BeginContext(590, 161, true);
                WriteLiteral("\r\n                <div class=\"card-body justify-content-center text-center\" style=\"display:flex\">\r\n                    <p style=\"height:80px\" class=\"card-title\">");
                EndContext();
                BeginContext(753, 12, false);
#line 12 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Pages\Shared\DisplayTemplates\SearchResultDisplayTemplate.cshtml"
                                                          Write(result.Title);

#line default
#line hidden
                EndContext();
                BeginContext(766, 42, true);
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
#line 10 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Pages\Shared\DisplayTemplates\SearchResultDisplayTemplate.cshtml"
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
            BeginContext(812, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 16 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Pages\Shared\DisplayTemplates\SearchResultDisplayTemplate.cshtml"
    }

#line default
#line hidden
            BeginContext(837, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AnimeSeriesViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
