#pragma checksum "C:\Users\domin\RiderProjects\APBD_21.05\APBD_21.05\Views\Patients\PatientsTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "609bac2d75cd0919d108498b3100f538a58de996"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patients_PatientsTable), @"mvc.1.0.view", @"/Views/Patients/PatientsTable.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"609bac2d75cd0919d108498b3100f538a58de996", @"/Views/Patients/PatientsTable.cshtml")]
    public class Views_Patients_PatientsTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<APBD_21._05.Model.Patient>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Lista pacjetnów klinki doktora Rzepki</h1>\r\n<br/>\r\n<p>\r\n<table>\r\n");
#nullable restore
#line 7 "C:\Users\domin\RiderProjects\APBD_21.05\APBD_21.05\Views\Patients\PatientsTable.cshtml"
     foreach (var patient in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 10 "C:\Users\domin\RiderProjects\APBD_21.05\APBD_21.05\Views\Patients\PatientsTable.cshtml"
           Write(patient.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 11 "C:\Users\domin\RiderProjects\APBD_21.05\APBD_21.05\Views\Patients\PatientsTable.cshtml"
           Write(patient.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 12 "C:\Users\domin\RiderProjects\APBD_21.05\APBD_21.05\Views\Patients\PatientsTable.cshtml"
           Write(patient.Birthdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 14 "C:\Users\domin\RiderProjects\APBD_21.05\APBD_21.05\Views\Patients\PatientsTable.cshtml"
           Write(Html.ActionLink("Pokaż detale pacjenta", "ShowDetails", "Patients", new {index = 5}, new {@class = "homeBtn"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 17 "C:\Users\domin\RiderProjects\APBD_21.05\APBD_21.05\Views\Patients\PatientsTable.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<APBD_21._05.Model.Patient>> Html { get; private set; }
    }
}
#pragma warning restore 1591
