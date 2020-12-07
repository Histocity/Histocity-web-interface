#pragma checksum "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "592822c32378c5671828dc21f875fe37e2c35bed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_Create), @"mvc.1.0.view", @"/Views/Question/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"592822c32378c5671828dc21f875fe37e2c35bed", @"/Views/Question/Create.cshtml")]
    public class Views_Question_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/questions.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\Create.cshtml"
  
    ViewBag.Title = "Question";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "592822c32378c5671828dc21f875fe37e2c35bed3700", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "592822c32378c5671828dc21f875fe37e2c35bed3962", async() => {
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
                WriteLiteral(@"
    <link href=""https://cdn.jsdelivr.net/gh/gitbrent/bootstrap-switch-button@1.1.0/css/bootstrap-switch-button.min.css"" rel=""stylesheet"">
    <script src=""https://cdn.jsdelivr.net/gh/gitbrent/bootstrap-switch-button@1.1.0/dist/bootstrap-switch-button.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"card\">\r\n    <h2 class=\"card-title\">Vraag toevoegen</h2>\r\n    <form method=\"POST\">\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 18 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\Create.cshtml"
       Write(Html.DropDownList("eraID", new SelectList(ViewBag.Era, "Text", "Value"), "Kies een tijdperk", new { @class = "form-control custom-select", required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <select class=\"form-control custom-select\" name=\"difficulty\" required>\r\n                <option");
            BeginWriteAttribute("value", " value=\"", 900, "\"", 908, 0);
            EndWriteAttribute();
            WriteLiteral(@" selected>Kies een niveau</option>
                <option value=""1"">Makkelijk</option>
                <option value=""2"">Gemiddeld</option>
                <option value=""3"">Moeilijk</option>
            </select>
        </div>

        <div class=""form-group"">
            <input class=""form-control"" type=""text"" id=""questionText"" name=""questionText"" placeholder=""Vul de vraag hierin"" required />
        </div>

        <div class=""form-group"">
            <input class=""form-control"" type=""text"" id=""goodAnswerText"" name=""goodAnswerText"" placeholder=""Vul hier het goede antwoord in"" required/>
        </div>

        <div class=""form-group"">
            <input class=""form-control"" type=""text"" id=""badAnswerText1"" name=""badAnswerText1"" placeholder=""Vul hier een fout antwoord in"" required/>
        </div>

        <div class=""form-group"">
            <input class=""form-control"" type=""text"" id=""badAnswerText2"" name=""badAnswerText2"" placeholder=""Vul hier een fout antwoord in"" required/>
        ");
            WriteLiteral(@"</div>

        <label>Actief maken:</label>
        <div class=""form-group"">
            <div class=""custom-control custom-switch"">
                <input name=""questionActive"" type=""checkbox"" class=""custom-control-input"" id=""customSwitch1"" value=""true"">
                <label class=""custom-control-label"" for=""customSwitch1""></label>
            </div>
        </div>

        <div class=""form-group"">
            <input class=""btn btn-dark"" type=""submit"" />
        </div>
    </form>

");
#nullable restore
#line 59 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\Create.cshtml"
     if (TempData["Success"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"alert alert-success\" id=\"successMessage\">");
#nullable restore
#line 61 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\Create.cshtml"
                                                      Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 62 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\Create.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\Create.cshtml"
     if (TempData["Error"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"alert alert-danger\" id=\"errorMessage\">");
#nullable restore
#line 66 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\Create.cshtml"
                                                   Write(TempData["Error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 67 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\Create.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n");
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