#pragma checksum "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e16d0f72b383429482b7f3d407ff91e57a9f697"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GelirGider_GelirGiderListele), @"mvc.1.0.view", @"/Views/GelirGider/GelirGiderListele.cshtml")]
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
#line 1 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\_ViewImports.cshtml"
using SiparisStokTakip.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\_ViewImports.cshtml"
using SiparisStokTakip.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e16d0f72b383429482b7f3d407ff91e57a9f697", @"/Views/GelirGider/GelirGiderListele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"573f962dbf3ab7a55bbb1df36f3f566ff9bc2200", @"/Views/_ViewImports.cshtml")]
    public class Views_GelirGider_GelirGiderListele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SiparisStokTakip.Entities.GelirGider>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GelirGiderEkle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GelirGiderGuncelle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GelirGiderSil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
  
    ViewData["Title"] = "Gelir - Gider Listesi";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e16d0f72b383429482b7f3d407ff91e57a9f6974735", async() => {
                WriteLiteral("Gider Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
           Write(Html.DisplayNameFor(model => model.Tarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
           Write(Html.DisplayNameFor(model => model.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
           Write(Html.DisplayNameFor(model => model.Soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
           Write(Html.DisplayNameFor(model => model.Malzeme));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
           Write(Html.DisplayNameFor(model => model.VerilenTL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
           Write(Html.DisplayNameFor(model => model.VerilenUSD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
           Write(Html.DisplayNameFor(model => model.AlınanTL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
           Write(Html.DisplayNameFor(model => model.AlınanUSD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
           Write(Html.DisplayNameFor(model => model.USDAlirkenVergi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 46 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
               Write(Html.DisplayFor(modelItem => item.Tarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
               Write(Html.DisplayFor(modelItem => item.Soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
               Write(Html.DisplayFor(modelItem => item.Malzeme));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
               Write(Html.DisplayFor(modelItem => item.VerilenTL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
               Write(Html.DisplayFor(modelItem => item.VerilenUSD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
               Write(Html.DisplayFor(modelItem => item.AlınanTL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
               Write(Html.DisplayFor(modelItem => item.AlınanUSD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
               Write(Html.DisplayFor(modelItem => item.USDAlirkenVergi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e16d0f72b383429482b7f3d407ff91e57a9f69712744", async() => {
                WriteLiteral("Güncelle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
                                                         WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e16d0f72b383429482b7f3d407ff91e57a9f69714965", async() => {
                WriteLiteral("Sil");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
                                                    WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 81 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<br />\r\n<div>\r\n    <p>\r\n");
#nullable restore
#line 87 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
          
            int verilenTL = 0; // toplam değişkenini tanımlayın ve başlangıç değeri olarak sıfır atayın
            int alinanTL = 0;
            int verilenUSD = 0;
            int alinanUSD = 0;

            foreach (var fiyat in Model)
            {
                verilenTL += fiyat.VerilenTL + fiyat.USDAlirkenVergi; // Her bir fiyatı toplama ekleyin
                alinanTL += fiyat.AlınanTL;
                verilenUSD += fiyat.VerilenUSD;
                alinanUSD += fiyat.AlınanUSD;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("        Toplam Gider Tutarı : ");
#nullable restore
#line 103 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
                         Write(verilenTL.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL | ");
#nullable restore
#line 103 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
                                                        Write(verilenUSD.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" USD <br />\r\n        Toplam Gelir Tutarı : ");
#nullable restore
#line 104 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
                         Write(alinanTL.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL |  ");
#nullable restore
#line 104 "C:\Users\100103\Desktop\Ders\SiparisStokTakip\SiparisStokTakip.Web\Views\GelirGider\GelirGiderListele.cshtml"
                                                        Write(alinanUSD.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" USD\r\n    </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SiparisStokTakip.Entities.GelirGider>> Html { get; private set; }
    }
}
#pragma warning restore 1591