#pragma checksum "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dba5aca46fd002e5eb64b3e36b62e1dcaeac22f9"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor001.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\_Imports.razor"
using Blazor001;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\_Imports.razor"
using Blazor001.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\_Imports.razor"
using Entities;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.OpenComponent<Blazor001.Shared.NavMenu>(2);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "main");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "top-row px-4");
            __builder.AddAttribute(8, "style", "z-index:1111;padding-top:0px");
            __builder.AddMarkupContent(9, "<a href=\"https://www.syncfusion.com/blazor-components/\" target=\"_blank\">Blazor Components</a>\r\n        ");
            __builder.AddMarkupContent(10, "<a href=\"https://blazor.syncfusion.com/documentation/\" target=\"_blank\">User Guide</a>\r\n        ");
            __builder.OpenComponent<Blazor001.Pages.SearchProduct>(11);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "content px-4");
            __builder.AddContent(15, 
#nullable restore
#line 15 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n<style></style>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
