#pragma checksum "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\_CharacterSavingThrowsView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3cee64ca27d51617779006aae4b4061a5d1be43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Characters__CharacterSavingThrowsView), @"mvc.1.0.view", @"/Views/Characters/_CharacterSavingThrowsView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3cee64ca27d51617779006aae4b4061a5d1be43", @"/Views/Characters/_CharacterSavingThrowsView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e40895d6153271a33cc3269944cd3e9ef42b133", @"/Views/_ViewImports.cshtml")]
    public class Views_Characters__CharacterSavingThrowsView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CharacterDetailsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""table table-responsive"">
    <table class=""table-sm table-bordered"">
        <tbody>
            <tr class=""text-center"" style=""background-color: lightblue"">
                <td colspan=""2""><b>Saving Throws</b></td>
            </tr>
            <tr class=""text-center"">
                <td style=""background-color: aliceblue"">Physical</td>
                <td>");
#nullable restore
#line 11 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\_CharacterSavingThrowsView.cshtml"
               Write(Model.SavingThrowPhysical);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr class=\"text-center\">\r\n                <td style=\"background-color: aliceblue\">Mental</td>\r\n                <td>");
#nullable restore
#line 15 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\_CharacterSavingThrowsView.cshtml"
               Write(Model.SavingThrowMental);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr class=\"text-center\">\r\n                <td style=\"background-color: aliceblue\">Evasion</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\_CharacterSavingThrowsView.cshtml"
               Write(Model.SavingThrowEvasion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n</div>");
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
