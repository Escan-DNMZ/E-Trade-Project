#pragma checksum "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Category/CategoryGet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "629256d5c8ac2c19d321453419cd6aec6aa2b9c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CategoryGet), @"mvc.1.0.view", @"/Views/Category/CategoryGet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"629256d5c8ac2c19d321453419cd6aec6aa2b9c5", @"/Views/Category/CategoryGet.cshtml")]
    public class Views_Category_CategoryGet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComputerShop.Data.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Category/CategoryGet.cshtml"
  
    ViewData["Title"] = "CategoryGet";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Category/CategoryGet.cshtml"
 using (Html.BeginForm("CategoryUpdate","Category",FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Category ID</h3>\n");
#nullable restore
#line 9 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Category/CategoryGet.cshtml"
Write(Html.TextBoxFor(x=>x.CategoryID, new {@class="form form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("     <br/>\n     <h3>Category Name</h3>\n");
#nullable restore
#line 12 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Category/CategoryGet.cshtml"
Write(Html.TextBoxFor(x=>x.CategoryName, new {@class="form form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Category/CategoryGet.cshtml"
Write(Html.ValidationMessageFor(x=>x.CategoryName,"",new {@style="color:red"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("     <br/>\n     <h3>Category Description</h3>\n");
#nullable restore
#line 16 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Category/CategoryGet.cshtml"
Write(Html.TextAreaFor(x=>x.CategoryDescription, new {@class="form form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("     <br/>\n     <button class=\"btn btn-success\">Update</button>\n");
#nullable restore
#line 19 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Category/CategoryGet.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComputerShop.Data.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
