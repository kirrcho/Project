#pragma checksum "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d9d69223836bcdc73172b366ffe322cfe8e6597"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyAnimeWorld.App.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_Profile), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Profile.cshtml", typeof(MyAnimeWorld.App.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_Profile), @"/account/profile/{username?}")]
namespace MyAnimeWorld.App.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\_ViewImports.cshtml"
using MyAnimeWorld.App.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\_ViewImports.cshtml"
using MyAnimeWorld.Models;

#line default
#line hidden
#line 4 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\_ViewImports.cshtml"
using MyAnimeWorld.Common.Users.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\_ViewImports.cshtml"
using MyAnimeWorld.Common.Utilities.Constants;

#line default
#line hidden
#line 1 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using MyAnimeWorld.App.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 2 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/account/profile/{username?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d9d69223836bcdc73172b366ffe322cfe8e6597", @"/Areas/Identity/Pages/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95ee12b034d54d0436725d6efe5d5133dc0b4eb6", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"997a5a081cc3793be743c9b4447d50873222a8f0", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Profile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "unbanUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Unban User"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 71, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div>\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 9 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\Account\Profile.cshtml"
             if (this.User.FindFirst(ClaimTypes.NameIdentifier).Value == this.Model.UserId)
            {

#line default
#line hidden
            BeginContext(245, 168, true);
            WriteLiteral("                <div>\r\n                    <a class=\"btn btn-success\" href=\"/identity/account/manage\">Edit Profile</a>\r\n                </div>\r\n                <br />\r\n");
            EndContext();
#line 15 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\Account\Profile.cshtml"
            }

#line default
#line hidden
            BeginContext(428, 42, true);
            WriteLiteral("            <div class=\"col-md-9\"></div>\r\n");
            EndContext();
#line 17 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\Account\Profile.cshtml"
             if (this.Model.IsAdmin && !this.Model.CurrentUserProfile)
            {

#line default
#line hidden
            BeginContext(557, 43, true);
            WriteLiteral("                <div>\r\n                    ");
            EndContext();
            BeginContext(600, 1748, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81e115acfadb445d826c367e54f58223", async() => {
                BeginContext(676, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 21 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\Account\Profile.cshtml"
                         if (!this.Model.IsBanned)
                        {

#line default
#line hidden
                BeginContext(757, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(785, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b23cb935aae741b1848f58637894e8ca", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 23 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\Account\Profile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => this.Model.Ban);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(841, 1248, true);
                WriteLiteral(@"
                            <input type=""button"" data-toggle=""modal"" data-target=""#myModal"" class=""btn btn-danger"" value=""BanUser"" />
                            <div class=""modal fade"" id=""myModal"" role=""dialog"">
                                <div class=""modal-dialog"">
                                    <div class=""modal-content danger"">
                                        <div class=""modal-header"">
                                            <h4 class=""modal-title"">Ban user</h4>
                                        </div>
                                        <div class=""modal-body"">
                                            <p class=""alert alert-danger"">Are you sure you want to ban this user?</p>
                                        </div>
                                        <div class=""modal-footer"">
                                            <button type=""submit"" class=""btn btn-danger"">Ban</button>
                                            <button type=""button"" class");
                WriteLiteral("=\"btn btn-default\" data-dismiss=\"modal\">Close</button>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
                EndContext();
#line 41 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\Account\Profile.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(2173, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(2201, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2df5515c1a3a4d1cbddbd5268105b902", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2292, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 45 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\Account\Profile.cshtml"
                        }

#line default
#line hidden
                BeginContext(2321, 20, true);
                WriteLiteral("                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            BeginWriteTagHelperAttribute();
            WriteLiteral("/account/profile/");
#line 20 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\Account\Profile.cshtml"
                                                              WriteLiteral(this.Model.Username);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Route = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Route, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2348, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 48 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\Account\Profile.cshtml"
            }

#line default
#line hidden
            BeginContext(2389, 164, true);
            WriteLiteral("        </div>\r\n        <div>\r\n            <div class=\"panel panel-info\">\r\n                <div class=\"panel-heading\">\r\n                    <h3 class=\"panel-title\">");
            EndContext();
            BeginContext(2554, 19, false);
#line 53 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\Account\Profile.cshtml"
                                       Write(this.Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(2573, 279, true);
            WriteLiteral(@"</h3>
                </div>
                <div class=""panel-body"">
                    <div class=""row"">
                        <div align=""center"" class=""col-md-1 col-sm-2 text-center pr-1"">
                            <img alt=""User Pic"" style=""width:75px;height:90px""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2852, "\"", 2879, 1);
#line 58 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\Account\Profile.cshtml"
WriteAttributeValue("", 2858, this.Model.AvatarUrl, 2858, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2880, 395, true);
            WriteLiteral(@" class=""mx-auto rounded-circle img-fluid"">
                        </div>

                        <div class="" col-md-9 col-lg-9 "">
                            <table class=""table table-user-information"">
                                <tbody>
                                    <tr>
                                        <td>Email:</td>
                                        <td>");
            EndContext();
            BeginContext(3276, 16, false);
#line 66 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\Account\Profile.cshtml"
                                       Write(this.Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3292, 198, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td>Created at:</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3491, 24, false);
#line 70 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\Account\Profile.cshtml"
                                       Write(this.Model.DateCreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(3515, 162, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n                                </tbody>\r\n                            </table>\r\n\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3677, "\"", 3724, 2);
            WriteAttributeValue("", 3684, "/account/favourites/", 3684, 20, true);
#line 75 "C:\Users\KIRO\source\repos\MyAnimeWorld\MyAnimeWorld.App\Areas\Identity\Pages\Account\Profile.cshtml"
WriteAttributeValue("", 3704, this.Model.Username, 3704, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3725, 181, true);
            WriteLiteral(" class=\"btn btn-primary\">Favourites</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProfileModel>)PageContext?.ViewData;
        public ProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
