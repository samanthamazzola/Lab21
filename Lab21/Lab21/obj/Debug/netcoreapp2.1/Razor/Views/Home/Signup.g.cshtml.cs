#pragma checksum "/Users/samanthamazzola/Documents/Projects/Lab21/Lab21/Lab21/Views/Home/Signup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "043dd894256be42f58a12d752b1e37f3dad1f060"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Signup), @"mvc.1.0.view", @"/Views/Home/Signup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Signup.cshtml", typeof(AspNetCore.Views_Home_Signup))]
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
#line 1 "/Users/samanthamazzola/Documents/Projects/Lab21/Lab21/Lab21/Views/_ViewImports.cshtml"
using Lab21;

#line default
#line hidden
#line 2 "/Users/samanthamazzola/Documents/Projects/Lab21/Lab21/Lab21/Views/_ViewImports.cshtml"
using Lab21.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"043dd894256be42f58a12d752b1e37f3dad1f060", @"/Views/Home/Signup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad79ed0e4f1e6fedc7595510007a398923d0a029", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Signup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/AddUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/samanthamazzola/Documents/Projects/Lab21/Lab21/Lab21/Views/Home/Signup.cshtml"
  
    //ViewData["Title"] = "Sign up";
    ViewBag.Title = "Sign up";


#line default
#line hidden
            BeginContext(202, 32, true);
            WriteLiteral("<br /><br />\r\n<br /><br />\r\n<h2>");
            EndContext();
            BeginContext(235, 13, false);
#line 11 "/Users/samanthamazzola/Documents/Projects/Lab21/Lab21/Lab21/Views/Home/Signup.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(248, 18, true);
            WriteLiteral("</h2>\r\n<br />\r\n<p>");
            EndContext();
            BeginContext(267, 21, false);
#line 13 "/Users/samanthamazzola/Documents/Projects/Lab21/Lab21/Lab21/Views/Home/Signup.cshtml"
Write(ViewBag.SignupMessage);

#line default
#line hidden
            EndContext();
            BeginContext(288, 20, true);
            WriteLiteral("</p>\r\n<br /><br />\r\n");
            EndContext();
            BeginContext(308, 1159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7189b36e6dfb4c36b40e4946c45ecd7f", async() => {
                BeginContext(375, 252, true);
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label class=\"control-label col-sm-2\" id=\"FirstName\">First Name:</label>\r\n        <div class=\"col-sm-7\">\r\n            <input type=\"text\" class=\"form-control\" name=\"FirstName\" id=\"FirstName\" placeholder=\"John\" /> ");
                EndContext();
                BeginContext(673, 787, true);
                WriteLiteral(@"
        </div>
    </div>
    <div class=""form-group"">
        <label class=""control-label col-sm-2"" id=""LastName"">Last Name:</label>
        <div class=""col-sm-7"">
            <input type=""text"" class=""form-control"" name=""LastName"" id=""LastName"" placeholder=""Doe"" />
        </div>
    </div>
    <div class=""form-group"">
        <div class=""col-sm-offset-2 col-sm-7"">
            <div class=""checkbox"">
                <label><input type=""checkbox""> Remember me</label>
            </div>
        </div>
    </div>
    <div class=""form-group"">
        <div class=""col-sm-offset-2 col-sm-7"">
            <button onclick=""MyFunction()"" type=""submit"" class=""btn btn-default""><span class=""glyphicon glyphicon-user""></span> Sign up!</button>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1467, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
