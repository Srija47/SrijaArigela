#pragma checksum "D:\844866\ASP.NET\HandsOnMVCUsingModelValidations\Views\User\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dcff21535109508913b623901573f21eb83626a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Login), @"mvc.1.0.view", @"/Views/User/Login.cshtml")]
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
#line 1 "D:\844866\ASP.NET\HandsOnMVCUsingModelValidations\Views\_ViewImports.cshtml"
using HandsOnMVCUsingModelValidations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\844866\ASP.NET\HandsOnMVCUsingModelValidations\Views\_ViewImports.cshtml"
using HandsOnMVCUsingModelValidations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dcff21535109508913b623901573f21eb83626a", @"/Views/User/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f187be26d835ead1095788a16f8f0dc2759e01f6", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\844866\ASP.NET\HandsOnMVCUsingModelValidations\Views\User\Login.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Login</h1>\r\n");
#nullable restore
#line 8 "D:\844866\ASP.NET\HandsOnMVCUsingModelValidations\Views\User\Login.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <td>UserName</td>\r\n            <td>");
#nullable restore
#line 13 "D:\844866\ASP.NET\HandsOnMVCUsingModelValidations\Views\User\Login.cshtml"
           Write(Html.TextBox("uname"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n        <tr>\r\n            <td>Password</td>\r\n            <td>");
#nullable restore
#line 18 "D:\844866\ASP.NET\HandsOnMVCUsingModelValidations\Views\User\Login.cshtml"
           Write(Html.Password("pwd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\">\r\n                <input type=\"submit\" value=\"Login\" class=\"btn btn-primary\" />\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <span class=\"text-danger\">");
#nullable restore
#line 27 "D:\844866\ASP.NET\HandsOnMVCUsingModelValidations\Views\User\Login.cshtml"
                                     Write(ViewData["err"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 31 "D:\844866\ASP.NET\HandsOnMVCUsingModelValidations\Views\User\Login.cshtml"
}

#line default
#line hidden
#nullable disable
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