#pragma checksum "C:\Users\eline\source\repos\Histocity-web-interface\Views\Student\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf458514f8e7fd4ada19dc31e5413cc91d53852e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Add), @"mvc.1.0.view", @"/Views/Student/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf458514f8e7fd4ada19dc31e5413cc91d53852e", @"/Views/Student/Add.cshtml")]
    public class Views_Student_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bf458514f8e7fd4ada19dc31e5413cc91d53852e4085", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <title>Account aanmaken</title>\r\n");
            WriteLiteral(@"
<div class=""card"" style=""margin:5% 20% 0 20%;"">
    <div class=""card-body"">
        <h1 class=""text-center"">Account aanmaken voor Histocity</h1>
        <form method=""POST"">

            <div class=""form-group"">
                <input class=""form-control"" type=""text"" id=""teacherID"" name=""teacherID""");
            BeginWriteAttribute("value", " value=\"", 484, "\"", 508, 1);
#nullable restore
#line 14 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Student\Add.cshtml"
WriteAttributeValue("", 492, ViewBag.Teacher, 492, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" hidden />
            </div>

            <div class=""form-group"">
                <input class=""form-control"" type=""text"" id=""firstName"" name=""firstName"" placeholder=""Voornaam"" required />
            </div>

            <div class=""form-group"">
                <input class=""form-control"" type=""text"" id=""lastName"" name=""lastName"" placeholder=""Achternaam"" required />
            </div>

            <div class=""form-group"">
                <input class=""form-control"" type=""text"" id=""userName"" name=""userName"" placeholder=""Gebruikersnaam voor het spel"" required />
            </div>

            <div class=""form-group"">
                <input class=""form-control"" type=""password"" id=""password"" name=""password"" placeholder=""Wachtwoord"" required />
            </div>
            <div class=""form-group"">
                <input class=""form-control"" type=""password"" id=""confirmPassword"" name=""confirmPassword"" placeholder=""Wachtwoord"" onkeyup=""checkConfirmPassword()"" required />
            </div>
 ");
            WriteLiteral(@"           <div class=""alert alert-danger"" id=""passwordError"" hidden>
                <span>Wachtwoorden zijn niet gelijk</span>
            </div>

            <div class=""form-group"">
                <input id=""submitUserButton"" class=""btn btn-dark"" type=""submit"" />
            </div>
        </form>
    </div>

");
#nullable restore
#line 45 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Student\Add.cshtml"
     if (ViewBag.ErrorMessage != "")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"text-danger\">     ");
#nullable restore
#line 47 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Student\Add.cshtml"
                               Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 48 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Student\Add.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Student\Add.cshtml"
     if (ViewBag.SuccessMessage != "")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"text-success\">     ");
#nullable restore
#line 51 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Student\Add.cshtml"
                                Write(ViewBag.SuccessMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 52 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Student\Add.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf458514f8e7fd4ada19dc31e5413cc91d53852e8869", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
