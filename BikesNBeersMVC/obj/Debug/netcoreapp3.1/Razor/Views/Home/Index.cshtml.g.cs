#pragma checksum "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eacd564ca79bd2f09f219ea856e445782cf57d8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/_ViewImports.cshtml"
using BikesNBeersMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/_ViewImports.cshtml"
using BikesNBeersMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eacd564ca79bd2f09f219ea856e445782cf57d8a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92587ac19b280abd565efb76b2722664cf0c0ae6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome</h1>\n    <h1>\n        Hotels List\n    </h1>\n    <br />\n");
#nullable restore
#line 13 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
     foreach (var response in Model.HotelResponses.results)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
   Write(response.name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
                      ;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\n");
#nullable restore
#line 17 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
   Write(response.rating);

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
                        ;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\n");
#nullable restore
#line 19 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>\n        Breweries List\n    </h1>\n    <br />\n");
#nullable restore
#line 24 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
     foreach (var response in Model.Breweries.Results)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
   Write(response.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
                      ;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\n");
#nullable restore
#line 29 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
   Write(response.Rating);

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
                        ;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\n");
#nullable restore
#line 31 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
      int a = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n");
#nullable restore
#line 34 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
     foreach (var leg in Model.Routes[0].legs)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <b>Starting Address: </b> ");
#nullable restore
#line 36 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
                            Write(leg.start_address);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n");
#nullable restore
#line 38 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
         foreach (var step in leg.steps)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\n                ");
#nullable restore
#line 41 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
           Write(Html.Raw(step.html_instructions));

#line default
#line hidden
#nullable disable
            WriteLiteral(" in \n                ");
#nullable restore
#line 42 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
           Write(Html.Raw(step.distance.text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 44 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <b>Destination: </b> ");
#nullable restore
#line 46 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
                        Write(leg.end_address);

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "/Users/Jennifer/repos/GrpFinalProj/BikesNBeers/BikesNBeersMVC/Views/Home/Index.cshtml"
                                             
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
