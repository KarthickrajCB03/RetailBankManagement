#pragma checksum "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\AccountStatementStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16ad05561cfb12e716a8c72692b7effae6172015"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_AccountStatementStatus), @"mvc.1.0.view", @"/Views/Customer/AccountStatementStatus.cshtml")]
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
#nullable restore
#line 1 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\_ViewImports.cshtml"
using BankPortalMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\_ViewImports.cshtml"
using BankPortalMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16ad05561cfb12e716a8c72692b7effae6172015", @"/Views/Customer/AccountStatementStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"442c07933bad849bed620535accdeddfb6b93e90", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_AccountStatementStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BankPortalMVC.Models.Statement>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\AccountStatementStatus.cshtml"
  
    ViewData["Title"] = "AccountStatementStatus";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16ad05561cfb12e716a8c72692b7effae61720154000", async() => {
                WriteLiteral("\n    <meta name=\'viewport\' content=\'width=device-width, initial-scale=1\'>\n    <script src=\'https://kit.fontawesome.com/a076d05399.js\'></script>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16ad05561cfb12e716a8c72692b7effae61720155113", async() => {
                WriteLiteral("\n    <h1>AccountStatementStatus</h1>\n    <span style=\"float:right\">\n        <i class=\'fas fa-print\' style=\'font-size:48px;color:red\' onclick=\"window.print()\"></i>\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16ad05561cfb12e716a8c72692b7effae61720155550", async() => {
                    WriteLiteral("<i class=\'fas fa-home\' style=\'font-size:48px;color:red\'></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    </span>\n    <table class=\"table\">\n        <thead>\n            <tr>\n                <th>\n                    ");
#nullable restore
#line 21 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\AccountStatementStatus.cshtml"
               Write(Html.DisplayNameFor(model => model.date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 24 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\AccountStatementStatus.cshtml"
               Write(Html.DisplayNameFor(model => model.Narration));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 27 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\AccountStatementStatus.cshtml"
               Write(Html.DisplayNameFor(model => model.refno));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 30 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\AccountStatementStatus.cshtml"
               Write(Html.DisplayNameFor(model => model.valueDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 33 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\AccountStatementStatus.cshtml"
               Write(Html.DisplayNameFor(model => model.withdrawal));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 36 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\AccountStatementStatus.cshtml"
               Write(Html.DisplayNameFor(model => model.deposit));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 39 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\AccountStatementStatus.cshtml"
               Write(Html.DisplayNameFor(model => model.closingBalance));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th></th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 45 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\AccountStatementStatus.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 49 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\AccountStatementStatus.cshtml"
                   Write(Html.DisplayFor(modelItem => item.date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 52 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\AccountStatementStatus.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Narration));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 55 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\AccountStatementStatus.cshtml"
                   Write(Html.DisplayFor(modelItem => item.refno));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 58 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\AccountStatementStatus.cshtml"
                   Write(Html.DisplayFor(modelItem => item.valueDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 61 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\AccountStatementStatus.cshtml"
                   Write(Html.DisplayFor(modelItem => item.withdrawal));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 64 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\AccountStatementStatus.cshtml"
                   Write(Html.DisplayFor(modelItem => item.deposit));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 67 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\AccountStatementStatus.cshtml"
                   Write(Html.DisplayFor(modelItem => item.closingBalance));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 70 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\AccountStatementStatus.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\n    </table>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BankPortalMVC.Models.Statement>> Html { get; private set; }
    }
}
#pragma warning restore 1591