using Blazor001.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blazor001.Pages
{
    public partial class Items
    {
        ProductSingle producto;

        [Parameter]
        public string cod { get; set; }

        protected async override Task OnInitializedAsync()
        {

           producto=  await GetProducto(cod);
        }



            private async Task<Producto> GetProduct(string code)
        {
            Portafolio porta = new Portafolio();
             List<Producto> list =  await porta.GetProductos();

            var result = list.FirstOrDefault(x => x.cod == code);

            return result;
        }

        public async Task<ProductSingle> GetProducto(string code)
        {
          
            string json = string.Empty;


            HttpClient client = new HttpClient();
            string url = string.Format("{0}{1}.json", $"https://angurlar-html-default-rtdb.firebaseio.com/productos/",code);
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            ProductSingle result = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductSingle>(responseBody);

            return result;


        }

    }
}
