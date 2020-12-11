#pragma checksum "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b605d022e7d9b6463910ff3805a8bb21d880bcdd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_List), @"mvc.1.0.view", @"/Views/Question/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b605d022e7d9b6463910ff3805a8bb21d880bcdd", @"/Views/Question/List.cshtml")]
    public class Views_Question_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Histocity_Website.Models.Question>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\List.cshtml"
  
    ViewBag.Title = "Question";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\List.cshtml"
 if (TempData["DeleteError"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-danger\" id=\"deleteError\">");
#nullable restore
#line 11 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\List.cshtml"
                                              Write(TempData["DeleteError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Vragen overzicht</h1>
<table class=""table"">
    <thead>
        <tr>
            <th>Gemaakt op:</th>
            <th>Tijdperk</th>
            <th>Vraag</th>
            <th>Goede antwoord</th>
            <th>Fout antwoord 1</th>
            <th>Foute antwoord 2</th>
            <th>Niveau</th>
            <th>Actief</th>
            <th></th>
        </tr>
    </thead>

");
#nullable restore
#line 30 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\List.cshtml"
     foreach (var question in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 33 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\List.cshtml"
   Write(Html.DisplayFor(questionItem => question.createdAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 34 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\List.cshtml"
   Write(Html.DisplayFor(questionItem => question.eraName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 35 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\List.cshtml"
   Write(Html.DisplayFor(questionItem => question.questionText));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 36 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\List.cshtml"
   Write(Html.DisplayFor(questionItem => question.goodAnswer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 37 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\List.cshtml"
   Write(Html.DisplayFor(questionItem => question.wrongAnswer1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 38 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\List.cshtml"
   Write(Html.DisplayFor(questionItem => question.wrongAnswer2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 39 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\List.cshtml"
   Write(Html.DisplayFor(questionItem => question.difficultyNames[question.difficulty]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 40 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\List.cshtml"
   Write(Html.DisplayFor(questionItem => question.activeInGame));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n    <td>");
#nullable restore
#line 42 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\List.cshtml"
   Write(Html.ActionLink("Verwijder", "Delete", new { id = question.questionID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 43 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\List.cshtml"
   Write(Html.ActionLink("Wijzigen", "Edit", new { id = question.questionID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n</tr>\r\n");
#nullable restore
#line 52 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\List.cshtml"
               

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n");
#nullable restore
#line 58 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\List.cshtml"
 if (TempData["Error"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-danger\" id=\"errorMessage\">");
#nullable restore
#line 60 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\List.cshtml"
                                               Write(TempData["Error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 61 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Question\List.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Histocity_Website.Models.Question>> Html { get; private set; }
    }
}
#pragma warning restore 1591
