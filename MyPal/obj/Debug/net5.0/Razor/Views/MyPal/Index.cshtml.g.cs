#pragma checksum "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69cba091ee204a5bb31935e012a1b37943db68af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyPal_Index), @"mvc.1.0.view", @"/Views/MyPal/Index.cshtml")]
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
#line 1 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69cba091ee204a5bb31935e012a1b37943db68af", @"/Views/MyPal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fef5bfd065350fbaf181bf3ea5f08cc7e24d8af", @"/Views/_ViewImports.cshtml")]
    public class Views_MyPal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyPal.Models.CollectionDataModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/screenreader.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MyPal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-button", "startTime", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-button", "endTime", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PublicEvents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PrivateEvents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69cba091ee204a5bb31935e012a1b37943db68af6608", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"container mb-5\">\r\n    <h1 class=\"text-primary mb-2\">Dashboard</h1>\r\n    <div class=\"container mb-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69cba091ee204a5bb31935e012a1b37943db68af7785", async() => {
                WriteLiteral(" Sort by start time");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-button", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["button"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69cba091ee204a5bb31935e012a1b37943db68af9768", async() => {
                WriteLiteral(" Sort by end time");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-button", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["button"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    \r\n");
#nullable restore
#line 20 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
     if (SignInManager.IsSignedIn(User))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
         if (Model.AttendingPublicEventsList.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4 class=\"text-secondary\">Events that you are attending</h4>\r\n            <div class=\"row justify-content-around\">\r\n");
#nullable restore
#line 25 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                 foreach (var obj in Model.AttendingPublicEventsList)
                {
                    Model.Pinpoints = Model.PinpointsList.Find(pin => pin.Id == obj.PinpointId);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card\" style=\"width:24rem; padding: 20px; margin: 20px;\">\r\n                        <p class=\"text-dark\">Event name: ");
#nullable restore
#line 29 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                                                    Write(obj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"text-dark\">Event description: ");
#nullable restore
#line 30 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                                                           Write(obj.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"text-dark\">Start time: ");
#nullable restore
#line 31 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                                                    Write(obj.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"text-dark\">End time: ");
#nullable restore
#line 32 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                                                  Write(obj.EndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"text-dark\">Capacity: ");
#nullable restore
#line 33 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                                                  Write(obj.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"text-dark\">Location: ");
#nullable restore
#line 34 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                                                  Write(Model.Pinpoints.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 36 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 38 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!--In case that the table is empty-->\r\n            <h6 class=\"text-secondary\">You have not submitted your attendance to any events. Do so by going in the ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69cba091ee204a5bb31935e012a1b37943db68af15295", async() => {
                WriteLiteral("Map section ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" and pressing on the Attend Event button located under any upcoming event.</h6>\r\n");
#nullable restore
#line 43 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4 class=\"text-secondary\">Available Public Events</h4>\r\n");
#nullable restore
#line 46 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
     if (Model.PublicEventsList.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row justify-content-around\">\r\n");
#nullable restore
#line 49 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
             foreach (var obj in Model.PublicEventsList)
            {
                Model.Pinpoints = Model.PinpointsList.Find(pin => pin.Id == obj.PinpointId);

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\" style=\"width:24rem; padding: 20px; margin: 20px;\">\r\n                    <p class=\"text-dark\">Event name: ");
#nullable restore
#line 53 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                                                Write(obj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"text-dark\">Event description: ");
#nullable restore
#line 54 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                                                       Write(obj.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"text-dark\">Start time: ");
#nullable restore
#line 55 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                                                Write(obj.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"text-dark\">End time: ");
#nullable restore
#line 56 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                                              Write(obj.EndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"text-dark\">Capacity: ");
#nullable restore
#line 57 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                                              Write(obj.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"text-dark\">Location: ");
#nullable restore
#line 58 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                                              Write(Model.Pinpoints.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 60 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 62 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!--In case that the table is empty-->\r\n        <h6 class=\"text-secondary\">There are no public events available at the moment. Please wait for an admin to add an upcoming public event.</h6>\r\n");
#nullable restore
#line 67 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
     if (SignInManager.IsSignedIn(User))
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <br>\r\n        <h4 class=\"text-secondary\">Your Private Events</h4>\r\n        <div class=\"row justify-content-around\">\r\n");
#nullable restore
#line 74 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
             if (Model.PrivateEventsList.Count() > 0)
            {


                

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                 foreach (var obj in Model.PrivateEventsList)
                {
                    Model.Pinpoints = Model.PinpointsList.Find(pin => pin.Id == obj.PinpointId);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card\" style=\"width:24rem; padding: 20px; margin: 20px;\">\r\n                        <p class=\"text-dark\">Event name: ");
#nullable restore
#line 82 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                                                    Write(obj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"text-dark\">Event description: ");
#nullable restore
#line 83 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                                                           Write(obj.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"text-dark\">Start time: ");
#nullable restore
#line 84 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                                                    Write(obj.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"text-dark\">End time: ");
#nullable restore
#line 85 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                                                  Write(obj.EndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"text-dark\">Location: ");
#nullable restore
#line 86 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                                                  Write(Model.Pinpoints.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 88 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
                 

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!--In case that the table is empty-->\r\n                <h6 class=\"text-secondary\">You have no upcoming private events. Add one from the ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69cba091ee204a5bb31935e012a1b37943db68af23766", async() => {
                WriteLiteral("calendar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" section.</h6>\r\n                <br>\r\n");
#nullable restore
#line 96 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 98 "E:\SchoolCoding\Campus-Guide\MyPal\Views\MyPal\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            WriteLiteral("<a href=\"#\" class=\"float\" onclick=\"dashboardPagescreenReader()\">\r\n    <i class=\"fa fa-volume-up\" style=\"font-size: 40px; color: white\"></i>\r\n</a>");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyPal.Models.CollectionDataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
