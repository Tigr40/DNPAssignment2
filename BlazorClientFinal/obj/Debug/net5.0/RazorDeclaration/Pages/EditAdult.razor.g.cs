// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorClientFinal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\iliya\RiderProjects\Assignment 2\BlazorClientFinal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\iliya\RiderProjects\Assignment 2\BlazorClientFinal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\iliya\RiderProjects\Assignment 2\BlazorClientFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\iliya\RiderProjects\Assignment 2\BlazorClientFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\iliya\RiderProjects\Assignment 2\BlazorClientFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\iliya\RiderProjects\Assignment 2\BlazorClientFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\iliya\RiderProjects\Assignment 2\BlazorClientFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\iliya\RiderProjects\Assignment 2\BlazorClientFinal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\iliya\RiderProjects\Assignment 2\BlazorClientFinal\_Imports.razor"
using BlazorClientFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\iliya\RiderProjects\Assignment 2\BlazorClientFinal\_Imports.razor"
using BlazorClientFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\iliya\RiderProjects\Assignment 2\BlazorClientFinal\Pages\EditAdult.razor"
using BlazorClientFinal.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\iliya\RiderProjects\Assignment 2\BlazorClientFinal\Pages\EditAdult.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditAdult/{id:int}")]
    public partial class EditAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\iliya\RiderProjects\Assignment 2\BlazorClientFinal\Pages\EditAdult.razor"
       
    private Adult adultToEdit;
    private Job editJob = new Job();
    [Parameter]
    public int Id { get; set; }

    /*protected Task OnInitialized()
    {
        adultToEdit = AdultData.GetAdultByIdAsync(Id);
        editJob = adultToEdit.JobTitle;
    }*/

    private void Edit()
    {
        adultToEdit.JobTitle = new Job()
        {
            JobTitle = editJob.JobTitle,
            Salary = editJob.Salary
        };
        
        AdultData.EditAdultAsync(adultToEdit);
        NavigationManager.NavigateTo("/AdultList");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData AdultData { get; set; }
    }
}
#pragma warning restore 1591