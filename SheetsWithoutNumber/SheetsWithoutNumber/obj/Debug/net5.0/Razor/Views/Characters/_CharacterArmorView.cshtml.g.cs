#pragma checksum "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\_CharacterArmorView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e60ce7f4588cc3b4f47f14e5ff2e1b8bbee8ecbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Characters__CharacterArmorView), @"mvc.1.0.view", @"/Views/Characters/_CharacterArmorView.cshtml")]
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
#line 1 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\_ViewImports.cshtml"
using SheetsWithoutNumber;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\_ViewImports.cshtml"
using SheetsWithoutNumber.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\_ViewImports.cshtml"
using SheetsWithoutNumber.Models.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\_ViewImports.cshtml"
using SheetsWithoutNumber.Models.Characters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\_ViewImports.cshtml"
using SheetsWithoutNumber.Models.Games;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\_ViewImports.cshtml"
using SheetsWithoutNumber.Models.Skills;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\_ViewImports.cshtml"
using SheetsWithoutNumber.Models.Foci;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\_ViewImports.cshtml"
using SheetsWithoutNumber.Models.Equipments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\_ViewImports.cshtml"
using SheetsWithoutNumber.Models.Armors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\_ViewImports.cshtml"
using SheetsWithoutNumber.Models.MeleeWeapons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\_ViewImports.cshtml"
using SheetsWithoutNumber.Models.RangedWeapons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\_ViewImports.cshtml"
using SheetsWithoutNumber.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\_ViewImports.cshtml"
using SWN.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e60ce7f4588cc3b4f47f14e5ff2e1b8bbee8ecbd", @"/Views/Characters/_CharacterArmorView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e40895d6153271a33cc3269944cd3e9ef42b133", @"/Views/_ViewImports.cshtml")]
    public class Views_Characters__CharacterArmorView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CharacterDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Armors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""table-sm table-responsive"">
    <table class=""table table-hover table-bordered"">
        <tbody>
            <tr class=""text-center"" style=""background-color: lightblue"">
                <td><b>Armor</b></td>
                <td class=""col-1""><b>AC</b></td>
                <td class=""col-1""><b>Enc.</b></td>
                <td class=""col-1""><b>TL</b></td>
                <td class=""col-2""><b>Location</b></td>
            </tr>
");
#nullable restore
#line 13 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\_CharacterArmorView.cshtml"
             if (Model.CharactersArmors.Any(ca => ca.CharacterId == Model.Id))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\_CharacterArmorView.cshtml"
                 foreach (var characterArmor in @Model.CharactersArmors.Where(ca => ca.CharacterId == Model.Id))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"text-center\">\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e60ce7f4588cc3b4f47f14e5ff2e1b8bbee8ecbd8213", async() => {
                WriteLiteral("\r\n                                ");
#nullable restore
#line 20 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\_CharacterArmorView.cshtml"
                           Write(characterArmor.ArmorName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-characterArmorId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\_CharacterArmorView.cshtml"
                                                                                         WriteLiteral(characterArmor.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["characterArmorId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-characterArmorId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["characterArmorId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 23 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\_CharacterArmorView.cshtml"
                       Write(characterArmor.ArmorClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 24 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\_CharacterArmorView.cshtml"
                       Write(characterArmor.ArmorEncumbrance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 25 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\_CharacterArmorView.cshtml"
                       Write(characterArmor.ArmorTechLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\_CharacterArmorView.cshtml"
                       Write(characterArmor.ArmorLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 28 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\_CharacterArmorView.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\_CharacterArmorView.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"text-center\">\r\n                    <td>No equipped Armor</td>\r\n                    <td>N/A</td>\r\n                    <td>N/A</td>\r\n                    <td>N/A</td>\r\n                    <td>N/A</td>\r\n                </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\_CharacterArmorView.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"1\">\r\n                    <div class=\"text-center\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e60ce7f4588cc3b4f47f14e5ff2e1b8bbee8ecbd13734", async() => {
                WriteLiteral("\r\n                            <input type=\"button\" style=\"font-size: 0.85rem; padding-top:0.25rem\"");
                BeginWriteAttribute("class", " class=\"", 2042, "\"", 2074, 2);
                WriteAttributeValue("", 2050, "btn", 2050, 3, true);
#nullable restore
#line 46 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\_CharacterArmorView.cshtml"
WriteAttributeValue(" ", 2053, ViewBag.ButtonColor, 2054, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 46 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\_CharacterArmorView.cshtml"
                                                                                                                             Write(ViewBag.DisabledButton);

#line default
#line hidden
#nullable disable
                WriteLiteral(" value=\"Add\" />\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-characterId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\_CharacterArmorView.cshtml"
                                                                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["characterId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-characterId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["characterId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </td>\r\n                <td colspan=\"4\"></td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CharacterDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
