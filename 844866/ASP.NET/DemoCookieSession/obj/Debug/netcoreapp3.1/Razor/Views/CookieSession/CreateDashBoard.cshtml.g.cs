#pragma checksum "D:\844866\ASP.NET\DemoCookieSession\Views\CookieSession\CreateDashBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e36b8309725a64e2b239232da5a66af67d7032ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CookieSession_CreateDashBoard), @"mvc.1.0.view", @"/Views/CookieSession/CreateDashBoard.cshtml")]
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
#line 1 "D:\844866\ASP.NET\DemoCookieSession\Views\_ViewImports.cshtml"
using DemoCookieSession;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\844866\ASP.NET\DemoCookieSession\Views\_ViewImports.cshtml"
using DemoCookieSession.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\844866\ASP.NET\DemoCookieSession\Views\CookieSession\CreateDashBoard.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e36b8309725a64e2b239232da5a66af67d7032ab", @"/Views/CookieSession/CreateDashBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6da779d40d03cd78214ff0f3593571c374092622", @"/Views/_ViewImports.cshtml")]
    public class Views_CookieSession_CreateDashBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CookieSession", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\844866\ASP.NET\DemoCookieSession\Views\CookieSession\CreateDashBoard.cshtml"
  
    ViewData["Title"] = "DashBoard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>DashBoard</h1><h4 class=\"text-right text-primary\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e36b8309725a64e2b239232da5a66af67d7032ab4179", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 8 "D:\844866\ASP.NET\DemoCookieSession\Views\CookieSession\CreateDashBoard.cshtml"
 if (Context.Session.GetString("UName") != null)
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4 class=\"text-right text-danger\">");
#nullable restore
#line 10 "D:\844866\ASP.NET\DemoCookieSession\Views\CookieSession\CreateDashBoard.cshtml"
                                  Write(Context.Session.GetString("UName").ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 11 "D:\844866\ASP.NET\DemoCookieSession\Views\CookieSession\CreateDashBoard.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4 class=\"text-right text-danger\">Your Last Logout ");
#nullable restore
#line 12 "D:\844866\ASP.NET\DemoCookieSession\Views\CookieSession\CreateDashBoard.cshtml"
                                               Write(ViewBag.lldt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
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