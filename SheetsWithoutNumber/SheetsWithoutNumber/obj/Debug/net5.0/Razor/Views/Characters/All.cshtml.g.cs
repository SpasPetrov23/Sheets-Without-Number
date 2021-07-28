#pragma checksum "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "803502ad8acb6a4ad1e5f6b2b215e93a75303a12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Characters_All), @"mvc.1.0.view", @"/Views/Characters/All.cshtml")]
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
using SWN.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"803502ad8acb6a4ad1e5f6b2b215e93a75303a12", @"/Views/Characters/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee0bb91199811591498eb248a0ca7599eb2ad95a", @"/Views/_ViewImports.cshtml")]
    public class Views_Characters_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<CharacterPreviewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"card-deck\">\n");
#nullable restore
#line 5 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\All.cshtml"
         foreach (var classPreview in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" style=\"width: 18rem\">\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 237, "\"", 271, 1);
#nullable restore
#line 8 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\All.cshtml"
WriteAttributeValue("", 243, classPreview.CharacterImage, 243, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image\">\n                <div class=\"card-body\">\n                    <h4 class=\"card-title\">");
#nullable restore
#line 10 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\All.cshtml"
                                      Write(classPreview.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4> <h5>[Level ");
#nullable restore
#line 10 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\All.cshtml"
                                                                         Write(classPreview.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\All.cshtml"
                                                                                             Write(classPreview.Background);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\All.cshtml"
                                                                                                                      Write(classPreview.Class);

#line default
#line hidden
#nullable disable
            WriteLiteral("]</h5>\n                    <p class=\"card-text\">\n                        <b>Homeworld:</b> ");
#nullable restore
#line 12 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\All.cshtml"
                                     Write(classPreview.Homeworld);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div></div>\n                        <b>Species:</b> ");
#nullable restore
#line 14 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\All.cshtml"
                                   Write(classPreview.Species);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                    <a href=""#"" class=""btn btn-primary"">View</a>
                </div>
                <div class=""card-footer"">
                    <small class=""text-muted"">Last updated 3 mins ago</small>
                </div>
            </div>
");
#nullable restore
#line 22 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\All.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n\n<hr />\n\n<div class=\"row\">\n    <div class=\"offset-5 col-2\">\n        <div class=\"text-center\">\n            <input type=\"button\" class=\"btn btn-primary\" style=\"width:200px\" value=\"Create Character\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1184, "\"", 1245, 3);
            WriteAttributeValue("", 1194, "location.href=\'", 1194, 15, true);
#nullable restore
#line 31 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\All.cshtml"
WriteAttributeValue("", 1209, Url.Action("Create", "Characters"), 1209, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1244, "\'", 1244, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<CharacterPreviewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
