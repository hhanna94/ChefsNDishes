#pragma checksum "C:\Users\dream\Documents\Coding Dojo\C#\ChefsNDishes\Views\Dish\Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "572be72bc95ea232294c99a0afe3b735d4442c14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dish_Dishes), @"mvc.1.0.view", @"/Views/Dish/Dishes.cshtml")]
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
#line 1 "C:\Users\dream\Documents\Coding Dojo\C#\ChefsNDishes\Views\_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dream\Documents\Coding Dojo\C#\ChefsNDishes\Views\_ViewImports.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"572be72bc95ea232294c99a0afe3b735d4442c14", @"/Views/Dish/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Dish_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\dream\Documents\Coding Dojo\C#\ChefsNDishes\Views\Dish\Dishes.cshtml"
  
    ViewData["Title"] = "Dishes";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""d-flex justify-content-between align-items-center"">
    <h6>Yum, take a look at our tasty dishes!</h6>
    <a href=""/dishes/new"">Add a Dish</a>
</div>
<hr>
<table class=""table table-secondary table-striped"">
    <thead>
        <tr>
            <th>Name</th>
            <th># of Dishes</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Dummy</td>
            <td>Data</td>
            <td>Edit | Delete</td>
        </tr>
        <tr>
            <td>Dummy</td>
            <td>Data</td>
            <td>Edit | Delete</td>
        </tr>
        <tr>
            <td>Dummy</td>
            <td>Data</td>
            <td>Edit | Delete</td>
        </tr>
    </tbody>
</table>
");
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
