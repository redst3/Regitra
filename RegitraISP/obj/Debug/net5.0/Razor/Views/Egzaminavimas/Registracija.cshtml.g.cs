#pragma checksum "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9de07e3d0b91dcb6b3b4e30407aa8dff63a7d119"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Egzaminavimas_Registracija), @"mvc.1.0.view", @"/Views/Egzaminavimas/Registracija.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\_ViewImports.cshtml"
using RegitraISP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\_ViewImports.cshtml"
using RegitraISP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\_ViewImports.cshtml"
using RegitraISP.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de07e3d0b91dcb6b3b4e30407aa8dff63a7d119", @"/Views/Egzaminavimas/Registracija.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2850022c157a4673b9966b72fab848d8fa9cb17f", @"/Views/_ViewImports.cshtml")]
    public class Views_Egzaminavimas_Registracija : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegitraISP.ViewModels.KlientasEgzaminas>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Egzaminavimas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registracija", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
  
    ViewData["Title"] = "Registracija";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""section"" class=""bodysection"">
    <div class=""container_white"">
        <section class=""tm-margin-b-l"">
            <h2 class=""pagetitle"">Regitros filialai</h2>
            <br />
            <p class=""page_infotext"">Šiame puslapyje yra pateikiama informacija apie Regitros filialus. Filialai yra suskirstyti pagal miestus, kuriuose juos galima rasti.</p>
            <br />
            <br />

            <p style=""text-align: center; font-size: larger"">Teorijos egzaminai</p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9de07e3d0b91dcb6b3b4e30407aa8dff63a7d1195287", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 929, "\"", 999, 1);
#nullable restore
#line 21 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
WriteAttributeValue("", 937, HttpContextAccessor.HttpContext.Session.GetString("username"), 937, 62, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                <table class=""table table-dark testtable"" style=""background-color: #4ca1af; box-shadow: 2px 4px 20px rgba(0, 0, 0, 0.8); "">
                    <tr>
                        <th>Data</th>
                        <th>Miestas</th>
                        <th>Gatvė</th>
                        <th>Nr.</th>
                        <th></th>
                    </tr>
");
#nullable restore
#line 30 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                     foreach (var egzaminas in Model.Egzaminai)
                    {
                        if (egzaminas.EgzaminoTipas == 1)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <th>");
#nullable restore
#line 35 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                   Write(Html.FixDateFormat(egzaminas.Data));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n");
#nullable restore
#line 36 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                     foreach (var filialas in Model.Filialai)
                    {
                        if (filialas.IdFilialas == egzaminas.FkFilialasidFilialas)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <th>");
#nullable restore
#line 40 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                           Write(Html.DisplayFor(modelItem => filialas.FkMiestaspavadinimas));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 41 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                           Write(Html.DisplayFor(modelItem => filialas.Gatve));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 42 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                           Write(Html.DisplayFor(modelItem => filialas.GatvesNr));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <th><button style=\"margin-left:0px;\" class=\"btn btn-dark\" type=\"submit\" name=\"egz\"");
                BeginWriteAttribute("value", " value=\"", 2232, "\"", 2292, 1);
#nullable restore
#line 43 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
WriteAttributeValue("", 2240, Html.DisplayFor(modelItem => egzaminas.IdEgzaminas), 2240, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Registruotis</button></th>\r\n");
#nullable restore
#line 44 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                            break;
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tr>\r\n");
#nullable restore
#line 48 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </table>


                <p style=""text-align: center; font-size: larger"">Praktikos egzaminai</p>
                <table class=""table table-hover table-dark"" style=""background-color: #4ca1af; box-shadow: 2px 4px 20px rgba(0, 0, 0, 0.8); "">
                    <tr>
                        <th>Data</th>
                        <th>Miestas</th>
                        <th>Gatvė</th>
                        <th>Nr.</th>
                        <th></th>
                    </tr>
");
#nullable restore
#line 63 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                     foreach (var egzaminas in Model.Egzaminai)
                    {
                        if (egzaminas.EgzaminoTipas == 2)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <th>");
#nullable restore
#line 68 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                               Write(Html.FixDateFormat(egzaminas.Data));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n");
#nullable restore
#line 69 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                 foreach (var filialas in Model.Filialai)
                                {
                                    if (filialas.IdFilialas == egzaminas.FkFilialasidFilialas)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <th>");
#nullable restore
#line 73 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                       Write(Html.DisplayFor(modelItem => filialas.FkMiestaspavadinimas));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 74 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                       Write(Html.DisplayFor(modelItem => filialas.Gatve));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 75 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                       Write(Html.DisplayFor(modelItem => filialas.GatvesNr));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                        <th><button style=\"margin-left:0px;\" class=\"btn btn-dark\" type=\"submit\" name=\"egz\"");
                BeginWriteAttribute("value", " value=\"", 3952, "\"", 4012, 1);
#nullable restore
#line 76 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
WriteAttributeValue("", 3960, Html.DisplayFor(modelItem => egzaminas.IdEgzaminas), 3960, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Registruotis</button></th>\r\n");
#nullable restore
#line 77 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                        break;
                                    }
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 81 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </table>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </section>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegitraISP.ViewModels.KlientasEgzaminas> Html { get; private set; }
    }
}
#pragma warning restore 1591
