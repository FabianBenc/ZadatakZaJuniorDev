#pragma checksum "C:\Users\Fabian\Desktop\Gotovo\volimoZnidarica\Views\Imenik\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f55e53645c796f2259f3ef6739e7168c01480a6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Imenik_Details), @"mvc.1.0.view", @"/Views/Imenik/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Imenik/Details.cshtml", typeof(AspNetCore.Views_Imenik_Details))]
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
#line 1 "C:\Users\Fabian\Desktop\Gotovo\volimoZnidarica\Views\_ViewImports.cshtml"
using zadatakZaProgramere;

#line default
#line hidden
#line 2 "C:\Users\Fabian\Desktop\Gotovo\volimoZnidarica\Views\_ViewImports.cshtml"
using zadatakZaProgramere.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f55e53645c796f2259f3ef6739e7168c01480a6d", @"/Views/Imenik/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"517a1afa322397c4ab9cb1dac8bc855d27697ae1", @"/Views/_ViewImports.cshtml")]
    public class Views_Imenik_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Imenik.Models.Kontakti>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Fabian\Desktop\Gotovo\volimoZnidarica\Views\Imenik\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(76, 191, true);
            WriteLiteral("\r\n<h1>Detalji</h1>\r\n<style>\r\ntable, td, th {\r\n  border: 1px solid black;\r\n}\r\n\r\ntable {\r\n  border-collapse: collapse;\r\n  width: 100%;\r\n}\r\n\r\nimg{\r\nfloat:right;\r\n\r\n}\r\n</style>\r\n\r\n<div>\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 267, "\"", 311, 1);
#line 25 "C:\Users\Fabian\Desktop\Gotovo\volimoZnidarica\Views\Imenik\Details.cshtml"
WriteAttributeValue("", 273, Html.DisplayFor(model => model.slika), 273, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(312, 110, true);
            WriteLiteral(" height=300px width=300px /> \r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(423, 39, false);
#line 29 "C:\Users\Fabian\Desktop\Gotovo\volimoZnidarica\Views\Imenik\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ime));

#line default
#line hidden
            EndContext();
            BeginContext(462, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(526, 35, false);
#line 32 "C:\Users\Fabian\Desktop\Gotovo\volimoZnidarica\Views\Imenik\Details.cshtml"
       Write(Html.DisplayFor(model => model.ime));

#line default
#line hidden
            EndContext();
            BeginContext(561, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(624, 43, false);
#line 35 "C:\Users\Fabian\Desktop\Gotovo\volimoZnidarica\Views\Imenik\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.prezime));

#line default
#line hidden
            EndContext();
            BeginContext(667, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(731, 39, false);
#line 38 "C:\Users\Fabian\Desktop\Gotovo\volimoZnidarica\Views\Imenik\Details.cshtml"
       Write(Html.DisplayFor(model => model.prezime));

#line default
#line hidden
            EndContext();
            BeginContext(770, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(833, 40, false);
#line 41 "C:\Users\Fabian\Desktop\Gotovo\volimoZnidarica\Views\Imenik\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.grad));

#line default
#line hidden
            EndContext();
            BeginContext(873, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(937, 36, false);
#line 44 "C:\Users\Fabian\Desktop\Gotovo\volimoZnidarica\Views\Imenik\Details.cshtml"
       Write(Html.DisplayFor(model => model.grad));

#line default
#line hidden
            EndContext();
            BeginContext(973, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1036, 40, false);
#line 47 "C:\Users\Fabian\Desktop\Gotovo\volimoZnidarica\Views\Imenik\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.opis));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1140, 36, false);
#line 50 "C:\Users\Fabian\Desktop\Gotovo\volimoZnidarica\Views\Imenik\Details.cshtml"
       Write(Html.DisplayFor(model => model.opis));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 306, true);
            WriteLiteral(@"
        </dd>
    </dl>
    
</div><br>
<br>
<table>
    <thead>
        <tr>
            <th>
                Broj
            </th>
            <th>
                Opis
            </th>
            <th>
                Tip
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 71 "C:\Users\Fabian\Desktop\Gotovo\volimoZnidarica\Views\Imenik\Details.cshtml"
         foreach(var i in Model.telefon){

#line default
#line hidden
            BeginContext(1525, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1586, 36, false);
#line 74 "C:\Users\Fabian\Desktop\Gotovo\volimoZnidarica\Views\Imenik\Details.cshtml"
               Write(Html.DisplayFor(modelItem => i.broj));

#line default
#line hidden
            EndContext();
            BeginContext(1622, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1690, 36, false);
#line 77 "C:\Users\Fabian\Desktop\Gotovo\volimoZnidarica\Views\Imenik\Details.cshtml"
               Write(Html.DisplayFor(modelItem => i.opis));

#line default
#line hidden
            EndContext();
            BeginContext(1726, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1794, 35, false);
#line 80 "C:\Users\Fabian\Desktop\Gotovo\volimoZnidarica\Views\Imenik\Details.cshtml"
               Write(Html.DisplayFor(modelItem => i.tip));

#line default
#line hidden
            EndContext();
            BeginContext(1829, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 83 "C:\Users\Fabian\Desktop\Gotovo\volimoZnidarica\Views\Imenik\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1884, 37, true);
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1921, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f55e53645c796f2259f3ef6739e7168c01480a6d10228", async() => {
                BeginContext(1967, 5, true);
                WriteLiteral("Uredi");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 88 "C:\Users\Fabian\Desktop\Gotovo\volimoZnidarica\Views\Imenik\Details.cshtml"
                           WriteLiteral(Model.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1976, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1984, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f55e53645c796f2259f3ef6739e7168c01480a6d12546", async() => {
                BeginContext(2006, 18, true);
                WriteLiteral("Natrag na Kontakte");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2028, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Imenik.Models.Kontakti> Html { get; private set; }
    }
}
#pragma warning restore 1591
