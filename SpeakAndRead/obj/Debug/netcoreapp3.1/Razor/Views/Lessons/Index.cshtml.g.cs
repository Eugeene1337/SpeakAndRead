<<<<<<< Updated upstream
<<<<<<< Updated upstream
#pragma checksum "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a612663d7878b9d69172d0432ba17f89827494db"
=======
#pragma checksum "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2417348c507b1f9ae1075a67824e2a7ef03305a"
>>>>>>> Stashed changes
=======
#pragma checksum "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2417348c507b1f9ae1075a67824e2a7ef03305a"
>>>>>>> Stashed changes
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lessons_Index), @"mvc.1.0.view", @"/Views/Lessons/Index.cshtml")]
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
#line 1 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\_ViewImports.cshtml"
using SpeakAndRead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\_ViewImports.cshtml"
using SpeakAndRead.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a612663d7878b9d69172d0432ba17f89827494db", @"/Views/Lessons/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b99ae318d855f9ad02ccac82f58cc6679e37d16", @"/Views/_ViewImports.cshtml")]
    public class Views_Lessons_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SpeakAndRead.Models.Lesson>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:whitesmoke"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lessons</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
 if (User.IsInRole("Admin") || User.IsInRole("Teacher"))
{

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
            WriteLiteral("<div class=\"btn btn-primary\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a612663d7878b9d69172d0432ba17f89827494db5230", async() => {
                WriteLiteral("Create");
=======
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2417348c507b1f9ae1075a67824e2a7ef03305a4850", async() => {
                WriteLiteral("Create New");
>>>>>>> Stashed changes
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
<<<<<<< Updated upstream
<<<<<<< Updated upstream
#line 15 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
=======
#line 14 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
=======
#line 14 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
<<<<<<< Updated upstream
<<<<<<< Updated upstream
#line 21 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
=======
#line 20 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
=======
#line 20 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
           Write(Html.DisplayNameFor(model => model.Course));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
<<<<<<< Updated upstream
<<<<<<< Updated upstream
#line 24 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
=======
#line 23 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
=======
#line 23 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
           Write(Html.DisplayNameFor(model => model.DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
<<<<<<< Updated upstream
<<<<<<< Updated upstream
#line 27 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
=======
#line 26 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
=======
#line 26 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
           Write(Html.DisplayNameFor(model => model.Link));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
<<<<<<< Updated upstream
<<<<<<< Updated upstream
#line 33 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
=======
#line 32 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
=======
#line 32 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
<<<<<<< Updated upstream
<<<<<<< Updated upstream
#line 37 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
=======
#line 36 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
=======
#line 36 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
               Write(Html.DisplayFor(modelItem => item.Course.CourseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
<<<<<<< Updated upstream
<<<<<<< Updated upstream
#line 40 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
=======
#line 39 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
=======
#line 39 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
               Write(Html.DisplayFor(modelItem => item.DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
<<<<<<< Updated upstream
<<<<<<< Updated upstream
#line 43 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
=======
#line 42 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
=======
#line 42 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
               Write(Html.DisplayFor(modelItem => item.Link));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
<<<<<<< Updated upstream
<<<<<<< Updated upstream
#line 46 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
=======
#line 45 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
=======
#line 45 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
                     if (User.IsInRole("Admin") || User.IsInRole("Teacher"))
                    {

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
            WriteLiteral("                    <div class=\"btn btn-primary\">\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a612663d7878b9d69172d0432ba17f89827494db9439", async() => {
=======
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2417348c507b1f9ae1075a67824e2a7ef03305a8923", async() => {
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
                WriteLiteral("Edit");
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
<<<<<<< Updated upstream
<<<<<<< Updated upstream
#line 50 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
=======
#line 47 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
=======
#line 47 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
                                               WriteLiteral(item.LessonId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
<<<<<<< Updated upstream
<<<<<<< Updated upstream
#line 52 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
=======
#line 48 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
=======
#line 48 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
                    }

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
            WriteLiteral("                    \r\n                <div class=\"btn btn-primary\">\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a612663d7878b9d69172d0432ba17f89827494db12031", async() => {
=======
            WriteLiteral("                    \r\n                    |");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2417348c507b1f9ae1075a67824e2a7ef03305a11348", async() => {
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< Updated upstream
<<<<<<< Updated upstream
#line 56 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
                                              WriteLiteral(item.LessonId);
=======
=======
>>>>>>> Stashed changes
#line 50 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
                                               WriteLiteral(item.LessonId);
>>>>>>> Stashed changes

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n");
#nullable restore
<<<<<<< Updated upstream
<<<<<<< Updated upstream
#line 59 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
=======
#line 52 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
=======
#line 52 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
                     if (User.IsInRole("Admin") || User.IsInRole("Teacher"))
                    {

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
            WriteLiteral("                <div class=\"btn btn-danger\">\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a612663d7878b9d69172d0432ba17f89827494db14679", async() => {
=======
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2417348c507b1f9ae1075a67824e2a7ef03305a13840", async() => {
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< Updated upstream
<<<<<<< Updated upstream
#line 63 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
                                             WriteLiteral(item.LessonId);
=======
=======
>>>>>>> Stashed changes
#line 54 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
                                                 WriteLiteral(item.LessonId);
>>>>>>> Stashed changes

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
<<<<<<< Updated upstream
<<<<<<< Updated upstream
#line 65 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
=======
#line 55 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
=======
#line 55 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
<<<<<<< Updated upstream
<<<<<<< Updated upstream
#line 68 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
=======
#line 58 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
=======
#line 58 "C:\Users\iwo\OneDrive\Pulpit\SpeakAndRead\SpeakAndRead\Views\Lessons\Index.cshtml"
>>>>>>> Stashed changes
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SpeakAndRead.Models.Lesson>> Html { get; private set; }
    }
}
#pragma warning restore 1591
