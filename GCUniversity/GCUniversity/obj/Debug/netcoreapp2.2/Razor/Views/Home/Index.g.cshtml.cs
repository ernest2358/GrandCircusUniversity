#pragma checksum "C:\Users\ebell\Desktop\C#Net\GrandCircusUniversity\GCUniversity\GCUniversity\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb64020296226b0bb8b354912fe2ffd8f8080507"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\ebell\Desktop\C#Net\GrandCircusUniversity\GCUniversity\GCUniversity\Views\_ViewImports.cshtml"
using GCUniversity;

#line default
#line hidden
#line 2 "C:\Users\ebell\Desktop\C#Net\GrandCircusUniversity\GCUniversity\GCUniversity\Views\_ViewImports.cshtml"
using GCUniversity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb64020296226b0bb8b354912fe2ffd8f8080507", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2692a1c41a4dc2b86dab60690953907e99e60279", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ebell\Desktop\C#Net\GrandCircusUniversity\GCUniversity\GCUniversity\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 94, true);
            WriteLiteral("<p>Welcome to GCU WAAAASSSSSSSSSSUUUUPPPP!!!</p>\r\n<p>Please Register or Login</p>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(140, 47, false);
#line 7 "C:\Users\ebell\Desktop\C#Net\GrandCircusUniversity\GCUniversity\GCUniversity\Views\Home\Index.cshtml"
Write(Html.ActionLink("Register", "Register", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(187, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(209, 41, false);
#line 10 "C:\Users\ebell\Desktop\C#Net\GrandCircusUniversity\GCUniversity\GCUniversity\Views\Home\Index.cshtml"
Write(Html.ActionLink("Login", "Login", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(250, 18, true);
            WriteLiteral("\r\n</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
