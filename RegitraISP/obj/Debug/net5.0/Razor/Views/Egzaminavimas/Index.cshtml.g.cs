#pragma checksum "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f01682f616e846ea3c1b8b969416dfc84433f0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Egzaminavimas_Index), @"mvc.1.0.view", @"/Views/Egzaminavimas/Index.cshtml")]
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
#line 2 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f01682f616e846ea3c1b8b969416dfc84433f0f", @"/Views/Egzaminavimas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2850022c157a4673b9966b72fab848d8fa9cb17f", @"/Views/_ViewImports.cshtml")]
    public class Views_Egzaminavimas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Index.cshtml"
  
    ViewData["Title"] = "Egzaminavimas";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--<link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Open+Sans:300,400"">-->  <!-- Google web font ""Open Sans"" -->
<!--<link rel=""stylesheet"" href=""font-awesome-4.7.0/css/font-awesome.min.css"">-->                <!-- Font Awesome -->
<!--<link rel=""stylesheet"" href=""css/bootstrap.min.css"">-->                                      <!-- Bootstrap style -->
");
            WriteLiteral(@"
<section id=""section"" class=""bodysection"">
    <div class=""tm-main-content"">
        <section class=""tm-margin-b-l"">
            <header>
                <h2 class=""pagetitle2"">Egzaminavimas</h2>
            </header>
            <br />
            <p class=""page_infotext"">Šioje paslaugų skiltyje rasite visą reikiamą informaciją bei teikiamas paslaugas susijusias su KET teorijos bei praktikos egzaminais ir egzaminavimu.</p>

            <div class=""tm-gallery"">
                <div class=""row"">
");
#nullable restore
#line 23 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Index.cshtml"
                     if (@HttpContextAccessor.HttpContext.Session.GetString("username") != null && @HttpContextAccessor.HttpContext.Session.GetInt32("isEmployee") == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <figure class=\"col-lg-3 col-md-3 col-sm-6 col-12 tm-gallery-item\">\r\n                            <a style=\"text-decoration:none\"");
            BeginWriteAttribute("href", " href=\"", 1465, "\"", 1516, 1);
#nullable restore
#line 26 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Index.cshtml"
WriteAttributeValue("", 1472, Url.Action("Registracija", "Egzaminavimas"), 1472, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""tm-gallery-item-overlay"">
                                    <img src=""img/10.jpg"" alt=""Image"" class=""img-fluid tm-img-center"">
                                </div>

                                <p class=""tm-figcaption"">Registracija egzaminui</p>
                            </a>
                        </figure>
                        <figure class=""col-lg-3 col-md-3 col-sm-6 col-12 tm-gallery-item"">
                            <a style=""text-decoration:none""");
            BeginWriteAttribute("href", " href=\"", 2042, "\"", 2091, 1);
#nullable restore
#line 35 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Index.cshtml"
WriteAttributeValue("", 2049, Url.Action("Apeliacija", "Egzaminavimas"), 2049, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""tm-gallery-item-overlay"">
                                    <img src=""img/4.jpg"" alt=""Image"" class=""img-fluid tm-img-center"">
                                </div>
                                <p class=""tm-figcaption"">Apeliacijos</p>
                            </a>
                        </figure>
");
#nullable restore
#line 42 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <figure class=\"col-lg-3 col-md-3 col-sm-6 col-12 tm-gallery-item\">\r\n                        <a style=\"text-decoration:none\"");
            BeginWriteAttribute("href", " href=\"", 2618, "\"", 2665, 1);
#nullable restore
#line 44 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Index.cshtml"
WriteAttributeValue("", 2625, Url.Action("Filialai", "Egzaminavimas"), 2625, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""tm-gallery-item-overlay"">
                                <img src=""img/11.jpg"" alt=""Image"" class=""img-fluid tm-img-center"">
                            </div>
                            <p class=""tm-figcaption"">Filialai</p>
                        </a>
                    </figure>
                    <figure class=""col-lg-3 col-md-3 col-sm-6 col-12 tm-gallery-item"">
                        <a style=""text-decoration:none""");
            BeginWriteAttribute("href", " href=\"", 3143, "\"", 3186, 1);
#nullable restore
#line 52 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Index.cshtml"
WriteAttributeValue("", 3150, Url.Action("Demo", "Egzaminavimas"), 3150, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""tm-gallery-item-overlay"">
                                <img src=""img/7.jpg"" alt=""Image"" class=""img-fluid tm-img-center"">
                            </div>
                            <p class=""tm-figcaption"">Demo teorijos egzaminas</p>
                        </a>
                    </figure>

                </div>
            </div>
        </section>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
