#pragma checksum "C:\Users\MAX\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f73b755909275f56f948bdbf5f30dddb063e392"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\MAX\source\repos\WebApplication4\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MAX\source\repos\WebApplication4\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f73b755909275f56f948bdbf5f30dddb063e392", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fff4eb847734ec2c3f91807e9b1a08bbda85e45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication4.DataChange>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\MAX\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Настройка графика</h2>\r\n\r\n<fieldset>\r\n    <legend>\r\n");
#nullable restore
#line 11 "C:\Users\MAX\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
         using (Html.BeginForm("second", "Home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"custom-control-label\">\r\n                ");
#nullable restore
#line 14 "C:\Users\MAX\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
           Write(Html.LabelFor(Model => Model.Sinse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"input-group-text\">\r\n                ");
#nullable restore
#line 17 "C:\Users\MAX\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
           Write(Html.EditorFor(Model => Model.Sinse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"in\">\r\n                ");
#nullable restore
#line 22 "C:\Users\MAX\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
           Write(Html.LabelFor(Model => Model.For));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"input-group-text\">\r\n                ");
#nullable restore
#line 25 "C:\Users\MAX\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
           Write(Html.EditorFor(Model => Model.For));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"custom-control-label\">\r\n                ");
#nullable restore
#line 30 "C:\Users\MAX\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
           Write(Html.LabelFor(Model => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"input-group-text\">\r\n                ");
#nullable restore
#line 33 "C:\Users\MAX\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
           Write(Html.EditorFor(Model => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <p>\r\n                <input type=\"submit\" value=\"Chart\" />\r\n            </p>\r\n");
#nullable restore
#line 39 "C:\Users\MAX\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </legend>\r\n</fieldset>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 99 "C:\Users\MAX\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication4.DataChange> Html { get; private set; }
    }
}
#pragma warning restore 1591
