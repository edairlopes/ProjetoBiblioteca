#pragma checksum "G:\Meu Drive\PC Pessoal\Docs2021\Curso_tecnico_Senac\UC07\Biblioteca\Views\Livro\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1daab0e7ed910ee9eb1138c589d2d60981d17eee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Livro_Listagem), @"mvc.1.0.view", @"/Views/Livro/Listagem.cshtml")]
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
#line 1 "G:\Meu Drive\PC Pessoal\Docs2021\Curso_tecnico_Senac\UC07\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Meu Drive\PC Pessoal\Docs2021\Curso_tecnico_Senac\UC07\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1daab0e7ed910ee9eb1138c589d2d60981d17eee", @"/Views/Livro/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac979cfa6f9c2014e1ebeda333546c494974b6fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Livro_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Livro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Autor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Titulo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "15", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "30", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\Meu Drive\PC Pessoal\Docs2021\Curso_tecnico_Senac\UC07\Biblioteca\Views\Livro\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Livros";
    int FiltroPorPag = Int32.Parse(ViewData["livrosPorPagina"].ToString());
    int PaginaAtual =  Int32.Parse(ViewData["PaginaAtual"].ToString());
    int NumLivrosPorPag = (Model.Count<FiltroPorPag ? Model.Count : FiltroPorPag);
    int NumTotalDePag = Model.Count/NumLivrosPorPag + (Model.Count%NumLivrosPorPag==0 ? 0 : 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-md-12\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1daab0e7ed910ee9eb1138c589d2d60981d17eee6422", async() => {
                WriteLiteral("\n        <div class=\"form-group mb-2\">\n            <select name=\"TipoFiltro\" class=\"form-control\">\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1daab0e7ed910ee9eb1138c589d2d60981d17eee6800", async() => {
                    WriteLiteral("Autor");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1daab0e7ed910ee9eb1138c589d2d60981d17eee8036", async() => {
                    WriteLiteral("Título");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </select>
        </div>

        <div class=""form-group mb-2 mx-sm-3"">
            <input type=""text"" placeholder=""Filtro"" name=""Filtro"" class=""form-control""/>
        </div>

        <div class=""form-group mb-2"">
            <select name=""itensPorPagina"" id=""itensPorPagina"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1daab0e7ed910ee9eb1138c589d2d60981d17eee9579", async() => {
                    WriteLiteral("10 livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1daab0e7ed910ee9eb1138c589d2d60981d17eee10819", async() => {
                    WriteLiteral("15 livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1daab0e7ed910ee9eb1138c589d2d60981d17eee12060", async() => {
                    WriteLiteral("30 livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1daab0e7ed910ee9eb1138c589d2d60981d17eee13301", async() => {
                    WriteLiteral("50 livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1daab0e7ed910ee9eb1138c589d2d60981d17eee14542", async() => {
                    WriteLiteral("Todos");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "G:\Meu Drive\PC Pessoal\Docs2021\Curso_tecnico_Senac\UC07\Biblioteca\Views\Livro\Listagem.cshtml"
                  WriteLiteral(Model.Count);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            </select>\n        </div>\n\n        <button type=\"submit\" class=\"btn btn-primary mb-2 mx-2\">Pesquisar</button>\n\n        <div id=\"SeletorPaginas\" class=\"pagination mb-2 mx-2\">\n            <span class=\"page-link disabled\">Página:</span>\n");
#nullable restore
#line 37 "G:\Meu Drive\PC Pessoal\Docs2021\Curso_tecnico_Senac\UC07\Biblioteca\Views\Livro\Listagem.cshtml"
             for(int i=1; i<=NumTotalDePag;i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <span class=\"page-item\"><a");
                BeginWriteAttribute("href", " href=\"", 1607, "\"", 1644, 2);
                WriteAttributeValue("", 1614, "/Livro/Listagem?PaginaAtual=", 1614, 28, true);
#nullable restore
#line 39 "G:\Meu Drive\PC Pessoal\Docs2021\Curso_tecnico_Senac\UC07\Biblioteca\Views\Livro\Listagem.cshtml"
WriteAttributeValue("", 1642, i, 1642, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"page-link\">");
#nullable restore
#line 39 "G:\Meu Drive\PC Pessoal\Docs2021\Curso_tecnico_Senac\UC07\Biblioteca\Views\Livro\Listagem.cshtml"
                                                                                              Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </a></span>\n");
#nullable restore
#line 40 "G:\Meu Drive\PC Pessoal\Docs2021\Curso_tecnico_Senac\UC07\Biblioteca\Views\Livro\Listagem.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n\n<div class=\"row\">\n    <div class=\"col-md-12\">\n");
#nullable restore
#line 48 "G:\Meu Drive\PC Pessoal\Docs2021\Curso_tecnico_Senac\UC07\Biblioteca\Views\Livro\Listagem.cshtml"
         if(Model.Count!=0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-striped""> 
            <thead>
                <tr><th>Id</th>
                <th>Titulo</th>
                <th>Autor</th>
                <th>Ano</th>
                <th></th>
                </tr>
            </thead>
            
            <tbody>
");
#nullable restore
#line 61 "G:\Meu Drive\PC Pessoal\Docs2021\Curso_tecnico_Senac\UC07\Biblioteca\Views\Livro\Listagem.cshtml"
                 for(int i = (PaginaAtual-1)*NumLivrosPorPag; i<(NumLivrosPorPag*PaginaAtual<Model.Count?NumLivrosPorPag*PaginaAtual:Model.Count); i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 64 "G:\Meu Drive\PC Pessoal\Docs2021\Curso_tecnico_Senac\UC07\Biblioteca\Views\Livro\Listagem.cshtml"
                   Write(Model[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 65 "G:\Meu Drive\PC Pessoal\Docs2021\Curso_tecnico_Senac\UC07\Biblioteca\Views\Livro\Listagem.cshtml"
                   Write(Model[i].Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 66 "G:\Meu Drive\PC Pessoal\Docs2021\Curso_tecnico_Senac\UC07\Biblioteca\Views\Livro\Listagem.cshtml"
                   Write(Model[i].Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 67 "G:\Meu Drive\PC Pessoal\Docs2021\Curso_tecnico_Senac\UC07\Biblioteca\Views\Livro\Listagem.cshtml"
                   Write(Model[i].Ano);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 2507, "\"", 2540, 2);
            WriteAttributeValue("", 2514, "/Livro/Edicao/", 2514, 14, true);
#nullable restore
#line 68 "G:\Meu Drive\PC Pessoal\Docs2021\Curso_tecnico_Senac\UC07\Biblioteca\Views\Livro\Listagem.cshtml"
WriteAttributeValue("", 2528, Model[i].Id, 2528, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\n                </tr>\n");
#nullable restore
#line 70 "G:\Meu Drive\PC Pessoal\Docs2021\Curso_tecnico_Senac\UC07\Biblioteca\Views\Livro\Listagem.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n");
#nullable restore
#line 73 "G:\Meu Drive\PC Pessoal\Docs2021\Curso_tecnico_Senac\UC07\Biblioteca\Views\Livro\Listagem.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>Nenhum registro encontrado</h2>\n");
#nullable restore
#line 77 "G:\Meu Drive\PC Pessoal\Docs2021\Curso_tecnico_Senac\UC07\Biblioteca\Views\Livro\Listagem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Livro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
