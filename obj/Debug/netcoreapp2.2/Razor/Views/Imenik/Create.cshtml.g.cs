#pragma checksum "C:\Users\iuono\CookieExample\ZadatakZaJuniorDev\Views\Imenik\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d1bb2a7cf419b238269bb6d4a9071fb4871489e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Imenik_Create), @"mvc.1.0.view", @"/Views/Imenik/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Imenik/Create.cshtml", typeof(AspNetCore.Views_Imenik_Create))]
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
#line 1 "C:\Users\iuono\CookieExample\ZadatakZaJuniorDev\Views\_ViewImports.cshtml"
using zadatakZaProgramere;

#line default
#line hidden
#line 2 "C:\Users\iuono\CookieExample\ZadatakZaJuniorDev\Views\_ViewImports.cshtml"
using zadatakZaProgramere.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d1bb2a7cf419b238269bb6d4a9071fb4871489e", @"/Views/Imenik/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"517a1afa322397c4ab9cb1dac8bc855d27697ae1", @"/Views/_ViewImports.cshtml")]
    public class Views_Imenik_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Imenik.Models.Kontakti>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("runat", new global::Microsoft.AspNetCore.Html.HtmlString("server"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\iuono\CookieExample\ZadatakZaJuniorDev\Views\Imenik\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(75, 139, true);
            WriteLiteral("\r\n<h1>Dodaj</h1>\r\n\r\n<h4>Kontakti</h4>\r\n<hr />\r\n\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js\"></script>\r\n");
            EndContext();
            BeginContext(214, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d1bb2a7cf419b238269bb6d4a9071fb4871489e4838", async() => {
                BeginContext(235, 110, true);
                WriteLiteral("\r\n  <input type=\'file\' id=\"imgInp\" />\r\n  <img id=\"blah\" src=\"#\" alt=\"Vaša slika\"  height=300px width=300px/>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(352, 2981, true);
            WriteLiteral(@"

<style>
  .container {
    width: 500px;
    clear: both;
  }

  .container input {
  width: 100%;
  clear: both;
  }
</style>

<script>

    function readURL(input) {
      if (input.files && input.files[0]) {
        var reader = new FileReader();
        
        reader.onload = function(e) {
          $('#blah').attr('src', e.target.result);
        }
        
        reader.readAsDataURL(input.files[0]);
      }
    }

    $(""#imgInp"").change(function() {
      readURL(this);
    });
    
    var brFormi = 0;
    var brojForme = [0];

    function obrisi(forma){
      forma = ""."" + forma;
      //console.log(forma);
      $(""div"").remove(forma);
    }

    function dodajBroj(){
      
      brFormi++;

      var broj = ""broj"" + brFormi;
      var opis = ""opisB"" + brFormi;
      var tip = ""tip"" + brFormi;
      var forma = ""forma"" + brFormi;
      
      $('.dodajBroj').append(`
      <div class=""${forma}"">
         <input type=""button"" onclick=""obrisi");
            WriteLiteral(@"('${forma}')"" value=""Obriši"" class=""tipka""/>
        <div class=""form-group"">
          Broj <input class=""${broj}""> <br>
        </div>
        <div class=""form-group"">
          Opis Broja<input class=""${opis}""> <br>
        </div>
        <div class=""form-group"">
          Tip <input class=""${tip}""> <br>
        </div>
      </div>`);
      brojForme.push(brFormi);
      console.log(brojForme);
    }

    function dodajUBazu(){
        var osoba = {
            ime: $('.ime').val(),
            prezime: $('.prezime').val(),
            grad: $('.grad').val(),
            opis: $('.opisO').val(),
            slika: $(""#blah"").attr(""src"")
        };

        /*var telBroj = {
            broj: $('.broj').val(),
            opis: $('.opisB').val(),
            tip: $('.tip').val()
        }*/

        var telBroj = [];

        brojForme.forEach(el => {
          
          var broj = "".broj"" + el;
          var opis = "".opisB"" + el;
          var tip = "".tip"" + el;

    ");
            WriteLiteral(@"      telBroj[el] = {
            broj: $(broj).val(),
            opis: $(opis).val(),
            tip: $(tip).val()
          }
        });

        var data = {};
        data.o = osoba;
        data.b = telBroj;

        console.log(osoba);
        console.log(telBroj);
        console.log(data);

        console.log(JSON.stringify(data));

        $.ajax({
            url: '/Imenik/dodaj',
            type: 'POST',
            data: JSON.stringify(data),
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            error: function(xhr) { alert('Uspješno ste dodali novi kontakt'); },
            success: function (result) { console.log(result); },
            async: true,
            processData: false
        });

        console.log(osoba);
        console.log(telBroj);
    }

</script>

<div class=""row"">
    <div class=""col-md-4"">
      ");
            EndContext();
            BeginContext(3333, 849, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d1bb2a7cf419b238269bb6d4a9071fb4871489e9587", async() => {
                BeginContext(3353, 822, true);
                WriteLiteral(@"
        <div class=""container dodajBroj"">
            <div class=""form-group"">
              Ime <input class=""ime""> <br>
            </div>
            <div class=""form-group"">
              Prezime <input class=""prezime""> <br>
            </div>
            <div class=""form-group"">
              Grad <input class=""grad""> <br>
            </div>
            <div class=""form-group"">
              Opis Osobe<input class=""opisO""> <br>
            </div>
            <div class=""form-group"">
              Broj <input class=""broj0""> <br>
            </div>
            <div class=""form-group"">
              Opis Broja<input class=""opisB0""> <br>
            </div>
            <div class=""form-group"">
              Tip <input class=""tip0""> <br>
            </div>
        </div>
        
      ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4182, 224, true);
            WriteLiteral("\r\n            <input type=\"button\" onclick=\"dodajBroj()\" value=\"Dodaj 2. broj\" class=\"tipka\"/>\r\n            <input type=\"button\" onclick=\"dodajUBazu()\" value=\"Dodaj kontakt\" class=\"tipka\"/>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(4406, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d1bb2a7cf419b238269bb6d4a9071fb4871489e12338", async() => {
                BeginContext(4428, 18, true);
                WriteLiteral("Natrag na Kontakte");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4450, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4480, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 179 "C:\Users\iuono\CookieExample\ZadatakZaJuniorDev\Views\Imenik\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Imenik.Models.Kontakti> Html { get; private set; }
    }
}
#pragma warning restore 1591
