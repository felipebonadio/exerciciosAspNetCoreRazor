#pragma checksum "C:\ProjetosWeb\Exercicios\Pages\Repeticao\Para\Exercicio1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9e436c5c561dcfc306da3cae79dac7b73c7e29a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjetosWeb.Pages.Repeticao.Para.Pages_Repeticao_Para_Exercicio1), @"mvc.1.0.razor-page", @"/Pages/Repeticao/Para/Exercicio1.cshtml")]
namespace ProjetosWeb.Pages.Repeticao.Para
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
#line 1 "C:\ProjetosWeb\Exercicios\Pages\_ViewImports.cshtml"
using ProjetosWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9e436c5c561dcfc306da3cae79dac7b73c7e29a", @"/Pages/Repeticao/Para/Exercicio1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76b38ec688d4e5a91b5efa7148a79715be6f70f7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Repeticao_Para_Exercicio1 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-4 offset-md-4 col-sm-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\ProjetosWeb\Exercicios\Pages\Repeticao\Para\Exercicio1.cshtml"
  
    ViewData["Title"] = "Tabuada";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center display-4"">Estrutura de Repeti????o - FOR</h1>
<h2 class=""text-center display-4"">Exerc??cio 1</h2>

<p class=""text-center"">
    Elabore um formul??rio que solicite ao usu??rio um n??mero e informe a tabuada correspondente.
    S??o permitidos valores entre 0 e 10.
</p>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9e436c5c561dcfc306da3cae79dac7b73c7e29a4236", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label for=\"Numero\">Informe um n??mero</label>\r\n        <input type=\"number\" class=\"form-control\" id=\"Numero\" name=\"Numero\" required>\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Calcular</button>\r\n");
#nullable restore
#line 21 "C:\ProjetosWeb\Exercicios\Pages\Repeticao\Para\Exercicio1.cshtml"
     if(ViewData["Tabuada"] != null){

#line default
#line hidden
#nullable disable
                WriteLiteral("        <table class=\"table table-striped my-3\">\r\n");
#nullable restore
#line 23 "C:\ProjetosWeb\Exercicios\Pages\Repeticao\Para\Exercicio1.cshtml"
             foreach (var linha in ViewBag.Tabuada)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 26 "C:\ProjetosWeb\Exercicios\Pages\Repeticao\Para\Exercicio1.cshtml"
                   Write(linha);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 28 "C:\ProjetosWeb\Exercicios\Pages\Repeticao\Para\Exercicio1.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n");
#nullable restore
#line 30 "C:\ProjetosWeb\Exercicios\Pages\Repeticao\Para\Exercicio1.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"//cdn.jsdelivr.net/npm/sweetalert2@11\"></script>\r\n    <script type=\"text/javascript\">\r\n    let erro = \'");
#nullable restore
#line 36 "C:\ProjetosWeb\Exercicios\Pages\Repeticao\Para\Exercicio1.cshtml"
           Write(Html.Raw(ViewData["Erro"]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n    if (erro != \'\'){\r\n        Swal.fire(\r\n            \'");
#nullable restore
#line 39 "C:\ProjetosWeb\Exercicios\Pages\Repeticao\Para\Exercicio1.cshtml"
        Write(Html.Raw(ViewData["Title"]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n            erro,\r\n            \'error\'\r\n        );\r\n    }\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exercicios.Pages.Repeticao.Para.Exercicio1Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Exercicios.Pages.Repeticao.Para.Exercicio1Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Exercicios.Pages.Repeticao.Para.Exercicio1Model>)PageContext?.ViewData;
        public Exercicios.Pages.Repeticao.Para.Exercicio1Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
