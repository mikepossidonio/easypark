#pragma checksum "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dabdd34f5304c2965d0f4c8846aebcb8b42f88b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_VerServico), @"mvc.1.0.view", @"/Views/Cliente/VerServico.cshtml")]
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
#line 1 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\_ViewImports.cshtml"
using EasyPark;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\_ViewImports.cshtml"
using EasyPark.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\_ViewImports.cshtml"
using EasyPark.EasyPark.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dabdd34f5304c2965d0f4c8846aebcb8b42f88b0", @"/Views/Cliente/VerServico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39a2c0adaec0edc41b124dad455a9936b5647723", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_VerServico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyPark.EasyPark.Domain.Responses.VitrineServicos>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
  
    ViewData["Title"] = "Serviços geral";
    Layout = "~/Views/Shared/_LayoutCliente.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h2>Serviços disponíveis</h2>\r\n        <p class=\"text-justify\">Aqui você terá acesso a todos os serviços cadastrados no sistema. <br />Confira a listagem dos serviços prestados abaixo. </p>\r\n");
#nullable restore
#line 12 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
 if (Model.VitrineEstacionamento.Count() == 0 & Model.VitrinePrestadoresServicos.Count == 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"text-justify\">\r\n        Ops! ainda não há serviços cadastrados por aqui.<br />\r\n        Continue sempre consultando pois estamos em constante atualização!\r\n    </p>\r\n");
#nullable restore
#line 19 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 21 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
 if (Model.VitrinePrestadoresServicos.Count() != 0)
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
     foreach (var servico in Model.VitrinePrestadoresServicos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <h2>");
#nullable restore
#line 27 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
       Write(servico.NomePrestador);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <p class=\"text-justify\">Nome do serviço prestado: ");
#nullable restore
#line 28 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
                                                     Write(servico.NomeServico);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n        <p class=\"text-justify\">Endereço:: ");
#nullable restore
#line 29 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
                                      Write(servico.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 29 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
                                                          Write(servico.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n        <p class=\"text-justify\">Horário de funcionamento: ");
#nullable restore
#line 30 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
                                                     Write(servico.HorarioFuncionamento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"text-justify\">Telefone: ");
#nullable restore
#line 31 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
                                     Write(servico.TelefonePrestador);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"text-justify\">Empresa / grupo responsável: ");
#nullable restore
#line 32 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
                                                        Write(servico.NomeResponsavel);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n");
#nullable restore
#line 33 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
     


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 38 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
 if (Model.VitrineEstacionamento.Count() != 0)
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
     foreach (var estacionamento in Model.VitrineEstacionamento)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <h2>");
#nullable restore
#line 44 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
       Write(estacionamento.NomeEstacionamento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <p class=\"text-justify\">Endereço de atuação: ");
#nullable restore
#line 45 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
                                                Write(estacionamento.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 45 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
                                                                           Write(estacionamento.NomeEstado);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n        <p class=\"text-justify\">Horário de funcionamento: ");
#nullable restore
#line 46 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
                                                     Write(estacionamento.HorarioFuncionamento);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n        <p class=\"text-justify\">Telefone: ");
#nullable restore
#line 47 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
                                     Write(estacionamento.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"text-justify\">Totais de vagas disponíveis: ");
#nullable restore
#line 48 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
                                                        Write(estacionamento.TotaisVagas);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n        <p class=\"text-justify\">Vagas para carros elétricos: ");
#nullable restore
#line 49 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
                                                        Write(estacionamento.VagasEletricas);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n        <p class=\"text-justify\">Vagas preferenciais: ");
#nullable restore
#line 50 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
                                                Write(estacionamento.VagasPreferenciais);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n        <p class=\"text-justify\">Vagas comuns: ");
#nullable restore
#line 51 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
                                         Write(estacionamento.VagasComuns);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n        <p class=\"text-justify\">Empresa / grupo responsável: ");
#nullable restore
#line 52 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
                                                        Write(estacionamento.NomeResponsavel);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n");
#nullable restore
#line 53 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\ferne\Documents\GitHub\Mike 2\EasyPark\EasyPark\Views\Cliente\VerServico.cshtml"
     

}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyPark.EasyPark.Domain.Responses.VitrineServicos> Html { get; private set; }
    }
}
#pragma warning restore 1591
