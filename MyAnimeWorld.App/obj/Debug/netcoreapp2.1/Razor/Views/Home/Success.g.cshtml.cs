#pragma checksum "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Views\Home\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c27daff8857b2addfaffefa386ae6b3b2375683"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Success), @"mvc.1.0.view", @"/Views/Home/Success.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Success.cshtml", typeof(AspNetCore.Views_Home_Success))]
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
#line 5 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Views\_ViewImports.cshtml"
using MyAnimeWorld.Common.Main.BindingModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c27daff8857b2addfaffefa386ae6b3b2375683", @"/Views/Home/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59425f4569f9df14d12dfd947a78081273c19cb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 34, true);
            WriteLiteral("\r\n<h2 class=\"alert alert-success\">");
            EndContext();
            BeginContext(50, 10, false);
#line 3 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Views\Home\Success.cshtml"
                           Write(this.Model);

#line default
#line hidden
            EndContext();
            BeginContext(60, 56, true);
            WriteLiteral("</h2>\r\n\r\n<a href=\"/\" class=\"btn btn-info\">Go To Home</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
