#pragma checksum "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ThingsAndAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98fb9a4ab03b95cb6d9b4672c966b8ff41d3d31b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Thing_ThingsAndAdd), @"mvc.1.0.view", @"/Views/Thing/ThingsAndAdd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Thing/ThingsAndAdd.cshtml", typeof(AspNetCore.Views_Thing_ThingsAndAdd))]
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
#line 1 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/_ViewImports.cshtml"
using LoginRegistration;

#line default
#line hidden
#line 2 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/_ViewImports.cshtml"
using LoginRegistration.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98fb9a4ab03b95cb6d9b4672c966b8ff41d3d31b", @"/Views/Thing/ThingsAndAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58b8b69ac1923d039b18bb6580c27c9405e8eb6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Thing_ThingsAndAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardThingsAndAdd>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "NewThingPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(23, 316, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "113ac3fa5e5b47e98f0ca16900725e2d", async() => {
                BeginContext(29, 303, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Register</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(339, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(369, 2188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfa9da71fc85427ba1fcd59f21f1e4b2", async() => {
                BeginContext(375, 65, true);
                WriteLiteral("\n\n    <a style=\"float: right;\" href=\"logout\">Logout</a>\n    \n    ");
                EndContext();
                BeginContext(440, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e19c6e49abd24a57a5bb658e7adcabdf", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 15 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ThingsAndAdd.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Thing;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(495, 219, true);
                WriteLiteral("\n    \n    <h3>Welcome to THINGS</h3>\n    <table class=\"table\">\n        <thead>\n            <th>Name</th>\n            <th>Date</th>\n            <th>Users</th>\n            <th>Action</th>\n        </thead>\n        <tbody>\n");
                EndContext();
#line 26 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ThingsAndAdd.cshtml"
              
                foreach(var thing in @Model.Things.OrderByDescending(t => t.Name))
                {

#line default
#line hidden
                BeginContext(830, 55, true);
                WriteLiteral("                    <tr>\n                        <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 885, "\"", 917, 2);
                WriteAttributeValue("", 892, "/dashboard/", 892, 11, true);
#line 30 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ThingsAndAdd.cshtml"
WriteAttributeValue("", 903, thing.ThingId, 903, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(918, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(920, 10, false);
#line 30 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ThingsAndAdd.cshtml"
                                                           Write(thing.Name);

#line default
#line hidden
                EndContext();
                BeginContext(930, 38, true);
                WriteLiteral("</a></td>\n                        <td>");
                EndContext();
                BeginContext(969, 34, false);
#line 31 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ThingsAndAdd.cshtml"
                       Write(thing.Date.ToString("MMM dd yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(1003, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(1038, 17, false);
#line 32 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ThingsAndAdd.cshtml"
                       Write(thing.Users.Count);

#line default
#line hidden
                EndContext();
                BeginContext(1055, 35, true);
                WriteLiteral("</td>\n                        <td>\n");
                EndContext();
#line 34 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ThingsAndAdd.cshtml"
                              
                                if(@Model.UserLoggedIn.UserId == @thing.Creator) 
                                {

#line default
#line hidden
                BeginContext(1237, 38, true);
                WriteLiteral("                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1275, "\"", 1309, 2);
                WriteAttributeValue("", 1282, "/deletething/", 1282, 13, true);
#line 37 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ThingsAndAdd.cshtml"
WriteAttributeValue("", 1295, thing.ThingId, 1295, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1310, 12, true);
                WriteLiteral(">Delete</a>\n");
                EndContext();
#line 38 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ThingsAndAdd.cshtml"
                                }
                                else 
                                {
                                    bool attending = false;
                                    foreach(var user in @thing.Users) 
                                    {
                                        if (user.UserId == @Model.UserLoggedIn.UserId) 
                                        {
                                            attending = true;
                                        }
                                    }
                                    if (attending) 
                                    {

#line default
#line hidden
                BeginContext(1959, 42, true);
                WriteLiteral("                                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2001, "\"", 2042, 2);
                WriteAttributeValue("", 2008, "/uncombineuserthing/", 2008, 20, true);
#line 51 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ThingsAndAdd.cshtml"
WriteAttributeValue("", 2028, thing.ThingId, 2028, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2043, 13, true);
                WriteLiteral(">Un-RSVP</a>\n");
                EndContext();
#line 52 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ThingsAndAdd.cshtml"
                                    } 
                                    else 
                                    {

#line default
#line hidden
                BeginContext(2175, 42, true);
                WriteLiteral("                                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2217, "\"", 2256, 2);
                WriteAttributeValue("", 2224, "/combineuserthing/", 2224, 18, true);
#line 55 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ThingsAndAdd.cshtml"
WriteAttributeValue("", 2242, thing.ThingId, 2242, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2257, 10, true);
                WriteLiteral(">RSVP</a>\n");
                EndContext();
#line 56 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ThingsAndAdd.cshtml"
                                    }
                                }
                            

#line default
#line hidden
                BeginContext(2369, 56, true);
                WriteLiteral("                        </td>\n                    </tr>\n");
                EndContext();
#line 61 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ThingsAndAdd.cshtml"
                }
            

#line default
#line hidden
                BeginContext(2457, 93, true);
                WriteLiteral("        </tbody>\n    </table>\n    <br>\n    <a class=\"btn\" href=\"dashboard/new\">New Thing</a>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2557, 8, true);
            WriteLiteral("\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardThingsAndAdd> Html { get; private set; }
    }
}
#pragma warning restore 1591
