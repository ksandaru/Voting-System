#pragma checksum "H:\Engineering\6th Semester\Academic\Software Project\Final Project\VotingSystems-backend\Views\VoteCan\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2369bfdadbf28e2f9e5c67f85ac896bfb86ca75d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VoteCan_Create), @"mvc.1.0.view", @"/Views/VoteCan/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2369bfdadbf28e2f9e5c67f85ac896bfb86ca75d", @"/Views/VoteCan/Create.cshtml")]
    public class Views_VoteCan_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VotingSystems.Models.VoteCan>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "H:\Engineering\6th Semester\Academic\Software Project\Final Project\VotingSystems-backend\Views\VoteCan\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>VoteCan</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Time"" class=""control-label""></label>
                <input asp-for=""Time"" class=""form-control"" />
                <span asp-validation-for=""Time"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Candidate_ID"" class=""control-label""></label>
                <select asp-for=""Candidate_ID"" class =""form-control"" asp-items=""ViewBag.Candidate_ID""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""Vote_ID"" class=""control-label""></label>
                <select asp-for=""Vote_ID"" class =""form-control"" asp-items=""ViewBag.Vote_ID""></select>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Crea");
            WriteLiteral("te\" class=\"btn btn-primary\" />\n            </div>\n        </form>\n    </div>\n</div>\n\n<div>\n    <a asp-action=\"Index\">Back to List</a>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 40 "H:\Engineering\6th Semester\Academic\Software Project\Final Project\VotingSystems-backend\Views\VoteCan\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VotingSystems.Models.VoteCan> Html { get; private set; }
    }
}
#pragma warning restore 1591
