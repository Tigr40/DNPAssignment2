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
#line 2 "C:\Users\iliya\RiderProjects\Assignment 2\BlazorClientFinal\Pages\AdultList.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AdultList")]
    public partial class AdultList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\iliya\RiderProjects\Assignment 2\BlazorClientFinal\Pages\AdultList.razor"
       
    private IList<Adult> allAdults;
    private IList<Adult> adultsToShow;

    private int? filterById;
    private int? filterByAge;

    /**
     * Initial display
     */
    protected override async Task OnInitializedAsync()
    {
        allAdults = await AdultData.GetAdultsAsync();
        adultsToShow = allAdults;
        
    }

    /**
     * Filters
     */
    private void ExecuteFilter()
    {
        adultsToShow = allAdults.Where(a =>
            (filterById != null && a.Id == filterById || filterById == null) &&
            (filterByAge != null && a.Age == filterByAge || filterByAge == null)
            ).ToList();
    }

    private void FilterByUserId(ChangeEventArgs changeEventArgs)
    {
        filterById = null;
        try
        {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        ExecuteFilter();
    }

    public void FilterByAge(ChangeEventArgs changeEventArgs)
    {
        filterByAge = null;
        try
        {
            filterByAge = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        ExecuteFilter();
    }

    /**
     * Adding, editing and removing
     */

    public void EditAdult(int Id)
    {
        NavigationManager.NavigateTo($"EditAdult/{Id}");
    }

    public void RemoveAdult(int id)
    {
        Adult toRemove = allAdults.First(a => a.Id == id);
        AdultData.RemoveAdultAsync(id); //Remove from storage
        allAdults.Remove(toRemove); //Remove from list
        adultsToShow.Remove(toRemove); //Remove from display
    }








#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.IAdultData AdultData { get; set; }
    }
}
#pragma warning restore 1591