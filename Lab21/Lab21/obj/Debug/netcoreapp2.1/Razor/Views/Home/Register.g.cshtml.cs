#pragma checksum "/Users/samanthamazzola/Documents/Projects/Lab21/Lab21/Lab21/Views/Home/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6c2921fa262870bea2caa42b0c9df5d6329f7dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Register.cshtml", typeof(AspNetCore.Views_Home_Register))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6c2921fa262870bea2caa42b0c9df5d6329f7dd", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad79ed0e4f1e6fedc7595510007a398923d0a029", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 4 "/Users/samanthamazzola/Documents/Projects/Lab21/Lab21/Lab21/Views/Home/Register.cshtml"
  
    //ViewData["Title"] = "Register";
    ViewBag.Title = "Register";

#line default
#line hidden
            BeginContext(202, 115, true);
            WriteLiteral("<br /><br />\r\n<br /><br />\r\n<h2>Please fill out the form to register for a C# .NET bootcamp!</h2><br /><br />\r\n\r\n\r\n");
            EndContext();
            BeginContext(317, 1946, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b298e196cf646dabf59c6c516c6fad5", async() => {
                BeginContext(384, 1872, true);
                WriteLiteral(@"
    <div class=""form-group"">
        <label class=""control-label col-sm-2"" id=""FirstName"">First Name:</label>
        <div class=""col-sm-2"">
            <input type=""text"" class=""form-control"" name=""FirstName"" id=""FirstName"" placeholder=""John"" />
        </div>
    </div>
    <div class=""form-group"">
        <label class=""control-label col-sm-2"" id=""LastName"">Last Name:</label>
        <div class=""col-sm-7"">
            <input type=""text"" class=""form-control"" name=""LastName"" id=""LastName"" placeholder=""Doe"" />
        </div>
    </div>
    <div class=""form-group"">
        <label class=""control-label col-sm-2"" id=""Email"">Email:</label>
        <div class=""col-sm-7"">
            <input type=""email"" class=""form-control"" name=""Email"" id=""Email"" placeholder=""example@email.com"" />
        </div>
    </div>
    <div class=""form-group"">
        <label class=""control-label col-sm-2"" id=""PhoneNum"">Phone Number:</label>
        <div class=""col-sm-7"">
            <input type=""tel"" class=""form-contro");
                WriteLiteral(@"l"" name=""PhoneNum"" id=""PhoneNum"" placeholder=""000-000-0000"" />
        </div>
    </div>
    <div class=""form-group"">
        <label class=""control-label col-sm-2"" id=""Pwd"">Password:</label>
        <div class=""col-sm-7"">
            <input type=""password"" class=""form-control"" name=""Pwd"" id=""Pwd"" placeholder=""Enter password"" />
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
            <button onclick=""MyFunction()"" type=""submit"" class=""btn btn-default""><span class=""glyphicon glyphicon-user""></span> Register</button>
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
            BeginContext(2263, 2, true);
            WriteLiteral("\r\n");
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
