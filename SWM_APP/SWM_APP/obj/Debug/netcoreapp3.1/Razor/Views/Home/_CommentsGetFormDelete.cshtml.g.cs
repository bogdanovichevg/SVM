#pragma checksum "C:\Users\Admin\source\repos\SWM_APP\SWM_APP\Views\Home\_CommentsGetFormDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34c6250fed3ea8ff3093919279713bc9c0935b1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__CommentsGetFormDelete), @"mvc.1.0.view", @"/Views/Home/_CommentsGetFormDelete.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Admin\source\repos\SWM_APP\SWM_APP\Views\Home\_CommentsGetFormDelete.cshtml"
using SWM_APP.Models.DdContext.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34c6250fed3ea8ff3093919279713bc9c0935b1c", @"/Views/Home/_CommentsGetFormDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b955701935d720026f66fe0862547d29b961714", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__CommentsGetFormDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WSREFCOMMENT>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Admin\source\repos\SWM_APP\SWM_APP\Views\Home\_CommentsGetFormDelete.cshtml"
 using (Html.BeginForm("CommentsDelete", "Home", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 165, "\"", 182, 1);
#nullable restore
#line 5 "C:\Users\Admin\source\repos\SWM_APP\SWM_APP\Views\Home\_CommentsGetFormDelete.cshtml"
WriteAttributeValue("", 173, Model.Id, 173, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:block\" />\r\n    <div>delete</div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34c6250fed3ea8ff3093919279713bc9c0935b1c4194", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 7 "C:\Users\Admin\source\repos\SWM_APP\SWM_APP\Views\Home\_CommentsGetFormDelete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Comtext);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <button type=\"submit\">delete</button>\r\n");
#nullable restore
#line 9 "C:\Users\Admin\source\repos\SWM_APP\SWM_APP\Views\Home\_CommentsGetFormDelete.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<button");
            BeginWriteAttribute("onclick", " onclick=\"", 360, "\"", 407, 3);
            WriteAttributeValue("", 370, "commentsWsrefGetForm(", 370, 21, true);
#nullable restore
#line 10 "C:\Users\Admin\source\repos\SWM_APP\SWM_APP\Views\Home\_CommentsGetFormDelete.cshtml"
WriteAttributeValue("", 391, Model.Wsref_id, 391, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 406, ")", 406, 1, true);
            EndWriteAttribute();
            WriteLiteral(">close</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WSREFCOMMENT> Html { get; private set; }
    }
}
#pragma warning restore 1591
