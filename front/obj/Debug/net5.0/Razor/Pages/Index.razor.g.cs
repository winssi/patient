#pragma checksum "C:\patient\front\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c7c0d8fc52af6d13f7c541752b4112ec2d65df6"
// <auto-generated/>
#pragma warning disable 1591
namespace front.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\patient\front\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\patient\front\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\patient\front\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\patient\front\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\patient\front\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\patient\front\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\patient\front\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\patient\front\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\patient\front\_Imports.razor"
using front;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\patient\front\_Imports.razor"
using front.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    #listePatient {\r\n        text-decoration: none;\r\n    }\r\n</style>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"alert alert-dark\" role=\"alert\"><p class=\"h1\" id=\"titreL\">Liste des patients</p></div>");
#nullable restore
#line 15 "C:\patient\front\Pages\Index.razor"
 if (Patients == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p class=\"h2\">La liste des patients est vide</p>");
#nullable restore
#line 18 "C:\patient\front\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddAttribute(5, "id", "listePatient");
            __builder.AddMarkupContent(6, "<thead class=\"thead\"><tr><th scope=\"col\">Nom patient</th>\r\n                <th scope=\"col\">Service</th>\r\n                <th scope=\"col\">Description</th>\r\n                <th scope=\"col\"></th></tr></thead>");
#nullable restore
#line 30 "C:\patient\front\Pages\Index.razor"
         foreach (var Patient in Patients)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 33 "C:\patient\front\Pages\Index.razor"
                     Patient.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 34 "C:\patient\front\Pages\Index.razor"
                     Patient.Service

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 35 "C:\patient\front\Pages\Index.razor"
                     Patient.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.AddMarkupContent(17, "<button class=\"btn btn-primary\" type=\"submit\">Detail</button>\r\n                ");
            __builder.AddMarkupContent(18, "<button class=\"btn btn-primary\" type=\"submit\">Modifier</button>\r\n                ");
            __builder.AddMarkupContent(19, "<button class=\"btn btn-primary\" type=\"submit\">Supprimer</button>");
            __builder.CloseElement();
#nullable restore
#line 40 "C:\patient\front\Pages\Index.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 44 "C:\patient\front\Pages\Index.razor"


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\patient\front\Pages\Index.razor"
       

    private Patient[] Patients;

    protected override async Task OnInitializedAsync()
    {
        Patients = await Http.GetFromJsonAsync<Patient[]>("https://localhost:5001/Patient/liste");
    }

    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Service { get; set; }
        public string Description { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
