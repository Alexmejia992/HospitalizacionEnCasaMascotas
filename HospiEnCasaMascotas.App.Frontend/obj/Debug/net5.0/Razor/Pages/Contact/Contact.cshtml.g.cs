#pragma checksum "/home/alex/Desktop/HospitalizacionEnCasaMascotas/HospiEnCasaMascotas.App.Frontend/Pages/Contact/Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9c1e1af6e2d80c21eb6ab2e07c8b2fc3e805e06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiEnCasaMascotas.App.Frontend.Pages.Contact.Pages_Contact_Contact), @"mvc.1.0.razor-page", @"/Pages/Contact/Contact.cshtml")]
namespace HospiEnCasaMascotas.App.Frontend.Pages.Contact
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
#line 1 "/home/alex/Desktop/HospitalizacionEnCasaMascotas/HospiEnCasaMascotas.App.Frontend/Pages/_ViewImports.cshtml"
using HospiEnCasaMascotas.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9c1e1af6e2d80c21eb6ab2e07c8b2fc3e805e06", @"/Pages/Contact/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6815146556d502ba3838d9dcefa3ea0d126d36a6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contact_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style type=""text/css"">
body{
    background-image: url(/images/contacts.jpg);
}
.navbar{
    color: white;
}
.form-img{
    background-image: url(/images/form-back.jpg);
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
.btn{
    padding-left: 2.5rem;
    padding-right: 2.5rem;

}
</style>
    <div class=""form-styled filter"">
        <div class=""form-img""><");
            WriteLiteral("/div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9c1e1af6e2d80c21eb6ab2e07c8b2fc3e805e064617", async() => {
                WriteLiteral(@"
            <div class=""form-row"">
                <div class=""col-md-6 col-sm-12"">
                    <label for=""inputName"">Nombre</label>
                    <input type=""text"" class=""form-control"" id=""inputName"" placeholder=""Nombre"">
                </div>
                <div class=""col-md-6 col-sm-12"">
                    <label for=""inputEmail"">Email</label>
                    <input type=""email"" class=""form-control"" id=""inputEmail"" placeholder=""Email"">
                </div>
            </div>
            <div class=""form-group mt-2"">
                <label for=""exampleFormControlTextarea1"">Déjanos tus comentarios</label>
                <textarea class=""form-control"" id=""exampleFormControlTextarea1"" rows=""5""></textarea>
            </div>
            <div class=""d-flex justify-content-center"">
                <button class=""btn btn-secondary"" type=""button"">Enviar</button>
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
            WriteLiteral("\r\n    </div> \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospiEnCasaMascotas.App.Frontend.Pages.ContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasaMascotas.App.Frontend.Pages.ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasaMascotas.App.Frontend.Pages.ContactModel>)PageContext?.ViewData;
        public HospiEnCasaMascotas.App.Frontend.Pages.ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
