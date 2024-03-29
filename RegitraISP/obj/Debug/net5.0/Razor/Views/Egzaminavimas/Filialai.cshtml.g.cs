#pragma checksum "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ee4ae4c9284eed13d8869012167f3c0f6e3588d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Egzaminavimas_Filialai), @"mvc.1.0.view", @"/Views/Egzaminavimas/Filialai.cshtml")]
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
#line 1 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\_ViewImports.cshtml"
using RegitraISP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\_ViewImports.cshtml"
using RegitraISP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\_ViewImports.cshtml"
using RegitraISP.Helper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ee4ae4c9284eed13d8869012167f3c0f6e3588d", @"/Views/Egzaminavimas/Filialai.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2850022c157a4673b9966b72fab848d8fa9cb17f", @"/Views/_ViewImports.cshtml")]
    public class Views_Egzaminavimas_Filialai : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegitraISP.ViewModels.FilialaiMiestai>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
  
    ViewData["Title"] = "Filialai";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""//use.fontawesome.com/releases/v5.0.7/css/all.css"">
<section id=""section"" class=""bodysection"">
    <div class=""container_white"">
        <section class=""tm-margin-b-l"">
            <h2 class=""pagetitle"">Regitros filialai</h2>
            <br />
            <p class=""page_infotext"">Šiame puslapyje yra pateikiama informacija apie Regitros filialus. Filialai yra suskirstyti pagal miestus, kuriuose juos galima rasti.</p>
            <br />
            <br />

");
#nullable restore
#line 17 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
             foreach (var miestas in Model.Miestai)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n                <p class=\"cityname\">\r\n                    <i class=\"fas fa-angle-right\"></i>&nbsp; ");
#nullable restore
#line 21 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                                                        Write(Html.DisplayFor(modelItem => miestas.Pavadinimas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p><br/>\r\n");
#nullable restore
#line 23 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                foreach (var filialas in Model.Filialai)
                {
                    if (filialas.FkMiestaspavadinimas == miestas.Pavadinimas)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"fproperty\" style=\"font-weight:bold\">Adresas: ");
#nullable restore
#line 28 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => filialas.Gatve));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                                                                                                                        Write(Html.DisplayFor(modelItem => filialas.GatvesNr));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"fproperty\">Galima laikyti:</p>\r\n                        <ul class=\"fproperty_ul\">\r\n");
#nullable restore
#line 31 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                             if (filialas.PraktikosEgz != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"fproperty_li\">Praktikos egzaminą: <b>Taip.</b></li>\r\n");
#nullable restore
#line 34 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"fproperty_li\">Praktikos egzaminą: <b>Ne.</b></li>\r\n");
#nullable restore
#line 38 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                             if (filialas.TeorijosEgz != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"fproperty_li\">Teorijos egzaminą: <b>Taip.</b></li>\r\n");
#nullable restore
#line 42 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"fproperty_li\">Teorijos egzaminą: <b>Ne.</b></li>\r\n");
#nullable restore
#line 46 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                        <br />\r\n");
#nullable restore
#line 49 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                    }
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </section>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegitraISP.ViewModels.FilialaiMiestai> Html { get; private set; }
    }
}
#pragma warning restore 1591
