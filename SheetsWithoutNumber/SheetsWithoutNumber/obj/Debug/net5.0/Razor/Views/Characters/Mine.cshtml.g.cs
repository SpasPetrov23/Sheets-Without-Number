#pragma checksum "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\Mine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ae86bc5ae9f3a8180f44b69736054dbc1014f8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Characters_Mine), @"mvc.1.0.view", @"/Views/Characters/Mine.cshtml")]
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
using SheetsWithoutNumber.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\_ViewImports.cshtml"
using SWN.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ae86bc5ae9f3a8180f44b69736054dbc1014f8d", @"/Views/Characters/Mine.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9b53b6c00e872578ce92771e0f0296085da825", @"/Views/_ViewImports.cshtml")]
    public class Views_Characters_Mine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<CharacterListingModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Characters", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CharacterDeletePopupPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"card-deck\">\n");
#nullable restore
#line 5 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\Mine.cshtml"
         foreach (var classPreview in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" style=\"width: 18rem\">\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 237, "\"", 271, 1);
#nullable restore
#line 8 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\Mine.cshtml"
WriteAttributeValue("", 243, classPreview.CharacterImage, 243, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image\">\n                <div class=\"card-body\">\n                    <h4 class=\"card-title\">");
#nullable restore
#line 10 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\Mine.cshtml"
                                      Write(classPreview.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4> <h5>[Level ");
#nullable restore
#line 10 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\Mine.cshtml"
                                                                         Write(classPreview.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\Mine.cshtml"
                                                                                             Write(classPreview.Background);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\Mine.cshtml"
                                                                                                                      Write(classPreview.Class);

#line default
#line hidden
#nullable disable
            WriteLiteral("]</h5>\n                    <p class=\"card-text\">\n                        <b>Homeworld:</b> ");
#nullable restore
#line 12 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\Mine.cshtml"
                                     Write(classPreview.Homeworld);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div></div>\n                        <b>Species:</b> ");
#nullable restore
#line 14 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\Mine.cshtml"
                                   Write(classPreview.Species);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ae86bc5ae9f3a8180f44b69736054dbc1014f8d8952", async() => {
                WriteLiteral("View");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-characterId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\Mine.cshtml"
                                                                                   WriteLiteral(classPreview.Id);

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
            WriteLiteral("\n                    <a class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"#deleteCharacterModal\">Delete</a>\n\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ae86bc5ae9f3a8180f44b69736054dbc1014f8d11639", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 19 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\Mine.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = classPreview;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n                <div class=\"card-footer\">\n                    <small class=\"text-muted\">Last updated 3 mins ago</small>\n                </div>\n            </div>\n");
#nullable restore
#line 25 "C:\Users\Spas\SheetsWithoutNumber\SheetsWithoutNumber\SheetsWithoutNumber\Views\Characters\Mine.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<CharacterListingModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591