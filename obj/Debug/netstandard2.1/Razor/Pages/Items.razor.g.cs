#pragma checksum "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\Items.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d477cbbb9e8800b294f242fe1c68bfbdb78573ef"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/items/{cod}")]
    public partial class Items : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
#nullable restore
#line 4 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\Items.razor"
     if (@producto == null)
    {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<h1>Cragando......</h1>");
#nullable restore
#line 8 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\Items.razor"
    }
    else
    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-lg-12");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "ae-container-fluid ae-container-fluid--inner rk-portfolio--inner");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "ae-grid ae-grid--collapse");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "ae-grid__item item-lg-6");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "src", "assets/productos/" + (
#nullable restore
#line 21 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\Items.razor"
                                                                                     cod

#line default
#line hidden
#nullable disable
            ) + "/pic-1.jpg");
            __builder.AddAttribute(12, "alt", "Urku Portfolio");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "ae-grid__item item-lg-5 item-lg--offset-1 au-lg-ptp-1");
            __builder.OpenElement(16, "h4");
            __builder.AddAttribute(17, "class", "ae-u-bolder");
            __builder.AddContent(18, 
#nullable restore
#line 23 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\Items.razor"
                                                 producto.Producto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "h3");
            __builder.AddAttribute(21, "class", "ae-u-bolder");
            __builder.AddContent(22, 
#nullable restore
#line 24 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\Items.razor"
                                                 producto.Categoria

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "p");
            __builder.AddAttribute(25, "class", "ae-eta");
            __builder.AddContent(26, 
#nullable restore
#line 25 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\Items.razor"
                                           producto.Desc1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "ae-grid--alt test");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "ae-grid__item--alt item-sm--auto item-sm--offset-1 item-lg--offset-0 item-sm--end item-sm--bottom");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "ae-grid ae-grid--alt8 au-xs-ta-center au-sm-ta-left");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "ae-grid__item--alt8 item-lg-6");
            __builder.AddMarkupContent(36, "<span class=\"ae-u-boldest\">1.</span>\r\n                                ");
            __builder.OpenElement(37, "p");
            __builder.AddAttribute(38, "class", "au-mt-1");
            __builder.AddContent(39, 
#nullable restore
#line 33 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\Items.razor"
                                                    producto.Categoria

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "<span class=\"ae-u-boldest\">2.</span>\r\n                                ");
            __builder.OpenElement(41, "p");
            __builder.AddAttribute(42, "class", "au-mt-1");
            __builder.AddContent(43, 
#nullable restore
#line 34 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\Items.razor"
                                                    producto.Subtitulo1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                            ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "ae-grid__item--alt8 item-lg-6");
            __builder.AddMarkupContent(47, "<span class=\"ae-u-boldest\">3.</span>\r\n                                ");
            __builder.OpenElement(48, "p");
            __builder.AddAttribute(49, "class", "au-mt-1");
            __builder.AddContent(50, 
#nullable restore
#line 38 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\Items.razor"
                                                    producto.Subtitulo2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "ae-grid__item--alt item-sm--auto item-lg-3 item-lg--offset-1 item-lg--end");
            __builder.OpenElement(54, "img");
            __builder.AddAttribute(55, "src", "assets/productos/" + (
#nullable restore
#line 42 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\Items.razor"
                                                                                                                                       cod

#line default
#line hidden
#nullable disable
            ) + "/pic-2.jpg");
            __builder.AddAttribute(56, "alt", "Urku Portfolio");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.AddMarkupContent(58, @"<div class=""ae-container-fluid au-pt-4 au-pb-4""><div class=""group-buttons""><a href=""#0"" class=""au-mt-2 arrow-button arrow-button--right"">
                        Next Project<span class=""arrow-cont""><svg><use xlink:href=""assets/img/symbols.svg#arrow""></use></svg></span></a></div></div>");
            __builder.CloseElement();
#nullable restore
#line 60 "C:\Users\jonathan\source\repos\Blazor001\Blazor001\Pages\Items.razor"



    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
