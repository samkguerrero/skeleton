#pragma checksum "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ViewThing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "379a12085bc381a0eb9513aebb9e4c7f48abdb10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Thing_ViewThing), @"mvc.1.0.view", @"/Views/Thing/ViewThing.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Thing/ViewThing.cshtml", typeof(AspNetCore.Views_Thing_ViewThing))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"379a12085bc381a0eb9513aebb9e4c7f48abdb10", @"/Views/Thing/ViewThing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58b8b69ac1923d039b18bb6580c27c9405e8eb6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Thing_ViewThing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Thing>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(23, 316, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5a40fb19e0841f7b2d9a7b361f5b9ba", async() => {
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
            BeginContext(340, 1215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ca8bfaefd3545feb6ba296f9127a1e5", async() => {
                BeginContext(346, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(364, 153, true);
                WriteLiteral("    <a style=\"float: right; margin-left: 25px\" href=\"/logout\">Logout</a>\n    <a style=\"float: right; margin-left: 25px\" href=\"/dashboard\">Dashboard</a>\n\n");
                EndContext();
#line 15 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ViewThing.cshtml"
      
        if(ViewBag.LoggedInUser == @Model.Creator) 
        {

#line default
#line hidden
                BeginContext(586, 26, true);
                WriteLiteral("            <a class=\"btn\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 612, "\"", 646, 2);
                WriteAttributeValue("", 619, "/deletething/", 619, 13, true);
#line 18 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ViewThing.cshtml"
WriteAttributeValue("", 632, Model.ThingId, 632, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(647, 12, true);
                WriteLiteral(">Delete</a>\n");
                EndContext();
#line 19 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ViewThing.cshtml"
        }
        else
        {
            bool attending = false;
            foreach(var user in @Model.Users) 
            {
                if (user.UserId == ViewBag.LoggedInUser) 
                {
                    attending = true;
                }
            }
            if (attending) 
            {

#line default
#line hidden
                BeginContext(977, 30, true);
                WriteLiteral("                <a class=\"btn\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1007, "\"", 1048, 2);
                WriteAttributeValue("", 1014, "/uncombineuserthing/", 1014, 20, true);
#line 32 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ViewThing.cshtml"
WriteAttributeValue("", 1034, Model.ThingId, 1034, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1049, 11, true);
                WriteLiteral(">Leave</a>\n");
                EndContext();
#line 33 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ViewThing.cshtml"
            } 
            else 
            {

#line default
#line hidden
                BeginContext(1107, 30, true);
                WriteLiteral("                <a class=\"btn\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1137, "\"", 1176, 2);
                WriteAttributeValue("", 1144, "/combineuserthing/", 1144, 18, true);
#line 36 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ViewThing.cshtml"
WriteAttributeValue("", 1162, Model.ThingId, 1162, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1177, 10, true);
                WriteLiteral(">Join</a>\n");
                EndContext();
#line 37 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ViewThing.cshtml"
            }
        }
    

#line default
#line hidden
                BeginContext(1217, 9, true);
                WriteLiteral("\n    <h3>");
                EndContext();
                BeginContext(1227, 10, false);
#line 41 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ViewThing.cshtml"
   Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1237, 32, true);
                WriteLiteral("</h3>\n    <p>Event Coordinator: ");
                EndContext();
                BeginContext(1270, 20, false);
#line 42 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ViewThing.cshtml"
                     Write(ViewBag.CreatorsName);

#line default
#line hidden
                EndContext();
                BeginContext(1290, 37, true);
                WriteLiteral("</p>\n    <p>Description: </p>\n    <p>");
                EndContext();
                BeginContext(1328, 17, false);
#line 44 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ViewThing.cshtml"
  Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(1345, 40, true);
                WriteLiteral("</p>\n    <p>Participants: </p>\n    <ul>\n");
                EndContext();
#line 47 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ViewThing.cshtml"
          
            foreach(var userInThing in @Model.Users) 
            {

#line default
#line hidden
                BeginContext(1464, 20, true);
                WriteLiteral("                <li>");
                EndContext();
                BeginContext(1485, 22, false);
#line 50 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ViewThing.cshtml"
               Write(userInThing.User.Fname);

#line default
#line hidden
                EndContext();
                BeginContext(1507, 6, true);
                WriteLiteral("</li>\n");
                EndContext();
#line 51 "/Users/samguerrero/Dropbox/codo/csharp/exam/skeleton/Views/Thing/ViewThing.cshtml"
            }
        

#line default
#line hidden
                BeginContext(1537, 11, true);
                WriteLiteral("    </ul>\n\n");
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
            BeginContext(1555, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Thing> Html { get; private set; }
    }
}
#pragma warning restore 1591
