#pragma checksum "D:\CS\PRO\BankPortalMVC\Views\Customer\WithdrawStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "268b94be90374c86dc5894203fa5969c97cc1e4b"
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
#line 1 "D:\CS\PRO\BankPortalMVC\Views\_ViewImports.cshtml"
using BankPortalMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CS\PRO\BankPortalMVC\Views\_ViewImports.cshtml"
using BankPortalMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"268b94be90374c86dc5894203fa5969c97cc1e4b", @"/Views/Customer/WithdrawStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"442c07933bad849bed620535accdeddfb6b93e90", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_WithdrawStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BankPortalMVC.Models.Depositwithdraw>
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
#nullable restore
#line 2 "D:\CS\PRO\BankPortalMVC\Views\Customer\WithdrawStatus.cshtml"
   
    ViewData["Title"] = "WithdrawStatus";
    //Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "268b94be90374c86dc5894203fa5969c97cc1e4b3851", async() => {
                WriteLiteral(@"
    <meta name='viewport' content='width=device-width, initial-scale=1'>
    <script src='https://kit.fontawesome.com/a076d05399.js'></script>
    <style>
        .body {
            text-align: center;
        }

        #tb {
            text-align: center;
        }

        #hd {
            text-align: right;
        }

        #unl {
            list-style-type: none;
            margin: 0;
            padding: 0;
            overflow: hidden;
            background-color: #333;
        }

        #list {
            float: left;
        }

        li a {
            display: block;
            color: white;
            text-align: center;
            padding: 14px 16px;
            text-decoration: none;
        }

        #ab {
            display: block;
            color: white;
            text-align: center;
            padding: 14px 16px;
            text-decoration: none;
        }

        li a:hover:not(.active) {
            background-color: #111;
        }

        .active {
            ba");
                WriteLiteral("ckground-color: #4CAF50;\n        }\n\n        #abc {\n            float: right;\n            color:white;\n        }\n    </style>\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "268b94be90374c86dc5894203fa5969c97cc1e4b6004", async() => {
                WriteLiteral(@"
    <!--<h1>Withdraw Status</h1>
    <div id=""hd""><a asp-action=""Index"">Go to Home Page</a></div>-->
    <header>
        <ul id=""unl"">
            <li id=""list""><span id=""ab"" class=""active"">Withdraw Status</span></li>
            <li id=""list""><span id=""abc"" onclick=""window.print()"">Print <i class='fas fa-print' style='font-size:30px;padding-top:12px;color:#b3f7ae'></i></span></li>
            <li id=""list"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "268b94be90374c86dc5894203fa5969c97cc1e4b6692", async() => {
                    WriteLiteral(" Home <i class=\'fas fa-home\' style=\'font-size:30px;color:#b3f7ae\'></i>");
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
                WriteLiteral("</li>\n        </ul>\n    </header>\n");
#nullable restore
#line 74 "D:\CS\PRO\BankPortalMVC\Views\Customer\WithdrawStatus.cshtml"
       if (Model.Message.Equals("Withdraw Successfull,but service charge will be deducted at the end of month since Balance is less than 1000") ||
                        Model.Message.Equals("Withdraw Successfull"))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <table>
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
#line 91 "D:\CS\PRO\BankPortalMVC\Views\Customer\WithdrawStatus.cshtml"
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
#line 99 "D:\CS\PRO\BankPortalMVC\Views\Customer\WithdrawStatus.cshtml"
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
#line 107 "D:\CS\PRO\BankPortalMVC\Views\Customer\WithdrawStatus.cshtml"
                               Write(Model.Balance);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </td>\n                            </tr>\n\n                        </table>\n");
#nullable restore
#line 112 "D:\CS\PRO\BankPortalMVC\Views\Customer\WithdrawStatus.cshtml"
        }
        else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h2>");
#nullable restore
#line 115 "D:\CS\PRO\BankPortalMVC\Views\Customer\WithdrawStatus.cshtml"
               Write(Model.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n");
#nullable restore
#line 116 "D:\CS\PRO\BankPortalMVC\Views\Customer\WithdrawStatus.cshtml"
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
