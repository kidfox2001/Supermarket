#pragma checksum "D:\mvccore\Supermarket\Supermarket\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1261ecdc4d111a4732888e715038dd1ecb4bd2a1"
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
#line 3 "D:\mvccore\Supermarket\Supermarket\Views\_ViewImports.cshtml"
using Supermarket;

#line default
#line hidden
#line 4 "D:\mvccore\Supermarket\Supermarket\Views\_ViewImports.cshtml"
using Supermarket.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1261ecdc4d111a4732888e715038dd1ecb4bd2a1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c1d4287fa2c13785bbc6bf023fc7baf9b8ec65", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 34, true);
            WriteLiteral("<h2>Home</h2>\r\n\r\n<div>Log Level : ");
            EndContext();
            BeginContext(35, 16, false);
#line 3 "D:\mvccore\Supermarket\Supermarket\Views\Home\Index.cshtml"
            Write(ViewBag.LogLevel);

#line default
#line hidden
            EndContext();
            BeginContext(51, 21, true);
            WriteLiteral("</div>\r\n<div>TOKEN : ");
            EndContext();
            BeginContext(73, 15, false);
#line 4 "D:\mvccore\Supermarket\Supermarket\Views\Home\Index.cshtml"
        Write(ViewBag.MyToken);

#line default
#line hidden
            EndContext();
            BeginContext(88, 22, true);
            WriteLiteral("</div>\r\n<div>TOKEN3 : ");
            EndContext();
            BeginContext(111, 16, false);
#line 5 "D:\mvccore\Supermarket\Supermarket\Views\Home\Index.cshtml"
         Write(ViewBag.MyToken3);

#line default
#line hidden
            EndContext();
            BeginContext(127, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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