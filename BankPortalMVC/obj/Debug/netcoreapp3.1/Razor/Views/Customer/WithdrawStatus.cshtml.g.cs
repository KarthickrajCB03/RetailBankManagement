#pragma checksum "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\WithdrawStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6580d0675f1f83995aa7859950f5bdfac8cd37c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_WithdrawStatus), @"mvc.1.0.view", @"/Views/Customer/WithdrawStatus.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6580d0675f1f83995aa7859950f5bdfac8cd37c1", @"/Views/Customer/WithdrawStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"442c07933bad849bed620535accdeddfb6b93e90", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_WithdrawStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BankPortalMVC.Models.Depositwithdraw>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/WithdrawStatus.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\WithdrawStatus.cshtml"
   
    ViewData["Title"] = "WithdrawStatus";
    //Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6580d0675f1f83995aa7859950f5bdfac8cd37c14776", async() => {
                WriteLiteral("\n    <meta name=\'viewport\' content=\'width=device-width, initial-scale=1\'>\n    <script src=\'https://kit.fontawesome.com/a076d05399.js\'></script>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6580d0675f1f83995aa7859950f5bdfac8cd37c15187", async() => {
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
                WriteLiteral("\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6580d0675f1f83995aa7859950f5bdfac8cd37c17065", async() => {
                WriteLiteral(@"
    <!--<h1>Withdraw Status</h1>
    <div id=""hd""><a asp-action=""Index"">Go to Home Page</a></div>-->
    <header>
        <ul id=""unl"">
            <li id=""list""><span id=""ab"" class=""active"">Withdraw Status</span></li>
            <li id=""list""><span id=""abcd"" onclick=""window.print()""><i class='fas fa-print' style='font-size:48px;color:red'></i></span></li>
            <li id=""list"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6580d0675f1f83995aa7859950f5bdfac8cd37c17727", async() => {
                    WriteLiteral("<i class=\'fas fa-home\' style=\'font-size:48px;color:red\'></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\n        </ul>\n    </header>\n");
#nullable restore
#line 21 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\WithdrawStatus.cshtml"
       if (Model.Message.Equals("Withdraw Successfull,but service charge will be deducted at the end of month since Balance is less than 1000") ||
                        Model.Message.Equals("Withdraw Successfull"))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <table border=""1"">
                            <tr>
                                <th>
                                    Particulars
                                </th>
                                <th>
                                    Details
                                </th>
                            </tr>
                            <tr>
                                <td>
                                    Account ID
                                </td>
                                <td>
                                    ");
#nullable restore
#line 38 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\WithdrawStatus.cshtml"
                               Write(Model.AccountID);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Transaction Status
                                </td>
                                <td>
                                    ");
#nullable restore
#line 46 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\WithdrawStatus.cshtml"
                               Write(Model.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Account Balance After Withdrawal
                                </td>
                                <td>
                                    ");
#nullable restore
#line 54 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\WithdrawStatus.cshtml"
                               Write(Model.Balance);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </td>\n                            </tr>\n\n                        </table>\n");
#nullable restore
#line 59 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\WithdrawStatus.cshtml"
        }
        else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h2>");
#nullable restore
#line 62 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\WithdrawStatus.cshtml"
               Write(Model.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n");
#nullable restore
#line 63 "D:\CS\CTS\PROJECT\files\BankPortalMVC\Views\Customer\WithdrawStatus.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankPortalMVC.Models.Depositwithdraw> Html { get; private set; }
    }
}
#pragma warning restore 1591