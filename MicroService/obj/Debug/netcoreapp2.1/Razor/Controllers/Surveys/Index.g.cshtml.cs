#pragma checksum "C:\Users\45422\Desktop\si-microservice\MicroService\Controllers\Surveys\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58303980402c1f28f6954fcc97d64edc13f51f1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Controllers_Surveys_Index), @"mvc.1.0.razor-page", @"/Controllers/Surveys/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Controllers/Surveys/Index.cshtml", typeof(AspNetCore.Controllers_Surveys_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58303980402c1f28f6954fcc97d64edc13f51f1b", @"/Controllers/Surveys/Index.cshtml")]
    public class Controllers_Surveys_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\45422\Desktop\si-microservice\MicroService\Controllers\Surveys\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 187, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-page=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 20 "C:\Users\45422\Desktop\si-microservice\MicroService\Controllers\Surveys\Index.cshtml"
 foreach (var item in Model.SuveyModel) {

#line default
#line hidden
            BeginContext(332, 68, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                <a asp-page=\"./Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 400, "\"", 423, 1);
#line 23 "C:\Users\45422\Desktop\si-microservice\MicroService\Controllers\Surveys\Index.cshtml"
WriteAttributeValue("", 415, item.ID, 415, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(424, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-page=\"./Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 476, "\"", 499, 1);
#line 24 "C:\Users\45422\Desktop\si-microservice\MicroService\Controllers\Surveys\Index.cshtml"
WriteAttributeValue("", 491, item.ID, 491, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(500, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-page=\"./Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 554, "\"", 577, 1);
#line 25 "C:\Users\45422\Desktop\si-microservice\MicroService\Controllers\Surveys\Index.cshtml"
WriteAttributeValue("", 569, item.ID, 569, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(578, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 28 "C:\Users\45422\Desktop\si-microservice\MicroService\Controllers\Surveys\Index.cshtml"
}

#line default
#line hidden
            BeginContext(628, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MicroService.Controllers.Surveys.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MicroService.Controllers.Surveys.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MicroService.Controllers.Surveys.IndexModel>)PageContext?.ViewData;
        public MicroService.Controllers.Surveys.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
