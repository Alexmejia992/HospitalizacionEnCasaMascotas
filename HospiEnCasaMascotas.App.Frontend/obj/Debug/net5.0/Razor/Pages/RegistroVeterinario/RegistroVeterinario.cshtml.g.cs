#pragma checksum "C:\Users\gaml_\Documents\GitHub\HospitalizacionEnCasaMascotas\HospiEnCasaMascotas.App.Frontend\Pages\RegistroVeterinario\RegistroVeterinario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2dff4bbe0e90ee05c7b98827bce291134fd1424"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiEnCasaMascotas.App.Frontend.Pages.RegistroVeterinario.Pages_RegistroVeterinario_RegistroVeterinario), @"mvc.1.0.razor-page", @"/Pages/RegistroVeterinario/RegistroVeterinario.cshtml")]
namespace HospiEnCasaMascotas.App.Frontend.Pages.RegistroVeterinario
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
#line 1 "C:\Users\gaml_\Documents\GitHub\HospitalizacionEnCasaMascotas\HospiEnCasaMascotas.App.Frontend\Pages\_ViewImports.cshtml"
using HospiEnCasaMascotas.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2dff4bbe0e90ee05c7b98827bce291134fd1424", @"/Pages/RegistroVeterinario/RegistroVeterinario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6815146556d502ba3838d9dcefa3ea0d126d36a6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RegistroVeterinario_RegistroVeterinario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-center mt-5 d-flex flex-column justify-content-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\gaml_\Documents\GitHub\HospitalizacionEnCasaMascotas\HospiEnCasaMascotas.App.Frontend\Pages\RegistroVeterinario\RegistroVeterinario.cshtml"
  
    ViewData["Title"] = "Registro Veterinario";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style type=""text/css"">
body{
    background-image: url(/images/registry.jpg);
}
.form-img{
    background-image: url(/images/form-back.png);
    height: 7rem ;
    background-size: cover;
    background-position: center center;
    border-top-left-radius: 10px;
    border-top-right-radius: 10px;
    position: relative;
}
.form-img::before{
    position: absolute;
    content: '';
    
    background-color: white;
    height: 5rem;
    width: 60%;
    top: 80%;
    left: 50%;
    transform: translate(-50%, -10%);
    border-top-left-radius: 70%;
    border-top-right-radius: 70%;
    border-bottom-left-radius: 50%;
    border-bottom-right-radius: 50%;
}
.form-styled{
    border-radius: 10px;
    max-width: 40vw;
    max-height: 80vh;
    background-color: white;
}
.form-center{
    padding: 3%;
}

#contenedor-R-form{
    background-color: #fff;
    max-width: 740px;
    margin: 10px auto 0;
    padding: 0;
    color: ""#006699"";
    box-shadow: 6px 6px 6px rgba(0,0,0,");
            WriteLiteral(@"0.2);
    border-radius: 10px;
    margin-bottom: 5rem;
}

#Contenedor-R-form h2{
    margin: 100px;
    font-size: 22px;
    color:""#006699"";
}

#contenedor-R-form .form-group{
	margin-bottom: 20px;
    margin-left:20px;
    margin: 20px;
	width: 100%;
    float:left;
    text-align: left;
}

#Contenedor-R-form .btn{
    width: 56%;
    margin: 20px auto 0;
    display: block;
    outline: none;
}

</style>

<div class=""container"" id=""contenedor-R-form"">
 <div class=""form-img""></div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2dff4bbe0e90ee05c7b98827bce291134fd14245766", async() => {
                WriteLiteral(@"
 <h2>Datos del Veterinario</h2>
<div class=""row"">

    <div class=""form-group col"">
        <label for=""inputNombreV"">Nombre </label>        
        <input type=""text"" class=""form-control"" placeholder=""Ingresa tu Nombre"">
    </div>   
     <div class=""form-group col"">
         <label for=""inputApellidoV"">Apellido </label>
         <input type=""text"" class=""form-control"" placeholder=""Ingresa tu Apellido"">            
    </div>
</div>
<div class=""row"">
    <div class=""form-group col"">
        <label for=""inputTelefonoV"">Teléfono </label>
        <input type=""text"" class=""form-control"" placeholder=""Ingresa tu Teléfono"">
    </div>
    <div class=""form-group col"">
         <label for=""inputEmailV"">Email </label>
         <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Ingresa tu email"">       
    </div>
</div>
<div class=""row"">
    <div class=""form-group col"">
     <label for=""SelectGenero"">Genero</label>
     <select class=");
                WriteLiteral("\"form-control\" id=\"SelectGenero\">\r\n       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2dff4bbe0e90ee05c7b98827bce291134fd14247182", async() => {
                    WriteLiteral("Selecciona tu Genero");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2dff4bbe0e90ee05c7b98827bce291134fd14248863", async() => {
                    WriteLiteral("Masculino");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2dff4bbe0e90ee05c7b98827bce291134fd14249887", async() => {
                    WriteLiteral("Femenino");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2dff4bbe0e90ee05c7b98827bce291134fd142410910", async() => {
                    WriteLiteral("No Especifica");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
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
    <div class=""form-group col"">
        <label for=""inputNumPermiso"">Numero Permiso </label>
         <input type=""number"" class=""form-control"" placeholder=""Ingresa Numero de Permiso"">
    </div>
</div>

<div class=""row"">

    <div class=""form-group col"">
        <label for=""inputEspecialidad"">Especialidad </label>        
        <input type=""text"" class=""form-control"" placeholder=""Ingresa la Especialidad"">
    </div>   
     <div class=""form-group col"">
                    
    </div>
</div>

            <div class=""d-flex justify-content-center"">
                <button class=""btn btn-lg btn-secondary"" type=""button"">Continuar</button>
            </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospiEnCasaMascotas.App.Frontend.Pages.RegistroVeterinarioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasaMascotas.App.Frontend.Pages.RegistroVeterinarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasaMascotas.App.Frontend.Pages.RegistroVeterinarioModel>)PageContext?.ViewData;
        public HospiEnCasaMascotas.App.Frontend.Pages.RegistroVeterinarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
