#pragma checksum "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\SearchPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e5795aa460eea0bbe91e2d40329f071d08581cb"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor001.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/resultado/{Palabra}")]
    public partial class SearchPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "au-xs-ta-center au-lg-ta-left");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "ae-masonry ae-masonry-md-2 ae-masonry-xl-4");
#nullable restore
#line 8 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\SearchPage.razor"
         if (FilterProductos == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<h1>Ninguno</h1>");
#nullable restore
#line 11 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\SearchPage.razor"
        }
        else
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\SearchPage.razor"
             foreach (var item in FilterProductos)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "a");
            __builder.AddAttribute(6, "class", "rk-item ae-masonry__item");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "src", 
#nullable restore
#line 18 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\SearchPage.razor"
                               item.Url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "alt", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "item-meta");
            __builder.OpenElement(13, "h2");
            __builder.AddContent(14, 
#nullable restore
#line 20 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\SearchPage.razor"
                             item.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.OpenElement(16, "p");
            __builder.AddContent(17, 
#nullable restore
#line 21 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\SearchPage.razor"
                            item.Categoria

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\SearchPage.razor"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\SearchPage.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
