#pragma checksum "H:\Engineering\6th Semester\Academic\Software Project\Final Project\VotingSystems-backend\Views\Person\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f6387149bf96523b4a23391c66e6b55645aa255"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Index), @"mvc.1.0.view", @"/Views/Person/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f6387149bf96523b4a23391c66e6b55645aa255", @"/Views/Person/Index.cshtml")]
    public class Views_Person_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VotingSystems.Models.Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "H:\Engineering\6th Semester\Academic\Software Project\Final Project\VotingSystems-backend\Views\Person\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Index</h1>\n\n<p>\n    <a asp-action=\"Create\">Create New</a>\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 16 "H:\Engineering\6th Semester\Academic\Software Project\Final Project\VotingSystems-backend\Views\Person\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SerialNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "H:\Engineering\6th Semester\Academic\Software Project\Final Project\VotingSystems-backend\Views\Person\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Voted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "H:\Engineering\6th Semester\Academic\Software Project\Final Project\VotingSystems-backend\Views\Person\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GNDivision));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 28 "H:\Engineering\6th Semester\Academic\Software Project\Final Project\VotingSystems-backend\Views\Person\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 31 "H:\Engineering\6th Semester\Academic\Software Project\Final Project\VotingSystems-backend\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SerialNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 34 "H:\Engineering\6th Semester\Academic\Software Project\Final Project\VotingSystems-backend\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Voted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 37 "H:\Engineering\6th Semester\Academic\Software Project\Final Project\VotingSystems-backend\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GNDivision.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 940, "\"", 964, 1);
#nullable restore
#line 40 "H:\Engineering\6th Semester\Academic\Software Project\Final Project\VotingSystems-backend\Views\Person\Index.cshtml"
WriteAttributeValue("", 955, item.NIC, 955, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1016, "\"", 1040, 1);
#nullable restore
#line 41 "H:\Engineering\6th Semester\Academic\Software Project\Final Project\VotingSystems-backend\Views\Person\Index.cshtml"
WriteAttributeValue("", 1031, item.NIC, 1031, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1094, "\"", 1118, 1);
#nullable restore
#line 42 "H:\Engineering\6th Semester\Academic\Software Project\Final Project\VotingSystems-backend\Views\Person\Index.cshtml"
WriteAttributeValue("", 1109, item.NIC, 1109, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\n            </td>\n        </tr>\n");
#nullable restore
#line 45 "H:\Engineering\6th Semester\Academic\Software Project\Final Project\VotingSystems-backend\Views\Person\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VotingSystems.Models.Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
