#pragma checksum "C:\Users\Admin\source\repos\SWM_APP\SWM_APP\Views\Home\_Filter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96dc4bff7a73e5839f0c33a0649266e9004cbd76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Filter), @"mvc.1.0.view", @"/Views/Home/_Filter.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\SWM_APP\SWM_APP\Views\_ViewImports.cshtml"
using SWM_APP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96dc4bff7a73e5839f0c33a0649266e9004cbd76", @"/Views/Home/_Filter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b955701935d720026f66fe0862547d29b961714", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Filter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div style=\"border:1px solid black;border-radius:2px;padding:5px;\">\r\n");
#nullable restore
#line 2 "C:\Users\Admin\source\repos\SWM_APP\SWM_APP\Views\Home\_Filter.cshtml"
     using (Html.BeginForm("Filter", "Home", FormMethod.Get))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"text\" name=\"name\" style=\"display:block\" />\r\n        <div style=\"display:inline-flex\">\r\n            <button type=\"submit\">OK</button>\r\n            <button type=\"reset\" onclick=\"clearDiv(\'#div1\')\">Cancel</button>\r\n        </div>\r\n");
#nullable restore
#line 9 "C:\Users\Admin\source\repos\SWM_APP\SWM_APP\Views\Home\_Filter.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
