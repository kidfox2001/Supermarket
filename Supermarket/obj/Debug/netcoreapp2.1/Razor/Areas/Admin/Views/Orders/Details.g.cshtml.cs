#pragma checksum "D:\mvccore\Supermarket\Supermarket\Areas\Admin\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a787192d56db235cd120a0c66131f3680ac65bef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Orders_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Orders/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Orders/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Orders_Details))]
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
#line 3 "D:\mvccore\Supermarket\Supermarket\Areas\Admin\Views\_ViewImports.cshtml"
using Supermarket;

#line default
#line hidden
#line 4 "D:\mvccore\Supermarket\Supermarket\Areas\Admin\Views\_ViewImports.cshtml"
using Supermarket.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a787192d56db235cd120a0c66131f3680ac65bef", @"/Areas/Admin/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c1d4287fa2c13785bbc6bf023fc7baf9b8ec65", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Supermarket.Models.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\mvccore\Supermarket\Supermarket\Areas\Admin\Views\Orders\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(78, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Order</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(198, 40, false);
#line 14 "D:\mvccore\Supermarket\Supermarket\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(238, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(282, 36, false);
#line 17 "D:\mvccore\Supermarket\Supermarket\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(318, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(362, 42, false);
#line 20 "D:\mvccore\Supermarket\Supermarket\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(404, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(448, 38, false);
#line 23 "D:\mvccore\Supermarket\Supermarket\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(486, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(530, 41, false);
#line 26 "D:\mvccore\Supermarket\Supermarket\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(571, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(615, 37, false);
#line 29 "D:\mvccore\Supermarket\Supermarket\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(652, 403, true);
            WriteLiteral(@"
        </dd>
    </dl>
</div>

<h3>Line Items</h3>

<table class=""table"">
    <thead>
        <tr>
            <th style=""width:120px"">Name</th>
            <th style=""width:80px"" class=""text-right"">Price</th>
            <th style=""width:80px"" class=""text-right"">Quantity</th>
            <th style=""width:80px"" class=""text-right"">Total</th>
        </tr>
    </thead>

    <tbody>
");
            EndContext();
#line 47 "D:\mvccore\Supermarket\Supermarket\Areas\Admin\Views\Orders\Details.cshtml"
         foreach (var item in Model.LineItems)
        {

#line default
#line hidden
            BeginContext(1114, 58, true);
            WriteLiteral("            <tr>\r\n                <td style=\"width:120px\">");
            EndContext();
            BeginContext(1173, 17, false);
#line 50 "D:\mvccore\Supermarket\Supermarket\Areas\Admin\Views\Orders\Details.cshtml"
                                   Write(item.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1190, 65, true);
            WriteLiteral("</td>\r\n                <th style=\"width:80px\" class=\"text-right\">");
            EndContext();
            BeginContext(1256, 10, false);
#line 51 "D:\mvccore\Supermarket\Supermarket\Areas\Admin\Views\Orders\Details.cshtml"
                                                     Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1266, 65, true);
            WriteLiteral("</th>\r\n                <th style=\"width:80px\" class=\"text-right\">");
            EndContext();
            BeginContext(1332, 13, false);
#line 52 "D:\mvccore\Supermarket\Supermarket\Areas\Admin\Views\Orders\Details.cshtml"
                                                     Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1345, 65, true);
            WriteLiteral("</th>\r\n                <th style=\"width:80px\" class=\"text-right\">");
            EndContext();
            BeginContext(1411, 10, false);
#line 53 "D:\mvccore\Supermarket\Supermarket\Areas\Admin\Views\Orders\Details.cshtml"
                                                     Write(item.Total);

#line default
#line hidden
            EndContext();
            BeginContext(1421, 26, true);
            WriteLiteral("</th>\r\n            </tr>\r\n");
            EndContext();
#line 55 "D:\mvccore\Supermarket\Supermarket\Areas\Admin\Views\Orders\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1458, 267, true);
            WriteLiteral(@"    </tbody>

    <tfoot>
        <tr>
            <td style=""width:120px"">Total</td>
            <th style=""width:80px"" class=""text-right""></th>
            <th style=""width:80px"" class=""text-right""></th>
            <th style=""width:80px"" class=""text-right"">");
            EndContext();
            BeginContext(1726, 11, false);
#line 63 "D:\mvccore\Supermarket\Supermarket\Areas\Admin\Views\Orders\Details.cshtml"
                                                 Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(1737, 61, true);
            WriteLiteral("</th>\r\n        </tr>\r\n    </tfoot>\r\n\r\n</table>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1798, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e8daf43c4f344468ac3b6b238dc76ef", async() => {
                BeginContext(1844, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "D:\mvccore\Supermarket\Supermarket\Areas\Admin\Views\Orders\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1852, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1860, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "195640edc0c344d78e06d795b677e684", async() => {
                BeginContext(1882, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1898, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Supermarket.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
