#pragma checksum "C:\Users\Büşra\source\repos\SampleSOAGithub\SampleSOAGithub\Views\Random\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7126ace39690f41605636aea4a80053cea98ff0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Random_Index), @"mvc.1.0.view", @"/Views/Random/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Random/Index.cshtml", typeof(AspNetCore.Views_Random_Index))]
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
#line 1 "C:\Users\Büşra\source\repos\SampleSOAGithub\SampleSOAGithub\Views\_ViewImports.cshtml"
using SampleSOAGithub;

#line default
#line hidden
#line 2 "C:\Users\Büşra\source\repos\SampleSOAGithub\SampleSOAGithub\Views\_ViewImports.cshtml"
using SampleSOAGithub.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7126ace39690f41605636aea4a80053cea98ff0", @"/Views/Random/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c794ee3beb8b83a6b7e910f59421fa75dea40d90", @"/Views/_ViewImports.cshtml")]
    public class Views_Random_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SampleSOAGithub.Models.RandomInteger>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Büşra\source\repos\SampleSOAGithub\SampleSOAGithub\Views\Random\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(90, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(138, 24, true);
            WriteLiteral("\r\n\r\n<h3>Random Integer: ");
            EndContext();
            BeginContext(163, 15, false);
#line 10 "C:\Users\Büşra\source\repos\SampleSOAGithub\SampleSOAGithub\Views\Random\Index.cshtml"
               Write(Model.RandomInt);

#line default
#line hidden
            EndContext();
            BeginContext(178, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
            BeginContext(238, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(359, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(534, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SampleSOAGithub.Models.RandomInteger> Html { get; private set; }
    }
}
#pragma warning restore 1591
