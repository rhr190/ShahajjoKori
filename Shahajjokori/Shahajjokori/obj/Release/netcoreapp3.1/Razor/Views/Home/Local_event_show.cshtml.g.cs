#pragma checksum "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Local_event_show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14d057d9164cdbcc9173b3da086d4af8cc4f3a4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Local_event_show), @"mvc.1.0.view", @"/Views/Home/Local_event_show.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14d057d9164cdbcc9173b3da086d4af8cc4f3a4b", @"/Views/Home/Local_event_show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26a33c8e4edb9634ea2c8d4523954a7c7aba6d12", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Local_event_show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Local_Event>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("        display: block;\n        height: 15vw;\n        max-width: 100%;\n        object-fit: cover;\n"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Event_Local_Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none;color:black;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Local_event_show.cshtml"
   // var test = Context.GetRouteData().Values["id"];
    Layout = "_Layout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"" style=""text-align: center; margin-bottom:10%;"">
    <div class=""row"" style=""margin-top: 5%; margin-bottom: 3%;"">
        <div class=""col-md-12"" style=""text-align: center;"">
            <h2 style=""text-decoration: underline;text-decoration-color: cadetblue;"">Local Events</h2>
        </div>
    </div>
    <div class=""row"">
");
#nullable restore
#line 15 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Local_event_show.cshtml"
         if (Model.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h5>Sorry, currently no local event is available &#128549;</h5>");
#nullable restore
#line 17 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Local_event_show.cshtml"
                                                                           }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Local_event_show.cshtml"
         foreach (var e in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-4\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14d057d9164cdbcc9173b3da086d4af8cc4f3a4b6920", async() => {
                WriteLiteral("\n            <div class=\"card\" style=\"margin-top: 5%;\">\n");
#nullable restore
#line 23 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Local_event_show.cshtml"
                   string path = "~/images/" + e.le_pic; 

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "14d057d9164cdbcc9173b3da086d4af8cc4f3a4b7524", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Local_event_show.cshtml"
                                   WriteLiteral(path);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 28 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Local_event_show.cshtml"
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
                WriteLiteral("\n\n                <div class=\"card-body\">\n                    <h4 class=\"card-title\">");
#nullable restore
#line 31 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Local_event_show.cshtml"
                                      Write(e.le_title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\n                    <p>");
#nullable restore
#line 32 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Local_event_show.cshtml"
                  Write(e.le_location);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n\n                </div>\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
#line 21 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Local_event_show.cshtml"
                                                                    WriteLiteral(e.le_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>");
#nullable restore
#line 37 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Local_event_show.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Local_Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591
