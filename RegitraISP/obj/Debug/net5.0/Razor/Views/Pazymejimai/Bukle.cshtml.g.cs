#pragma checksum "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Pazymejimai\Bukle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1e680c4843b1636b75da01cff11de36b2da83fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pazymejimai_Bukle), @"mvc.1.0.view", @"/Views/Pazymejimai/Bukle.cshtml")]
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
#nullable restore
#line 2 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Pazymejimai\Bukle.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1e680c4843b1636b75da01cff11de36b2da83fa", @"/Views/Pazymejimai/Bukle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2850022c157a4673b9966b72fab848d8fa9cb17f", @"/Views/_ViewImports.cshtml")]
    public class Views_Pazymejimai_Bukle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegitraISP.Models.VairuotojoPazymejima>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 8 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Pazymejimai\Bukle.cshtml"
  
    ViewData["Title"] = "Bukle";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""//use.fontawesome.com/releases/v5.0.7/css/all.css"">
<section id=""section"" class=""bodysection"">
    <div class=""container_white"">
        <section class=""tm-margin-b-l"">
            <h2 class=""pagetitle"">Vairuotojo pažymėjimo būklė</h2>
            <br />
            <p class=""page_infotext"">Šiame puslapyje galite pasitikrinti pažymėjimo statusą.</p>
            <br />
            <br />
            <div style=""padding-left:150px"">
");
#nullable restore
#line 21 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Pazymejimai\Bukle.cshtml"
                 if (Model != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Pazymejimai\Bukle.cshtml"
                     if (Model.PazymejimoBukle == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"text-align: left; font-size: larger\">Jūsų vairuotojo pažymėjimo būklė: <strong>užsakytas</strong>.</p>\r\n");
#nullable restore
#line 26 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Pazymejimai\Bukle.cshtml"
                    }
                    else if (Model.PazymejimoBukle == 2)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"text-align: left; font-size: larger\">Jūsų vairuotojo pažymėjimo būklė: <strong>pagamintas</strong>.</p>\r\n");
#nullable restore
#line 30 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Pazymejimai\Bukle.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"text-align: left; font-size: larger\">Jūsų vairuotojo pažymėjimo būklė: <strong>pristatytas</strong>.</p>\r\n");
#nullable restore
#line 34 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Pazymejimai\Bukle.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Pazymejimai\Bukle.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p style=\"text-align: left; font-size: larger\">Vairuotojo pažymėjimo neturite.</p>\r\n");
#nullable restore
#line 39 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Pazymejimai\Bukle.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </section>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegitraISP.Models.VairuotojoPazymejima> Html { get; private set; }
    }
}
#pragma warning restore 1591
