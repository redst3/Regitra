#pragma checksum "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Demo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1430586f9f6e8e925e1ae323ce6152043dce90f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Egzaminavimas_Demo), @"mvc.1.0.view", @"/Views/Egzaminavimas/Demo.cshtml")]
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
#line 3 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Demo.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1430586f9f6e8e925e1ae323ce6152043dce90f", @"/Views/Egzaminavimas/Demo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2850022c157a4673b9966b72fab848d8fa9cb17f", @"/Views/_ViewImports.cshtml")]
    public class Views_Egzaminavimas_Demo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegitraISP.ViewModels.KlientasEgzaminas>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Egzaminavimas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Demo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mf"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Demo.cshtml"
  
    ViewData["Title"] = "Demo";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""section"" class=""bodysection"">
    <div class=""container_white"">
        <section class=""tm-margin-b-l"">
            <h2 class=""pagetitle"">Bandomasis teorijos egzaminas</h2>
            <br />
            <br />
            <p class=""page_infotext"">Šiame puslapyje galite pasitikrinti savo teorines KET žinias atliekant bandomąjį teorijos egzaminą. Testo rezultatai nėra fiksuojami, todėl jį atlikti galima neribotą kiekį kartų.</p>
            <br />
            <br />

            <p style=""text-align: center; font-size: larger""><strong>Testas</strong></p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1430586f9f6e8e925e1ae323ce6152043dce90f5636", async() => {
                WriteLiteral(@"
                <p style=""font-size: larger"">1. Ties kuriuo šviesoforo signalu galima kirsti sankryžą?</p>
                <p style=""font-size: larger""><input type=""radio"" name=""opt1"" value=""0"" /> Raudonu</p>
                <p style=""font-size: larger""><input type=""radio"" name=""opt1"" value=""0"" /> Geltonu</p>
                <p style=""font-size: larger""><input type=""radio"" id=""q1"" name=""opt1"" value=""1"" /> Žaliu</p>
                <p style=""font-size: larger""><input type=""radio"" name=""opt1"" value=""0"" /> Nesvarbu</p>
                <br />
                <br />
                <p style=""font-size: larger"">2. Ar būtina dėvėti saugos diržą vairuojant?</p>
                <p style=""font-size: larger""><input type=""radio"" id=""q2"" name=""opt2"" value=""1"" /> Taip</p>
                <p style=""font-size: larger""><input type=""radio"" name=""opt2"" value=""0"" /> Ne</p>
                <br />
                <br />
                <p style=""font-size: larger"">3. Kokiu greičiu gali važiuoti pradedantysis, neturin");
                WriteLiteral(@"tis 2 metų patirties, mieste?</p>
                <p style=""font-size: larger""><input type=""radio"" name=""opt3"" value=""0"" /> 40 km/h</p>
                <p style=""font-size: larger""><input type=""radio"" id=""q3"" name=""opt3"" value=""1"" /> 50 km/h</p>
                <p style=""font-size: larger""><input type=""radio"" name=""opt3"" value=""0"" /> 60 km/h</p>
                <p style=""font-size: larger""><input type=""radio"" name=""opt3"" value=""0"" /> 70 km/h</p>
                <br />
                <br />
                <p style=""font-size: larger"">4. Ar būtina pėsčiųjų perėjoje praleisti pėstyjį?</p>
                <p style=""font-size: larger""><input type=""radio"" name=""opt4"" value=""0"" /> Ne</p>
                <p style=""font-size: larger""><input type=""radio"" id=""q4"" name=""opt4"" value=""1"" /> Taip</p>
                <br />
                <br />
                <p style=""font-size: larger"">5. Kokiu greičiu gali važiuoti vairuotojas, turintis 2 metų patirtį, asfaltuotame kelyje?</p>
                <p style=""f");
                WriteLiteral(@"ont-size: larger""><input type=""radio"" id=""q5"" name=""opt5"" value=""1"" /> 90 km/h</p>
                <p style=""font-size: larger""><input type=""radio"" name=""opt5"" value=""0"" /> 100 km/h</p>
                <p style=""font-size: larger""><input type=""radio"" name=""opt5"" value=""0"" /> 80 km/h</p>
                <p style=""font-size: larger""><input type=""radio"" name=""opt5"" value=""0"" /> 110 km/h</p>
                <br />
                <br />
                <button id=""btn_end"" style=""margin-left:0px;"" class=""btn btn-primary"" type=""button""");
                BeginWriteAttribute("onclick", " onclick=\"", 3543, "\"", 3553, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"end\" value=\"1\">Baigti testą</button>\r\n            ");
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        </section>
    </div>
</section>
<script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>
<script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>
<script src=""sweetalert2.all.min.js""></script>
<script type=""text/javascript"">
    $(document).ready(function () {
        $(""#btn_end"").click(function () {
            var count = 0;
            if ($(""#q1"").is(':checked')) {
                count++;
            }
            if ($(""#q2"").is(':checked')) {
                count++;
            }
            if ($(""#q3"").is(':checked')) {
                count++;
            }
            if ($(""#q4"").is(':checked')) {
                count++;
            }
            if ($(""#q5"").is(':checked')) {
                count++;
            }
            Swal.fire({
                icon: 'info',
                title: 'Teisingai atsakėte į ' + count + '/5 klausimų.',
                confirmButtonText: 'Gerai'
                
            })
        });
    });
");
            WriteLiteral("</script>");
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
