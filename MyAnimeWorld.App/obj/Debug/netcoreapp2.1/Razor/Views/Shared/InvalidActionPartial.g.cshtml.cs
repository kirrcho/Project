#pragma checksum "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Views\Shared\InvalidActionPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0281c8a28d8a0505ea383819ba4d9c10efac151"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_InvalidActionPartial), @"mvc.1.0.view", @"/Views/Shared/InvalidActionPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/InvalidActionPartial.cshtml", typeof(AspNetCore.Views_Shared_InvalidActionPartial))]
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
#line 1 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Views\_ViewImports.cshtml"
using MyAnimeWorld.Models;

#line default
#line hidden
#line 2 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Views\_ViewImports.cshtml"
using MyAnimeWorld.App.Models;

#line default
#line hidden
#line 3 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Views\_ViewImports.cshtml"
using MyAnimeWorld.Common.Main.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Views\_ViewImports.cshtml"
using MyAnimeWorld.Common.Utilities.Constants;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0281c8a28d8a0505ea383819ba4d9c10efac151", @"/Views/Shared/InvalidActionPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33d71df96d23e4c13b196faa4e6d829d1a5e2545", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_InvalidActionPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Views\Shared\InvalidActionPartial.cshtml"
 if (this.TempData.ContainsKey(ErrorConstants.Error_Key))
{

#line default
#line hidden
            BeginContext(62, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(76, 50, true);
            WriteLiteral("    <div class=\"alert alert-danger text-center\">\r\n");
            EndContext();
#line 6 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Views\Shared\InvalidActionPartial.cshtml"
         foreach (var error in this.TempData.Where(p => p.Key == ErrorConstants.Error_Key))
        {

#line default
#line hidden
            BeginContext(230, 15, true);
            WriteLiteral("            <b>");
            EndContext();
            BeginContext(246, 11, false);
#line 8 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Views\Shared\InvalidActionPartial.cshtml"
          Write(error.Value);

#line default
#line hidden
            EndContext();
            BeginContext(257, 6, true);
            WriteLiteral("</b>\r\n");
            EndContext();
#line 9 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Views\Shared\InvalidActionPartial.cshtml"
        }

#line default
#line hidden
            BeginContext(274, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 11 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Views\Shared\InvalidActionPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
