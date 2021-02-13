using Blazor001.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor001.Pages
{
    public partial class SearchPage
    {
      

        [Parameter]
        public string Palabra { get; set; }

        private List<Producto> FilterProductos;


        protected async override Task OnInitializedAsync()
        {
           
            FilterProductos = await ProductosFiltrados ( this.Palabra);
           
        }





            private async Task<List<Producto>> ProductosFiltrados(string item)
        {
            Portafolio portafolio = new Portafolio();
            List<Producto> list = await  portafolio.GetProductos();
            List<Producto> filter = list.Where(i => i.Titulo.ToLower().Contains(item.ToLower())).ToList();

            return filter;

          
        }

    }
}
