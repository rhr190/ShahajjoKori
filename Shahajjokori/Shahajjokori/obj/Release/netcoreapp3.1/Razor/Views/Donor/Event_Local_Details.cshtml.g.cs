#pragma checksum "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22aa73098b5589e2b9e8cf49e16d4b8b56983adb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Donor_Event_Local_Details), @"mvc.1.0.view", @"/Views/Donor/Event_Local_Details.cshtml")]
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
#line 1 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\_ViewImports.cshtml"
using Shahajjokori;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\_ViewImports.cshtml"
using Shahajjokori.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22aa73098b5589e2b9e8cf49e16d4b8b56983adb", @"/Views/Donor/Event_Local_Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26a33c8e4edb9634ea2c8d4523954a7c7aba6d12", @"/Views/_ViewImports.cshtml")]
    public class Views_Donor_Event_Local_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shahajjokori.Models.Local_Event>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 20vw; max-width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Donor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "donor_index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DonationHistory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Donor_Notification", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("<!--<h1>");
#nullable restore
#line 7 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
   Write(ViewBag.event_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>-->\n<div style=\"background-color: #FDF5E6;\">\n    <div class=\"container\" style=\"padding-top: 5%;\">\n        <div class=\"row\">\n            <div class=\"col-md-12\">\n                <h3 style=\"text-decoration: underline;text-decoration-color: cadetblue\">");
#nullable restore
#line 12 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
                                                                                   Write(Html.DisplayFor(model => model.le_title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n            </div>\n        </div>\n        <div class=\"row\" style=\"margin-top: 3%;\">\n            <div class=\"col-md-6\">\n                <p style=\"font-size:larger\">Created by: ");
#nullable restore
#line 17 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
                                                   Write(ViewBag.org);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<button class=""btn btn-link"" data-toggle=""modal"" data-target=""#exampleModal1"" onclick=""Copy2();"" style=""font-size:19px; text-decoration: none; margin-bottom:0.5%; color:black;""><i class=""fas fa-info-circle""></i></button></p>
                <script type=""text/javascript"">
                    function Copy2() {
                        number.innerHTML='0'+");
#nullable restore
#line 20 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
                                        Write(ViewBag.org_phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n\n                    }\n                </script>\n\n                <p style=\"font-size:large\">Location: ");
#nullable restore
#line 25 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
                                                Write(Html.DisplayFor(model => model.le_location));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n                <p style=\"font-size:large\">Opening: ");
#nullable restore
#line 27 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
                                               Write(Html.DisplayFor(model => model.le_opening_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                \n                <p style=\"font-size:large\">Closing: ");
#nullable restore
#line 29 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
                                               Write(Html.DisplayFor(model => model.le_closing_date));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 29 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
                                                                                                  Write(ViewBag.r_days);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <br>\n\n\n            </div>\n            <div class=\"col-md-6\">\n");
#nullable restore
#line 35 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
                   string pic_name = ViewBag.event_pic;
                    string path = $"~/images/{pic_name}"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "22aa73098b5589e2b9e8cf49e16d4b8b56983adb9646", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
              WriteLiteral(path);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 38 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <br>
                <button type=""button"" class=""btn btn-outline-info"" data-toggle=""modal"" data-target=""#exampleModal3"" onclick=""Copy();"">Share</button>
                <script type=""text/javascript"">
                    function Copy() {
                        urlCopied.innerHTML = window.location.href;
                        urlCopied.innerHTML = urlCopied.innerHTML.replace(""Donor"", ""Home"");
                        urlCopied.innerHTML = urlCopied.innerHTML.split('?')[0];
                    }
                </script>
            </div>

        </div>
        <div class=""row"" style=""margin-top: 5%;"">
            <div class=""col-md-12"">
                <h3>About the Event: </h3>
                <p style=""font-size:large"">");
#nullable restore
#line 54 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
                                      Write(Html.DisplayFor(model => model.le_details));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
        </div>

    </div>
</div>

<!-- Modal -->
<div class=""modal fade"" id=""exampleModal1"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">");
#nullable restore
#line 66 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
                                                          Write(ViewBag.org);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n\n            </div>\n            <div class=\"modal-body\">\n                ");
#nullable restore
#line 70 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
           Write(ViewBag.org_about);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n\n            <div class=\"modal-footer\">\n                Contact: ");
#nullable restore
#line 74 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
                    Write(ViewBag.org_phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<!-- Modal -->
<div class=""modal fade"" id=""exampleModal3"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">");
#nullable restore
#line 85 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
                                                          Write(ViewBag.e_title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
            </div>
            <div class=""modal-body"">
                <textarea id=""urlCopied"" style=""width:100%;""></textarea>
                <a href=""https://www.facebook.com/"" target=""_blank"" class=""fa fa-facebook"" style=""padding: 10px 5px; font-size: 30px; width: 50px; text-align: center; text-decoration: none; margin: 5px 2px; background: #3B5998; color: white;""></a>
                <a href=""https://twitter.com"" target=""_blank"" class=""fa fa-twitter"" style=""padding: 10px 5px; font-size: 30px; width: 50px; text-align: center; text-decoration: none; margin: 5px 2px; background: #55ACEE;color: white;""></a>
                <a href=""https://linkedin.com"" target=""_blank"" class=""fa fa-linkedin"" style=""padding: 10px 5px; font-size: 30px; width: 50px; text-align: center; text-decoration: none; margin: 5px 2px; background: #007bb5;color: white;""></a>
                <a href=""https://instagram.com"" target=""_blank"" class=""fa fa-instagram"" style=""padding: 10px 5px; font-size: 30px; width: 50px; text-align: cen");
            WriteLiteral(@"ter; text-decoration: none; margin: 5px 2px; background: #125688;color: white;""></a>
            </div>

            <div class=""modal-footer"" style=""text-align:center;"">


                <button onclick=""myFunction2()"" style=""border: none; background-color: transparent;"">Copy link</button>
                <script>
                    function myFunction2() {
                        var copyText = document.getElementById(""urlCopied"");
                        copyText.select();
                        copyText.setSelectionRange(0, 99999)
                        document.execCommand(""copy"");
                        //alert(""Copied the link: "" + copyText.value);
                    }
                </script>


                <!--<input class=""modal-footer"" id=""myInput"" value=""");
#nullable restore
#line 110 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
                                                               Write(ViewBag.org_phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" style=""border: none; background-color: transparent;"" readonly>-->
                <!--<button onclick=""myFunction()"" style=""border: none; background-color: transparent;"">Copy Number</button>-->
            </div>
        </div>
    </div>
</div>




<footer style="" bottom: 0; width: 100%; white-space: nowrap; line-height:100px;"">
    <div class=""container"">
        &copy; 2021 - Shahajjokori - ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22aa73098b5589e2b9e8cf49e16d4b8b56983adb17674", async() => {
#nullable restore
#line 122 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
                                                                                                                                    Write(ViewBag.d_name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
                                                                                                              WriteLiteral(ViewBag.d_id);

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
            WriteLiteral(" - ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22aa73098b5589e2b9e8cf49e16d4b8b56983adb20514", async() => {
                WriteLiteral("Donation History");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
                                                                                                                                                                                                                                            WriteLiteral(ViewBag.d_id);

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
            WriteLiteral(" - ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22aa73098b5589e2b9e8cf49e16d4b8b56983adb23189", async() => {
                WriteLiteral("Notification");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Donor\Event_Local_Details.cshtml"
                                                                                                                                                                                                                                                                                                                                                                              WriteLiteral(ViewBag.d_id);

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
            WriteLiteral("\n    </div>\n</footer>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shahajjokori.Models.Local_Event> Html { get; private set; }
    }
}
#pragma warning restore 1591
