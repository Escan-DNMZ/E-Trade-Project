#pragma checksum "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Computer/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13e3261065dd95d41ece7301b9e72e9ebc87e633"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Computer_Index), @"mvc.1.0.view", @"/Views/Computer/Index.cshtml")]
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
#line 2 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Computer/Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Computer/Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13e3261065dd95d41ece7301b9e72e9ebc87e633", @"/Views/Computer/Index.cshtml")]
    public class Views_Computer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<ComputerShop.Data.Models.Computer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 6 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Computer/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2>Computer List</h2>
<br>
<table class=""table table-bordered"">
    <tr>
        <th>ID</th>
        <th>Computer Name</th>
        <th>Price</th>
        <th>Stock</th>
        <th>Category Name</th>
        <th>Delete</th>
        <th>Update</th>
        <th>Details</th> 
    </tr>
");
#nullable restore
#line 23 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Computer/Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <th>");
#nullable restore
#line 26 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Computer/Index.cshtml"
       Write(x.ComputerID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n        <td>");
#nullable restore
#line 27 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Computer/Index.cshtml"
       Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 28 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Computer/Index.cshtml"
       Write(x.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 29 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Computer/Index.cshtml"
       Write(x.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 30 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Computer/Index.cshtml"
       Write(x.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 681, "\"", 729, 2);
            WriteAttributeValue("", 688, "/Computer/ComputerDelete?id=", 688, 28, true);
#nullable restore
#line 31 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Computer/Index.cshtml"
WriteAttributeValue("", 716, x.ComputerID, 716, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 784, "\"", 829, 2);
            WriteAttributeValue("", 791, "/Computer/ComputerGet?id=", 791, 25, true);
#nullable restore
#line 32 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Computer/Index.cshtml"
WriteAttributeValue("", 816, x.ComputerID, 816, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\n        <td><a href=\"#\" class=\"btn btn-info\">Details</a></td>\n    </tr>        \n");
#nullable restore
#line 35 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Computer/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n");
#nullable restore
#line 37 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Computer/Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model,page=>Url.Action("Index",new {page})));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<a href=\"/Computer/ComputerAdd/\" class=\"btn btn-primary\">New Computer</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<ComputerShop.Data.Models.Computer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
