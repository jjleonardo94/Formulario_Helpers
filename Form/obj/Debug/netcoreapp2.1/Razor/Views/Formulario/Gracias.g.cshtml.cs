#pragma checksum "C:\Users\Juan Jose Leonardo\source\repos\Form\Form\Views\Formulario\Gracias.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88d0172e80da160227f5fc1929be35b260080df1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Formulario_Gracias), @"mvc.1.0.view", @"/Views/Formulario/Gracias.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Formulario/Gracias.cshtml", typeof(AspNetCore.Views_Formulario_Gracias))]
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
#line 1 "C:\Users\Juan Jose Leonardo\source\repos\Form\Form\Views\_ViewImports.cshtml"
using Form;

#line default
#line hidden
#line 2 "C:\Users\Juan Jose Leonardo\source\repos\Form\Form\Views\_ViewImports.cshtml"
using Form.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d0172e80da160227f5fc1929be35b260080df1", @"/Views/Formulario/Gracias.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ad1894cf2a5a996cc341bfb6a6502f1eb2ef4df", @"/Views/_ViewImports.cshtml")]
    public class Views_Formulario_Gracias : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Form.Models.Empleado>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Juan Jose Leonardo\source\repos\Form\Form\Views\Formulario\Gracias.cshtml"
  
    ViewData["Title"] = "Gracias";

#line default
#line hidden
            BeginContext(74, 12, true);
            WriteLiteral("\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(86, 1415, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "601393fea722400e909d05733fbab469", async() => {
                BeginContext(92, 10, true);
                WriteLiteral("\r\n\r\n\r\n    ");
                EndContext();
                BeginContext(102, 1388, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6fb90e83339498e9bd33fd5fce6fdf2", async() => {
                    BeginContext(108, 35, true);
                    WriteLiteral("\r\n\r\n        <div>\r\n            <h3>");
                    EndContext();
                    BeginContext(144, 12, false);
#line 15 "C:\Users\Juan Jose Leonardo\source\repos\Form\Form\Views\Formulario\Gracias.cshtml"
           Write(Model.Cedula);

#line default
#line hidden
                    EndContext();
                    BeginContext(156, 54, true);
                    WriteLiteral("</h3>\r\n        </div>\r\n        <div>\r\n            <h3>");
                    EndContext();
                    BeginContext(211, 12, false);
#line 18 "C:\Users\Juan Jose Leonardo\source\repos\Form\Form\Views\Formulario\Gracias.cshtml"
           Write(Model.Nombre);

#line default
#line hidden
                    EndContext();
                    BeginContext(223, 54, true);
                    WriteLiteral("</h3>\r\n        </div>\r\n        <div>\r\n            <h3>");
                    EndContext();
                    BeginContext(278, 14, false);
#line 21 "C:\Users\Juan Jose Leonardo\source\repos\Form\Form\Views\Formulario\Gracias.cshtml"
           Write(Model.Apellido);

#line default
#line hidden
                    EndContext();
                    BeginContext(292, 54, true);
                    WriteLiteral("</h3>\r\n        </div>\r\n        <div>\r\n            <h3>");
                    EndContext();
                    BeginContext(347, 10, false);
#line 24 "C:\Users\Juan Jose Leonardo\source\repos\Form\Form\Views\Formulario\Gracias.cshtml"
           Write(Model.Edad);

#line default
#line hidden
                    EndContext();
                    BeginContext(357, 54, true);
                    WriteLiteral("</h3>\r\n        </div>\r\n        <div>\r\n            <h3>");
                    EndContext();
                    BeginContext(412, 14, false);
#line 27 "C:\Users\Juan Jose Leonardo\source\repos\Form\Form\Views\Formulario\Gracias.cshtml"
           Write(Model.Telefono);

#line default
#line hidden
                    EndContext();
                    BeginContext(426, 54, true);
                    WriteLiteral("</h3>\r\n        </div>\r\n        <div>\r\n            <h3>");
                    EndContext();
                    BeginContext(481, 11, false);
#line 30 "C:\Users\Juan Jose Leonardo\source\repos\Form\Form\Views\Formulario\Gracias.cshtml"
           Write(Model.Email);

#line default
#line hidden
                    EndContext();
                    BeginContext(492, 40, true);
                    WriteLiteral("</h3>\r\n        </div>\r\n\r\n        <div>\r\n");
                    EndContext();
#line 34 "C:\Users\Juan Jose Leonardo\source\repos\Form\Form\Views\Formulario\Gracias.cshtml"
             if (Model.Genero == true)
            {


#line default
#line hidden
                    BeginContext(589, 16, true);
                    WriteLiteral("                ");
                    EndContext();
                    BeginContext(607, 21, true);
                    WriteLiteral(" <h3>Masculino</h3>\r\n");
                    EndContext();
#line 38 "C:\Users\Juan Jose Leonardo\source\repos\Form\Form\Views\Formulario\Gracias.cshtml"

            }
            else
            {


#line default
#line hidden
                    BeginContext(680, 16, true);
                    WriteLiteral("                ");
                    EndContext();
                    BeginContext(698, 20, true);
                    WriteLiteral(" <h3>Femenino</h3>\r\n");
                    EndContext();
#line 44 "C:\Users\Juan Jose Leonardo\source\repos\Form\Form\Views\Formulario\Gracias.cshtml"

            }

#line default
#line hidden
                    BeginContext(735, 79, true);
                    WriteLiteral("        </div>\r\n        <div>\r\n            <h3>\r\n                Estado_Civil: ");
                    EndContext();
#line 49 "C:\Users\Juan Jose Leonardo\source\repos\Form\Form\Views\Formulario\Gracias.cshtml"
                               for (int a = 0; a < Model.Estado_Civil.Length; a++)
                {
                    if (Model.Estado_Civil[a] != "false")
                    {
                        

#line default
#line hidden
                    BeginContext(994, 21, false);
#line 53 "C:\Users\Juan Jose Leonardo\source\repos\Form\Form\Views\Formulario\Gracias.cshtml"
                   Write(Model.Estado_Civil[a]);

#line default
#line hidden
                    EndContext();
#line 53 "C:\Users\Juan Jose Leonardo\source\repos\Form\Form\Views\Formulario\Gracias.cshtml"
                                              
                    }
                }

#line default
#line hidden
                    BeginContext(1059, 94, true);
                    WriteLiteral("            </h3>\r\n\r\n        </div>\r\n        <div>\r\n            <h3>\r\n                Hobbys: ");
                    EndContext();
#line 61 "C:\Users\Juan Jose Leonardo\source\repos\Form\Form\Views\Formulario\Gracias.cshtml"
                         for (int i = 0; i < Model.Hobbys.Length; i++)
                {
                    if (Model.Hobbys[i] != "false")
                    {
                        

#line default
#line hidden
                    BeginContext(1321, 15, false);
#line 65 "C:\Users\Juan Jose Leonardo\source\repos\Form\Form\Views\Formulario\Gracias.cshtml"
                   Write(Model.Hobbys[i]);

#line default
#line hidden
                    EndContext();
                    BeginContext(1338, 54, true);
                    WriteLiteral("                        <span> <span> </span></span>\r\n");
                    EndContext();
#line 67 "C:\Users\Juan Jose Leonardo\source\repos\Form\Form\Views\Formulario\Gracias.cshtml"

                    }
                }

#line default
#line hidden
                    BeginContext(1436, 47, true);
                    WriteLiteral("            </h3>\r\n\r\n        </div>\r\n\r\n\r\n\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1490, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1501, 13, true);
            WriteLiteral("\r\n\r\n\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Form.Models.Empleado> Html { get; private set; }
    }
}
#pragma warning restore 1591
