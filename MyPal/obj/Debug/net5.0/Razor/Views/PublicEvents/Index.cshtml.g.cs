#pragma checksum "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25b78043b327852beb4a27e5f74fd4bc5769ecd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PublicEvents_Index), @"mvc.1.0.view", @"/Views/PublicEvents/Index.cshtml")]
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
#line 1 "E:\SchoolCoding\Campus-Guide\MyPal\Views\_ViewImports.cshtml"
using MyPal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SchoolCoding\Campus-Guide\MyPal\Views\_ViewImports.cshtml"
using MyPal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25b78043b327852beb4a27e5f74fd4bc5769ecd9", @"/Views/PublicEvents/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fef5bfd065350fbaf181bf3ea5f08cc7e24d8af", @"/Views/_ViewImports.cshtml")]
    public class Views_PublicEvents_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyPal.Models.PublicEvents>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("level-selector"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PublicEvents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
  
    ViewData["Title"] = "Map View";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Map -->
<div id=""map""></div>
<button type=""button"" class=""btn btn-primary"" onclick=""GetAllPinpoints()"">View Pinpoints</button>
<button type=""button"" class=""btn btn-primary"" onclick=""GetPinpointsOfTodaysEvents()"">View Today's Events</button>
<div id=""radio-buttons"">
    <h1 id=""status"">No Overlay</h1>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25b78043b327852beb4a27e5f74fd4bc5769ecd95409", async() => {
                WriteLiteral(@"
        <div class=""form-check"">
            <input class=""form-check-input"" type=""radio"" name=""level"" id=""no-overlay"" checked=""checked"" value=""no overlay"">
            <label class=""form-check-label"" for=""no-overlay"">
                No overlay
            </label>
        </div>

        <div class=""form-check"">
            <input class=""form-check-input"" type=""radio"" name=""level"" id=""level -2"" value=""Level -2"">
            <label class=""form-check-label"" for=""level -2"">
                Level -2 Parking
            </label>
        </div>

        <div class=""form-check"">
            <input class=""form-check-input"" type=""radio"" name=""level"" id=""level -1"" value=""Level -1"">
            <label class=""form-check-label"" for=""level -1"">
                Level -1
            </label>
        </div>

        <div class=""form-check"">
            <input class=""form-check-input"" type=""radio"" name=""level"" id=""level 0"" value=""Level 0"">
            <label class=""form-check-label"" for=""level 0"">
 ");
                WriteLiteral(@"               Level 0
            </label>
        </div>

        <div class=""form-check"">
            <input class=""form-check-input"" type=""radio"" name=""level"" id=""level 1"" value=""Level 1"">
            <label class=""form-check-label"" for=""level 1"">
                Level 1
            </label>
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
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"container p-3\">\r\n    <div class=\"row pt-4\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-primary\">Public Events List</h2>\r\n        </div>\r\n    </div>\r\n\r\n    <!--Validation to check if the table has any content-->\r\n");
#nullable restore
#line 63 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-bordered table-striped"" style=""width:100%"">
            <thead>
                <tr>
                    <th>
                        Event Id
                    </th>

                    <th>
                        Event name
                    </th>

                    <th>
                        Event description
                    </th>

                    <th>
                        Start time
                    </th>

                    <th>
                        End time
                    </th>

                    <th>
                        Capacity
                    </th>

                    <th>
                        PinPoint id
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 98 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                 foreach (var obj in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td width=\"30%\">");
#nullable restore
#line 101 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                                   Write(obj.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"30%\">");
#nullable restore
#line 102 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                                   Write(obj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"40%\">");
#nullable restore
#line 103 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                                   Write(obj.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"50%\">");
#nullable restore
#line 104 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                                   Write(obj.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"50%\">");
#nullable restore
#line 105 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                                   Write(obj.EndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"50%\">");
#nullable restore
#line 106 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                                   Write(obj.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"50%\">");
#nullable restore
#line 107 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                                   Write(obj.PinpointId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 109 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 112 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!--In case that the table is empty-->\r\n        <p>There are no public events.</p>\r\n");
#nullable restore
#line 118 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
     if (User.IsInRole("Admin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-6 text-left\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25b78043b327852beb4a27e5f74fd4bc5769ecd912798", async() => {
                WriteLiteral(" Create new public event.");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 124 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public RoleManager<IdentityRole> RoleManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyPal.Models.PublicEvents>> Html { get; private set; }
    }
}
#pragma warning restore 1591
