#pragma checksum "C:\Users\ebell\Desktop\C#Net\GrandCircusUniversity\GCUniversity\GCUniversity\Views\Home\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "401538906c48186df0016ae6391193055d389b3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Welcome), @"mvc.1.0.view", @"/Views/Home/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Welcome.cshtml", typeof(AspNetCore.Views_Home_Welcome))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"401538906c48186df0016ae6391193055d389b3f", @"/Views/Home/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2692a1c41a4dc2b86dab60690953907e99e60279", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Students>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ebell\Desktop\C#Net\GrandCircusUniversity\GCUniversity\GCUniversity\Views\Home\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
            BeginContext(60, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(65, 19, false);
#line 5 "C:\Users\ebell\Desktop\C#Net\GrandCircusUniversity\GCUniversity\GCUniversity\Views\Home\Welcome.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(84, 140, true);
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <p>Welcome to GCU WAAAASSSSSSSSSSUUUUPPPP!!!</p>\r\n    <p>To view available courses click here: </p>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(225, 58, false);
#line 11 "C:\Users\ebell\Desktop\C#Net\GrandCircusUniversity\GCUniversity\GCUniversity\Views\Home\Welcome.cshtml"
   Write(Html.ActionLink("ListOfCourses", "ListOfCourses", "Admin"));

#line default
#line hidden
            EndContext();
            BeginContext(283, 83, true);
            WriteLiteral("\r\n    </div>\r\n    p>To view available courses click here: </p>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(367, 45, false);
#line 15 "C:\Users\ebell\Desktop\C#Net\GrandCircusUniversity\GCUniversity\GCUniversity\Views\Home\Welcome.cshtml"
   Write(Html.ActionLink("Index", "Index", "Students"));

#line default
#line hidden
            EndContext();
            BeginContext(412, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Students> Html { get; private set; }
    }
}
#pragma warning restore 1591