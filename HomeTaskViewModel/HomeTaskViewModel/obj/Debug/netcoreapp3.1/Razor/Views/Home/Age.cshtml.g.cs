#pragma checksum "C:\Users\ASUS\OneDrive\Desktop\HomeTask (Routing && View )\HomeTaskViewModel\HomeTaskViewModel\Views\Home\Age.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f93b4d54e5b4203000e6d1400b683f760a5d1b89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Age), @"mvc.1.0.view", @"/Views/Home/Age.cshtml")]
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
#line 1 "C:\Users\ASUS\OneDrive\Desktop\HomeTask (Routing && View )\HomeTaskViewModel\HomeTaskViewModel\Views\_ViewImports.cshtml"
using HomeTaskViewModel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\OneDrive\Desktop\HomeTask (Routing && View )\HomeTaskViewModel\HomeTaskViewModel\Views\_ViewImports.cshtml"
using HomeTaskViewModel.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f93b4d54e5b4203000e6d1400b683f760a5d1b89", @"/Views/Home/Age.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2493f74e9a03bc9f08517f259f7eb2e6574faf9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Age : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASUS\OneDrive\Desktop\HomeTask (Routing && View )\HomeTaskViewModel\HomeTaskViewModel\Views\Home\Age.cshtml"
  
    ViewData["Title"] = "Age";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Name: ");
#nullable restore
#line 6 "C:\Users\ASUS\OneDrive\Desktop\HomeTask (Routing && View )\HomeTaskViewModel\HomeTaskViewModel\Views\Home\Age.cshtml"
     Write(ViewData["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>Surname: ");
#nullable restore
#line 7 "C:\Users\ASUS\OneDrive\Desktop\HomeTask (Routing && View )\HomeTaskViewModel\HomeTaskViewModel\Views\Home\Age.cshtml"
        Write(ViewBag.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>Age: ");
#nullable restore
#line 8 "C:\Users\ASUS\OneDrive\Desktop\HomeTask (Routing && View )\HomeTaskViewModel\HomeTaskViewModel\Views\Home\Age.cshtml"
    Write(TempData["Age"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n");
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
