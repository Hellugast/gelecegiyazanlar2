#pragma checksum "C:\Users\turka\source\repos\Turkcell Gelecegi Yazanlar\Bootcamp\Web Applications\bootShop\bootShop.Web\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cf9159982e4b4d6fabcca50a0ab32c5c215271f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\turka\source\repos\Turkcell Gelecegi Yazanlar\Bootcamp\Web Applications\bootShop\bootShop.Web\Views\_ViewImports.cshtml"
using bootShop.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\turka\source\repos\Turkcell Gelecegi Yazanlar\Bootcamp\Web Applications\bootShop\bootShop.Web\Views\_ViewImports.cshtml"
using bootShop.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\turka\source\repos\Turkcell Gelecegi Yazanlar\Bootcamp\Web Applications\bootShop\bootShop.Web\Views\_ViewImports.cshtml"
using bootShop.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\turka\source\repos\Turkcell Gelecegi Yazanlar\Bootcamp\Web Applications\bootShop\bootShop.Web\Views\_ViewImports.cshtml"
using bootShop.Dtos.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\turka\source\repos\Turkcell Gelecegi Yazanlar\Bootcamp\Web Applications\bootShop\bootShop.Web\Views\_ViewImports.cshtml"
using bootShop.Dtos.Requests;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cf9159982e4b4d6fabcca50a0ab32c5c215271f", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30ebbe245eaeb3bbd436fb12b313dca43e079cac", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartCollection>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\turka\source\repos\Turkcell Gelecegi Yazanlar\Bootcamp\Web Applications\bootShop\bootShop.Web\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n");
#nullable restore
#line 7 "C:\Users\turka\source\repos\Turkcell Gelecegi Yazanlar\Bootcamp\Web Applications\bootShop\bootShop.Web\Views\Cart\Index.cshtml"
 if (Model.CartItems.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\">Sepetinizde ürün bulunmuyor </div>\r\n");
#nullable restore
#line 10 "C:\Users\turka\source\repos\Turkcell Gelecegi Yazanlar\Bootcamp\Web Applications\bootShop\bootShop.Web\Views\Cart\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>Ürün Adı</th>
                <th>Adet</th>
                <th>Ara Toplam</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "C:\Users\turka\source\repos\Turkcell Gelecegi Yazanlar\Bootcamp\Web Applications\bootShop\bootShop.Web\Views\Cart\Index.cshtml"
             foreach (var cart in Model.CartItems)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\turka\source\repos\Turkcell Gelecegi Yazanlar\Bootcamp\Web Applications\bootShop\bootShop.Web\Views\Cart\Index.cshtml"
                   Write(cart.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\turka\source\repos\Turkcell Gelecegi Yazanlar\Bootcamp\Web Applications\bootShop\bootShop.Web\Views\Cart\Index.cshtml"
                   Write(cart.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\turka\source\repos\Turkcell Gelecegi Yazanlar\Bootcamp\Web Applications\bootShop\bootShop.Web\Views\Cart\Index.cshtml"
                    Write(cart.Product.Price * (1 - cart.Product.Discount) * cart.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 31 "C:\Users\turka\source\repos\Turkcell Gelecegi Yazanlar\Bootcamp\Web Applications\bootShop\bootShop.Web\Views\Cart\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"4\">Toplam: ");
#nullable restore
#line 35 "C:\Users\turka\source\repos\Turkcell Gelecegi Yazanlar\Bootcamp\Web Applications\bootShop\bootShop.Web\Views\Cart\Index.cshtml"
                                   Write(Model.GetTotalPrice());

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
#nullable restore
#line 39 "C:\Users\turka\source\repos\Turkcell Gelecegi Yazanlar\Bootcamp\Web Applications\bootShop\bootShop.Web\Views\Cart\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartCollection> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
