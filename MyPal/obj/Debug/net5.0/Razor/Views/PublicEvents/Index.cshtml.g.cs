#pragma checksum "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7322548137b5f72f25ddc96159cd4b16c9a485c1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7322548137b5f72f25ddc96159cd4b16c9a485c1", @"/Views/PublicEvents/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fef5bfd065350fbaf181bf3ea5f08cc7e24d8af", @"/Views/_ViewImports.cshtml")]
    public class Views_PublicEvents_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyPal.Models.CollectionDataModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("level-selector"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("GetNavigation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("UpdateNavigation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PublicEvents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AttendEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
<br>

<div class=""container"">
    <button type=""button"" class=""btn btn-primary"" onclick=""GetAllPinpoints()"">View Pinpoints</button>
    <button type=""button"" class=""btn btn-primary"" onclick=""GetPinpointsOfTodaysEvents()"">View Today's Events</button>
</div>


<div class=""container mt-2"" id=""radio-buttons"">
    <h3 class=""text-primary"" id=""status"">No Overlay</h3>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7322548137b5f72f25ddc96159cd4b16c9a485c18108", async() => {
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
                WriteLiteral(@"             Level 0
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
            WriteLiteral("\r\n\r\n    <br >\r\n\r\n    <div id=\"navigation\">\r\n        <video id=\"preview\" width=\"500\" height=\"460\" hidden></video>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7322548137b5f72f25ddc96159cd4b16c9a485c111023", async() => {
                WriteLiteral(@"
            <input id=""TurnOnCamera"" type=""button"" class=""btn btn-outline-secondary"" value=""Present QR Code"" onclick=""turnOnCamera();"" />
            <br >
            <br >
            <input id=""startPointName"" type=""text"" name=""startpoint"" />
            <input id=""endPointName"" type=""text"" name=""endpoint"" />
            
            <input id=""startId"" type=""hidden"" />
            <input id=""endId"" type=""hidden"" />
            <input type=""button"" class = ""btn btn-outline-secondary"" value=""Get Navigation"" onclick=""RetreiveNavigation();"" />
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        \r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7322548137b5f72f25ddc96159cd4b16c9a485c113045", async() => {
                WriteLiteral(@"
            <p>Input new QR Code to Update the Navigation</p>
            <input id=""TurnOnCameraAgain"" type=""button""  value=""Present QR Code"" onclick=""turnOnCamera();"" />
            <input type=""button"" value=""Update Navigation"" onclick=""RetreiveNavigation();"" />
            <br/>
            <input type=""button"" value=""Reset Navigation"" onclick=""ResetNavigation();"" />
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div id=""pastePath""></div>
    </div>
</div>

<div class=""container mb-5"">
    <div class=""row pt-4"">
        <div class=""col-6"">
            <h2 class=""text-primary"">Upcoming Public Events</h2>
        </div>
    </div>

    <!--Validation to check if the table has any content-->
");
#nullable restore
#line 94 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
     if (Model.PublicEventsList.Count() > 0)
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
         foreach (var obj in Model.PublicEventsList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-bordered border-primary table-striped table-responsive"" style=""block-size:100%"">
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
                    <tr>
                        <td ");
            WriteLiteral("width=\"30%\">");
#nullable restore
#line 133 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                                   Write(obj.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"30%\">");
#nullable restore
#line 134 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                                   Write(obj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"40%\">");
#nullable restore
#line 135 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                                   Write(obj.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"50%\">");
#nullable restore
#line 136 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                                   Write(obj.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"50%\">");
#nullable restore
#line 137 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                                   Write(obj.EndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"50%\">");
#nullable restore
#line 138 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                                   Write(obj.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"50%\">");
#nullable restore
#line 139 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                                   Write(obj.PinpointId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n\r\n                </tbody>\r\n            </table>\r\n            <p>Current event attendance for event ");
#nullable restore
#line 144 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                                             Write(obj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 144 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                                                        Write(obj.Attendance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 145 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
             if (User.IsInRole("User"))
            {

                Model.AlreadyAttending = false;
                foreach (var element in Model.PublicEventAttendances)
                {
                    if (element.PublicEventId == obj.Id)
                    {
                        Model.AlreadyAttending = true;
                    }
                }
                if ((obj.Attendance >= obj.Capacity) && Model.AlreadyAttending == false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Unfortunately, the event is fully booked (Boohoo)</p>\r\n");
#nullable restore
#line 159 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                }
                else if (Model.AlreadyAttending == false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7322548137b5f72f25ddc96159cd4b16c9a485c120576", async() => {
                WriteLiteral("\r\n                        <input type=\"submit\" class=\"btn btn-primary mb-1 mr-1\" value=\"Attend Event\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 162 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                                                                        WriteLiteral(obj.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 162 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                                                                                                   WriteLiteral(Model.CurrentUserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["UserId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-UserId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["UserId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 165 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Your attendance has already been notified for this event!</p>\r\n");
#nullable restore
#line 169 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                }





            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 176 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
             if (User.IsInRole("Admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"margin:10px\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7322548137b5f72f25ddc96159cd4b16c9a485c125140", async() => {
                WriteLiteral("\r\n                        Edit\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 179 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                                                       WriteLiteral(obj.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7322548137b5f72f25ddc96159cd4b16c9a485c127652", async() => {
                WriteLiteral("\r\n                        Delete\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 182 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
                                                       WriteLiteral(obj.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 186 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 186 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 187 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
         

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!--In case that the table is empty-->\r\n        <h6 class=\"text-secondary\">There are no public events available at the moment. Please wait for an admin to add an upcoming public event.</h6>\r\n");
#nullable restore
#line 194 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 195 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
     if (User.IsInRole("Admin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-6 text-left\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7322548137b5f72f25ddc96159cd4b16c9a485c131366", async() => {
                WriteLiteral(" Create new public event.");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 200 "E:\SchoolCoding\Campus-Guide\MyPal\Views\PublicEvents\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyPal.Models.CollectionDataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
