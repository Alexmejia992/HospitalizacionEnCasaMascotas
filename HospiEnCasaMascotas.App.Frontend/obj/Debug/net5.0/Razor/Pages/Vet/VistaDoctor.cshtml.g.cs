#pragma checksum "C:\Users\blanc\OneDrive\Documentos\GitHub\HospitalizacionEnCasaMascotas\HospiEnCasaMascotas.App.Frontend\Pages\Vet\VistaDoctor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c747edac42faee39bed1023127c3582ecbe3436"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiEnCasaMascotas.App.Frontend.Pages.Vet.Pages_Vet_VistaDoctor), @"mvc.1.0.razor-page", @"/Pages/Vet/VistaDoctor.cshtml")]
namespace HospiEnCasaMascotas.App.Frontend.Pages.Vet
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
#line 1 "C:\Users\blanc\OneDrive\Documentos\GitHub\HospitalizacionEnCasaMascotas\HospiEnCasaMascotas.App.Frontend\Pages\_ViewImports.cshtml"
using HospiEnCasaMascotas.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c747edac42faee39bed1023127c3582ecbe3436", @"/Pages/Vet/VistaDoctor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6815146556d502ba3838d9dcefa3ea0d126d36a6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Vet_VistaDoctor : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "HistoriaClinica", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\blanc\OneDrive\Documentos\GitHub\HospitalizacionEnCasaMascotas\HospiEnCasaMascotas.App.Frontend\Pages\Vet\VistaDoctor.cshtml"
  
    ViewData["Title"] = "Veterinario";
    Layout = "~/Pages/Shared/_LayoutVet.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style type=""text/css"">

#contenedor-R-form-der{
    background-color: #fff;
    max-width: 680px;
    height: 266px;
   
    padding: 50px;
    color: ""#006699"";
    
}

#Contenedor-R-form h2{
    margin: 100px;
    font-size: 22px;
    color:""#006699"";
    padding: 10px;
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

.btn-left{
        background-image:url(/images/veterinario.png);
        background-repeat:no-repeat;
        height:60px;
        width:70px;
        background-position:center;
        border: none;
    }
</style>

  <div class=""container box-shadow"" id=""contenedor-R-form-der"">
      <div class=""form-center mt-5 d-flex flex-column justify-content-center align-self-center"">      
            <div class=""row"">
                 <div class");
            WriteLiteral("=\"form-group col\">\r\n                    <div class=\"d-flex justify-content-center\">    \r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c747edac42faee39bed1023127c3582ecbe34365603", async() => {
                WriteLiteral("Historia Clinica");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                 </div>
                  <div class=""form-group col"">
                    <div class=""d-flex justify-content-center"">
                        <a class=""btn btn-lg btn-secondary"" type=""button"">Signo Vital</a>
                    </div>
                  </div>
            </div>
      </div>
  </div> 
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospiEnCasaMascotas.App.Frontend.Pages.Vet.VistaDoctorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasaMascotas.App.Frontend.Pages.Vet.VistaDoctorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasaMascotas.App.Frontend.Pages.Vet.VistaDoctorModel>)PageContext?.ViewData;
        public HospiEnCasaMascotas.App.Frontend.Pages.Vet.VistaDoctorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
