#pragma checksum "D:\CS\PRO\BankPortalMVC\Views\Employee\CreationStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "144f890774e333ff16431f3228429ad99a2e26d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_CreationStatus), @"mvc.1.0.view", @"/Views/Employee/CreationStatus.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"144f890774e333ff16431f3228429ad99a2e26d8", @"/Views/Employee/CreationStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"442c07933bad849bed620535accdeddfb6b93e90", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_CreationStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BankPortalMVC.Models.CustomerCreationStatus>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\CS\PRO\BankPortalMVC\Views\Employee\CreationStatus.cshtml"
  
    ViewData["Title"] = "CreationStatus";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "144f890774e333ff16431f3228429ad99a2e26d85095", async() => {
                WriteLiteral("\n    <meta name=\'viewport\' content=\'width=device-width, initial-scale=1\'>\n    <script src=\'https://kit.fontawesome.com/a076d05399.js\'></script>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "144f890774e333ff16431f3228429ad99a2e26d85506", async() => {
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
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "144f890774e333ff16431f3228429ad99a2e26d86682", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <style>
        #hd {
            padding-left: 50px;
        }

        body {
            text-align: center
        }

        table {
            
            text-align: left;
            

        }
        td{
            padding:5px;
        }
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
        #list1 {
            float: left;
        }
        #list2 {
            float:left;
        }

        li a {
            display: block;
            color: white;
            text-align: center;
            padding: 14px 16px;
            text-decoration: none;
            float:left;
        }

        #ab {
       ");
                WriteLiteral(@"     display: block;
            color: white;
            text-align: center;
            padding: 18px 16px;
            text-decoration: none;
        }

        

        .active {
            background-color: #4CAF50;
        }

        #abcd {
            float: left;
            color: white;
        }
    </style>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "144f890774e333ff16431f3228429ad99a2e26d89960", async() => {
                WriteLiteral(@"
    <header>
        <ul id=""unl"">
            <li id=""list""><span id=""ab"" class=""active"">Customer Creation Status</span></li>
            <li id=""list2""><span id=""abcd"" onclick=""window.print()"">Print<i class='fas fa-print' style='font-size:30px;padding-top:12px;color:#b3f7ae'></i></span></li>
            <li id=""list3"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "144f890774e333ff16431f3228429ad99a2e26d810554", async() => {
                    WriteLiteral("Home<i class=\'fas fa-home\' style=\'font-size:30px;color:#b3f7ae\'></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\n        </ul>\n    </header>\n    <!--<h1>Customer Creation Status</h1>-->\n");
#nullable restore
#line 97 "D:\CS\PRO\BankPortalMVC\Views\Employee\CreationStatus.cshtml"
       if (Model.Message.Equals("Enter Valid Data for Customer Details"))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <h2>");
#nullable restore
#line 99 "D:\CS\PRO\BankPortalMVC\Views\Employee\CreationStatus.cshtml"
                       Write(Model.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\n");
#nullable restore
#line 100 "D:\CS\PRO\BankPortalMVC\Views\Employee\CreationStatus.cshtml"
                    }
                    else
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
                                    Customer ID
                                </td>
                                <td>
                                    ");
#nullable restore
#line 117 "D:\CS\PRO\BankPortalMVC\Views\Employee\CreationStatus.cshtml"
                               Write(Model.CustomerId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Customer Current Account ID
                                </td>
                                <td>
                                    ");
#nullable restore
#line 125 "D:\CS\PRO\BankPortalMVC\Views\Employee\CreationStatus.cshtml"
                               Write(Model.CurrentAccountId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Customer Savings Account ID
                                </td>
                                <td>
                                    ");
#nullable restore
#line 133 "D:\CS\PRO\BankPortalMVC\Views\Employee\CreationStatus.cshtml"
                               Write(Model.SavingsAccountId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Customer Account Creation Status
                                </td>
                                <td>
                                    ");
#nullable restore
#line 141 "D:\CS\PRO\BankPortalMVC\Views\Employee\CreationStatus.cshtml"
                               Write(Model.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </td>\n                            </tr>\n                        </table>\n");
#nullable restore
#line 145 "D:\CS\PRO\BankPortalMVC\Views\Employee\CreationStatus.cshtml"
                                    } 
        

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankPortalMVC.Models.CustomerCreationStatus> Html { get; private set; }
    }
}
#pragma warning restore 1591
