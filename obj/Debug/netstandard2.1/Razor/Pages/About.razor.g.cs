#pragma checksum "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\About.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cfc89dc13a1e4e0a92a4918c647efd8a9fa644e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/About")]
    public partial class About : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "ae-grid au-xs-ta-center au-mb-4");
#nullable restore
#line 7 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\About.razor"
     foreach (var p in listDatos)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "animate fadeIn ae-grid__item item-lg-4 ae-kappa au-mb-3");
            __builder.OpenElement(4, "img");
            __builder.AddAttribute(5, "src", 
#nullable restore
#line 10 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\About.razor"
                       p.Url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "alt", true);
            __builder.AddAttribute(7, "class", "au-mb-3");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "h5");
            __builder.AddAttribute(10, "class", "ae-u-bolder au-mt-2");
            __builder.AddContent(11, 
#nullable restore
#line 11 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\About.razor"
                                             p.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "p");
            __builder.AddAttribute(14, "class", "ae-u-bolder au-mb-3");
            __builder.AddContent(15, 
#nullable restore
#line 12 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\About.razor"
                                            p.Subtitulado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "p");
            __builder.AddAttribute(18, "class", "au-lg-ta-left au-mb-3 au-pl-4 au-pr-4");
            __builder.AddContent(19, 
#nullable restore
#line 13 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\About.razor"
                                                              p.Frase

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", "#0");
            __builder.AddAttribute(23, "class", "ae-u-bolder au-underline");
            __builder.AddContent(24, 
#nullable restore
#line 14 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\About.razor"
                                                           p.Twitter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\About.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.AddMarkupContent(26, @"<div class=""ae-grid au-pt-2""><div class=""ae-grid__item item-lg-8 item-lg--offset-2""><h4 class=""ae-u-bolder"">Title example</h4>
            <p>Totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur.</p></div></div>
    ");
            __builder.AddMarkupContent(27, @"<div class=""ae-grid ae-grid--alt au-xs-ptp-1""><div class=""ae-grid__item--alt item-lg-4""><h6 class=""ae-u-boldest"">About Us</h6>
            <p class=""au-lh-3"">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. </p></div>
        <div class=""ae-grid__item--alt item-lg-4""><h6 class=""ae-u-boldest"">Our Mission</h6>
            <p class=""au-lh-3"">Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. <br>Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p></div>
        <div class=""ae-grid__item--alt item-lg-4""><h6 class=""ae-u-boldest"">Our Clients</h6>
            <p class=""au-lh-3"">Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. </p>
            <p class=""au-lh-3"">Nemo enim ipsam voluptatem quia voluptas</p></div></div>
    ");
            __builder.AddMarkupContent(28, @"<p class=""au-flex au-pt-4 group-buttons""><a href=""portfolio.html"" class=""au-mt-4 arrow-button arrow-button--right arrow-button--out"">
            View Our Portfolio<span class=""arrow-cont""><svg><use xlink:href=""assets/img/symbols.svg#arrow""></use></svg></span></a></p>
    ");
            __builder.OpenElement(29, "footer");
            __builder.OpenComponent<Blazor001.Pages.Shared.FooterPage>(30);
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
