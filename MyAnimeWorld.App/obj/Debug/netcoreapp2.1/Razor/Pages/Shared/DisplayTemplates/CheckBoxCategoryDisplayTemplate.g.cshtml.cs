#pragma checksum "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Pages\Shared\DisplayTemplates\CheckBoxCategoryDisplayTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd9444bc8944e4a5f5349defbc8ea5ab2bfee399"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shared_DisplayTemplates_CheckBoxCategoryDisplayTemplate), @"mvc.1.0.view", @"/Pages/Shared/DisplayTemplates/CheckBoxCategoryDisplayTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/DisplayTemplates/CheckBoxCategoryDisplayTemplate.cshtml", typeof(AspNetCore.Pages_Shared_DisplayTemplates_CheckBoxCategoryDisplayTemplate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd9444bc8944e4a5f5349defbc8ea5ab2bfee399", @"/Pages/Shared/DisplayTemplates/CheckBoxCategoryDisplayTemplate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e46b6ae32d257851e781e557b595553329a8f28", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_DisplayTemplates_CheckBoxCategoryDisplayTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IDictionary<int, string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Pages\Shared\DisplayTemplates\CheckBoxCategoryDisplayTemplate.cshtml"
 foreach (var category in this.Model)
{

#line default
#line hidden
            BeginContext(77, 48, true);
            WriteLiteral("    <div class=\"form-check form-check-inline\">\r\n");
            EndContext();
#line 6 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Pages\Shared\DisplayTemplates\CheckBoxCategoryDisplayTemplate.cshtml"
         if (((ICollection<int>)this.ViewData["CheckedBoxes"])?.Contains(category.Key) ?? false)
        {

#line default
#line hidden
            BeginContext(234, 107, true);
            WriteLiteral("            <input checked class=\"form-check-input\" type=\"checkbox\" id=\"CategoriesIds\" name=\"CategoriesIds\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 341, "\"", 362, 1);
#line 8 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Pages\Shared\DisplayTemplates\CheckBoxCategoryDisplayTemplate.cshtml"
WriteAttributeValue("", 349, category.Key, 349, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(363, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 9 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Pages\Shared\DisplayTemplates\CheckBoxCategoryDisplayTemplate.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(402, 99, true);
            WriteLiteral("            <input class=\"form-check-input\" type=\"checkbox\" id=\"CategoriesIds\" name=\"CategoriesIds\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 501, "\"", 522, 1);
#line 12 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Pages\Shared\DisplayTemplates\CheckBoxCategoryDisplayTemplate.cshtml"
WriteAttributeValue("", 509, category.Key, 509, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(523, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 13 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Pages\Shared\DisplayTemplates\CheckBoxCategoryDisplayTemplate.cshtml"
        }

#line default
#line hidden
            BeginContext(537, 40, true);
            WriteLiteral("        <label class=\"form-check-label\">");
            EndContext();
            BeginContext(578, 14, false);
#line 14 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Pages\Shared\DisplayTemplates\CheckBoxCategoryDisplayTemplate.cshtml"
                                   Write(category.Value);

#line default
#line hidden
            EndContext();
            BeginContext(592, 22, true);
            WriteLiteral("</label>\r\n    </div>\r\n");
            EndContext();
#line 16 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Pages\Shared\DisplayTemplates\CheckBoxCategoryDisplayTemplate.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IDictionary<int, string>> Html { get; private set; }
    }
}
#pragma warning restore 1591