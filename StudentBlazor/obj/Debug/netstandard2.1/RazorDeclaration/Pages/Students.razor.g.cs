#pragma checksum "c:\ASP\ass2resubmit\StudentBlazor\Pages\Students.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3eb8097dd35828f8085255e0c73ba848958fcd8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace StudentBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "c:\ASP\ass2resubmit\StudentBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\ASP\ass2resubmit\StudentBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\ASP\ass2resubmit\StudentBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\ASP\ass2resubmit\StudentBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\ASP\ass2resubmit\StudentBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\ASP\ass2resubmit\StudentBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\ASP\ass2resubmit\StudentBlazor\_Imports.razor"
using StudentBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\ASP\ass2resubmit\StudentBlazor\_Imports.razor"
using StudentBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\ASP\ass2resubmit\StudentBlazor\Pages\Students.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\ASP\ass2resubmit\StudentBlazor\Pages\Students.razor"
using StudentLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students")]
    public partial class Students : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "c:\ASP\ass2resubmit\StudentBlazor\Pages\Students.razor"
       
  Student[] students;
  string baseUrl = "http://localhost:8000/";

  protected override async Task OnInitializedAsync() {
    await load();
  }

  protected async Task load() {
    students = await httpClient.GetFromJsonAsync<Student[]>($"{baseUrl}api/students");
  }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
