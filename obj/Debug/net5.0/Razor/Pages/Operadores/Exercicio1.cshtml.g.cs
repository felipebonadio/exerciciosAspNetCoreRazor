#pragma checksum "C:\ProjetosWeb\Exercicios\Pages\Operadores\Exercicio1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38b6231b4765030541a44662ae70c6c5a4c946dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjetosWeb.Pages.Operadores.Pages_Operadores_Exercicio1), @"mvc.1.0.razor-page", @"/Pages/Operadores/Exercicio1.cshtml")]
namespace ProjetosWeb.Pages.Operadores
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b6231b4765030541a44662ae70c6c5a4c946dd", @"/Pages/Operadores/Exercicio1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76b38ec688d4e5a91b5efa7148a79715be6f70f7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Operadores_Exercicio1 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\ProjetosWeb\Exercicios\Pages\Operadores\Exercicio1.cshtml"
  
    ViewData["Title"] = "Op. Mat. - Ex.01";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center display-4"">Operadores Matemáticos</h1>
<h2 class=""text-center display-4"">Exercício 1</h2>
<p>
    Construa um algoritmo que leia o nome e três notas obtidas durante o semestre, ao final mostre o nome do aluno e a média artmética das notas.
</p>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38b6231b4765030541a44662ae70c6c5a4c946dd3819", async() => {
                WriteLiteral(@"
    <div class=""form-group"">
        <label for=""Nome"">Nome</label>
        <input type=""text"" class=""form-control"" id=""Nome"" name=""Nome"" placeholder=""Informe o nome do aluno"" required>
    </div>
    <div class=""form-group"">
        <label for=""Nota1"">Nota 1</label>
        <input type=""text"" class=""form-control"" id=""Nota1"" name=""Nota1"" placeholder=""Informe a nota 1"">
    </div>
    <div class=""form-group"">
        <label for=""Nota2"">Nota 2</label>
        <input type=""text"" class=""form-control"" id=""Nota2"" name=""Nota2"" placeholder=""Informe a nota 2"">
    </div>
    <div class=""form-group"">
        <label for=""Nota3"">Nota 3</label>
        <input type=""text"" class=""form-control"" id=""Nota3"" name=""Nota3"" placeholder=""Informe a nota 3"">
    </div>
    <button type=""submit"" class=""btn btn-primary"">Calcular</button>
    <p class=""mt-3 text-center"">");
#nullable restore
#line 30 "C:\ProjetosWeb\Exercicios\Pages\Operadores\Exercicio1.cshtml"
                           Write(ViewData["Resultado"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exercicios.Pages.Operadores.Exercicio1Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Exercicios.Pages.Operadores.Exercicio1Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Exercicios.Pages.Operadores.Exercicio1Model>)PageContext?.ViewData;
        public Exercicios.Pages.Operadores.Exercicio1Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
