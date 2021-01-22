#pragma checksum "C:\Users\eline\source\repos\Histocity-web-interface\Views\Instructions\Instructions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "463da3365c17dfa83d40f02207fda382279e58c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructions_Instructions), @"mvc.1.0.view", @"/Views/Instructions/Instructions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463da3365c17dfa83d40f02207fda382279e58c4", @"/Views/Instructions/Instructions.cshtml")]
    public class Views_Instructions_Instructions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\eline\source\repos\Histocity-web-interface\Views\Instructions\Instructions.cshtml"
  
    ViewBag.Title = "Instructies";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Instructies</h1>
<p>Welkom op de docenten website van Histocity<br />
    Lees onderstaande instructie over het spel goed door voordat je je leerlingen het spel laat spelen. </p>

<div id=""accordion"">
    <div class=""card"">
        <div class=""card-header"" id=""headingOne"">
            <h5 class=""mb-0"">
                <button class=""btn btn-link"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
                    De docenten website
                </button>
            </h5>
        </div>

        <div id=""collapseOne"" class=""collapse"" aria-labelledby=""headingOne"" data-parent=""#accordion"">
            <div class=""card-body"">
                Op deze website kunt u als docent de vragen beheren voor in het spel.
                Via de knop ""Vragen toevoegen"" kunt u nieuwe vragen toevoegen voor in het spel.
                Bij het aanmaken van een vraag kiest u een tijdperk, niveau, vraagomschrijving en drie antwoordmogelijkheden.
    ");
            WriteLiteral(@"            Ook kunt u aangeven of een vraag actief mag worden in het spel.
                Alleen actieve vragen worden in het spel gebruikt. Ook worden de vragen alleen gebruikt in het bijbehorende tijdperk.
                <br /><br />
                Ook kunt u via de knop ""Vragen overzicht"" alle vragen inzien. Via deze pagina kunt u ook een vraag wijzigen of verwijderen.
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header"" id=""headingTwo"">
                <h5 class=""mb-0"">
                    <button class=""btn btn-link collapsed"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
                        Een account aanmaken voor leerlingen
                    </button>
                </h5>
            </div>
            <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordion"">
                <div class=""card-body"">
                    Via de knop ""Leerlinge");
            WriteLiteral(@"n"" komt u op de overzichtspagina van alle leerlingen. Hier ziet u alle leerlingen
                    die een acccount hebben aangemaakt voor in het spel. De link bovenaan de pagina kunt u naar uw leerlingen versturen.
                    Met deze link kunnen zij een account aanmaken, waarmee ze kunnen inloggen in het spel.
                </div>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header"" id=""headingThree"">
                <h5 class=""mb-0"">
                    <button class=""btn btn-link collapsed"" data-toggle=""collapse"" data-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">
                        Doel van het spel
                    </button>
                </h5>
            </div>
            <div id=""collapseThree"" class=""collapse"" aria-labelledby=""headingThree"" data-parent=""#accordion"">
                <div class=""card-body"">
                    <i>
                        Alle kennis van het verleden is ");
            WriteLiteral(@"vernietigd en verdwenen op een mysterieuze wijze.
                        Jij bent een tijdreiziger geworden en moet er voor zorgen dat je alle kennis van het verleden weer terug vindt.
                        Je besluit om een museum op de te bouwen in MyHistocity van verschillende onderdelen uit verschillende tijdperken om de kennis weer terug te halen.
                    </i>
                    <br /><br />
                    HistoCity is bedoeld als ondersteunend materiaal in de geschiedenis les.
                    Het is bedoeld om oriëntatiekennis te blijven herhalen. De leerlingen kunnen in het spel rond lopen in verschillende tijdperken.
                    In deze tijdperken kunnen zij verschillende acties uitvoeren:
                    <br /><br />
                    <i>Vragen beantwoorden</i>
                    <br /><br />
                    In de levels staan verschillende personen geplaatst. Bij sommige van deze personen krijgt de leerling een vraag.
                    Als zi");
            WriteLiteral(@"j deze vraag goed beantwoorden krijgen zij 2 munten. Bij de fout beantwoorde vraag krijgen zij niets.
                    Bij elke fout antwoord gaat er een beetje vulling uit de energie weg. Als het energielevel (rechts boven in het scherm) rood is,
                    kan hij geen munten weer verdienen. De healthbar kan weer gevuld worden door het geven van goede antwoorden.
                    <br /><br />
                    <i>Weetjes lezen</i>
                    <br /><br />
                    In de levels staan ook verschillende personen die een weetje over het tijdperk tonen.
                    <br /><br />
                    <i>Items kopen</i>
                    <br /><br />
                    In de shop kunnen spelers items kopen, dit kunnen zij doen met de munten die zij hebben verdiend.
                    <br /><br />
                    <i>MyHistocity</i>
                    <br /><br />
                    Dit is het level waar de leerlingen zelf het museum op kunnen bouwen.");
            WriteLiteral(@" 
                    De items die zij hebben gekocht kunnen zij in dit level plaatsen en op deze manier hun eigen level opbouwen.
                    <br /><br />
            </div>
        </div>
        <div class=""card"">
        <div class=""card-header"" id=""headingFour"">
            <h5 class=""mb-0"">
                <button class=""btn btn-link collapsed"" data-toggle=""collapse"" data-target=""#collapseFour"" aria-expanded=""false"" aria-controls=""collapseFour"">
                    Bediening in het spel
                </button>
            </h5>
        </div>
        <div id=""collapseFour"" class=""collapse"" aria-labelledby=""headingFour"" data-parent=""#accordion"">
            <div class=""card-body"">
                Het spel wordt bediend met de toetsen van het toetsenbord:<br />
                W / Pijltje omhoog  = Naar voren lopen<br />
                A / Pijltje links   = Naar links lopen<br />
                S / Pijltje beneden = Naar achteren lopen<br />
                D / Pijltje recht");
            WriteLiteral("s  = Naar rechts lopen<br />\r\n                <br /><br />\r\n                P = Pauze menu<br />\r\n                I = Rugzak openen<br />\r\n                R = Objecten oppakken in MyHistoCity\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
